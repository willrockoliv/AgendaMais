using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Config_BD.Windows
{
    public class ExecutarComoAdmin : IDisposable
    {
        public ExecutarComoAdmin()
        {
            WindowsPrincipal principal = new WindowsPrincipal(WindowsIdentity.GetCurrent());
            bool administrativeMode = principal.IsInRole(WindowsBuiltInRole.Administrator);
            if (!administrativeMode)
            {
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.Verb = "runas";
                startInfo.FileName = Assembly.GetExecutingAssembly().CodeBase;
                try
                {
                    Process.Start(startInfo);
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Não foi possível conceder acesso como Admin" + Environment.NewLine +
                                    "As operações realizadas poderão ter Acesso Negado !" + Environment.NewLine +
                                    $"ERRO: {erro.Message}", "Admin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public void Dispose()
        {

        }
    }
}
