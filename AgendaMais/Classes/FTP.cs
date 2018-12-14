using System;
using System.Net;
using System.IO;

namespace AgendaMais.Classes
{
    class FTP
    {
        //http://www.macoratti.net/15/07/c_ftpud1.htm

        private static bool ValidaInformacaoServidorFTP(string url, string usuario, string senha)
        {
            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(senha) || string.IsNullOrEmpty(url))
                return false;
            else
                return true;
        }
        private static bool ValidaInformacaoDownload(string url, string destino)
        {
            if (string.IsNullOrEmpty(url) || string.IsNullOrEmpty(destino))
                return false;
            else
                return true;
        }

        /// <summary>
        /// Download de arquivos
        /// </summary>
        /// <param name="url">url do arquivo no ftp</param>
        /// <param name="destino">diretório onde o arquivo será salvo</param>
        /// <param name="usuario"></param>
        /// <param name="senha"></param>
        public static void BaixarArquivoFTP(string url, string destino, string usuario, string senha)
        {
            if (!ValidaInformacaoServidorFTP(url, usuario, senha))
                throw new Exception("Informações para download incompletas");

            if (!ValidaInformacaoDownload(url, destino))
                throw new Exception("Informações do sevidor incompletas");

            try
            {
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(new Uri(url));
                request.Method = WebRequestMethods.Ftp.DownloadFile;
                request.Credentials = new NetworkCredential(usuario, senha);
                request.UseBinary = true;
                using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                {
                    using (Stream rs = response.GetResponseStream())
                    {
                        using (FileStream ws = new FileStream(destino, FileMode.Create))
                        {
                            byte[] buffer = new byte[2048];
                            int bytesRead = rs.Read(buffer, 0, buffer.Length);
                            while (bytesRead > 0)
                            {
                                ws.Write(buffer, 0, bytesRead);
                                bytesRead = rs.Read(buffer, 0, buffer.Length);
                            }
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
