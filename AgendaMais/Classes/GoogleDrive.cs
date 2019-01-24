using Google.Apis.Util.Store;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using Google.Apis.Services;

namespace AgendaMais.Classes
{
    //http://www.andrealveslima.com.br/blog/index.php/2017/04/12/utilizando-api-google-drive-no-c-e-vb-net/

    class GoogleDrive
    {
        //https://console.developers.google.com/apis/credentials?project=exemplary-vista-226116&authuser=2
        private static string client_id = Path.GetDirectoryName(Application.ExecutablePath) + "\\client_id.json";

        private static UserCredential Autenticar()
        {
            UserCredential credenciais;

            using (var stream = new FileStream(client_id, FileMode.Open, FileAccess.Read))
            {
                var diretorioAtual = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                var diretorioCredenciais = Path.Combine(diretorioAtual, "credential");

                credenciais = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    new[] { DriveService.Scope.DriveReadonly },
                    "user",
                    CancellationToken.None,
                    new FileDataStore(diretorioCredenciais, true)).Result;
            }

            return credenciais;
        }

        private static DriveService AbrirServico(UserCredential credenciais)
        {
            return new DriveService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credenciais
            });
        }

        private static string[] ProcurarArquivoId(DriveService servico, string nome, bool procurarNaLixeira = false)
        {
            var retorno = new List<string>();

            var request = servico.Files.List();
            request.Q = string.Format("name = '{0}'", nome);
            if (!procurarNaLixeira)
            {
                request.Q += " and trashed = false";
            }
            request.Fields = "files(id)";
            var resultado = request.Execute();
            var arquivos = resultado.Files;

            if (arquivos != null && arquivos.Any())
            {
                foreach (var arquivo in arquivos)
                {
                    retorno.Add(arquivo.Id);
                }
            }

            return retorno.ToArray();
        }

        public static void Download(string arquivo, string destino)
        {
            try
            {
                var credenciais = Autenticar();

                using (var servico = AbrirServico(credenciais))
                {
                    var ids = ProcurarArquivoId(servico, arquivo);
                    if (ids != null && ids.Any())
                    {
                        var request = servico.Files.Get(ids.First());
                        using (var stream = new FileStream(destino, FileMode.Create, FileAccess.Write))
                        {
                            request.Download(stream);
                        }
                    }
                }
            }
            catch
            {
                throw;
            }
        }
    }
}
