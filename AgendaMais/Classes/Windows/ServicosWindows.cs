using System;
using System.ServiceProcess;

namespace AgendaMais.Classes.Windows
{
    public class ServicosWindows
    {
        public static bool StatusServico(string servicoNome)
        {
            if (string.IsNullOrEmpty(servicoNome))
                throw new Exception("informe o nome do serviço");

            ServiceController servico = new ServiceController(servicoNome);

            if (servico.Status == ServiceControllerStatus.Paused)
                return false;
            else if (servico.Status == ServiceControllerStatus.Stopped)
                return false;
            else
                return true;
        }

        public static void IniciarServico(string servicoNome, int timeoutMilliseconds = 100000)
        {
            if (string.IsNullOrEmpty(servicoNome))
                return;

            ServiceController servico = new ServiceController(servicoNome);

            try
            {
                TimeSpan timeout = TimeSpan.FromMilliseconds(timeoutMilliseconds);
                servico.Refresh();
                if (servico.Status == ServiceControllerStatus.Stopped)
                {
                    servico.Start();
                    servico.WaitForStatus(ServiceControllerStatus.Running, timeout);
                }
                else
                {
                    throw new Exception(string.Format("{0} --> já está iniciado.", servico.DisplayName));
                }
            }
            catch
            {
                throw;
            }
        }

        public static void PararServico(string servicoNome, int timeoutMilliseconds = 100000)
        {
            if (string.IsNullOrEmpty(servicoNome))
                return;

            ServiceController servico = new ServiceController(servicoNome);
            try
            {
                TimeSpan timeout = TimeSpan.FromMilliseconds(timeoutMilliseconds);
                servico.Refresh();

                if (servico.Status == ServiceControllerStatus.Running)
                {
                    servico.Stop();
                    servico.WaitForStatus(ServiceControllerStatus.Stopped, timeout);
                }
                else
                {
                    throw new Exception(string.Format("{0} --> já está parado.", servico.DisplayName));
                }
            }
            catch
            {
                throw;
            }
        }

        public static void ReiniciarServico(string servicoNome, int timeoutMilliseconds = 100000)
        {
            if (string.IsNullOrEmpty(servicoNome))
                return;

            ServiceController servico = new ServiceController(servicoNome);

            try
            {
                int millisec1 = Environment.TickCount;
                TimeSpan timeout = TimeSpan.FromMilliseconds(timeoutMilliseconds);
                servico.Refresh();

                if (servico.Status != ServiceControllerStatus.Stopped)
                {
                    servico.Stop();
                    servico.WaitForStatus(ServiceControllerStatus.Stopped, timeout);

                    // conta o resto do timeout
                    int millisec2 = Environment.TickCount;
                    timeout = TimeSpan.FromMilliseconds(timeoutMilliseconds - (millisec2 - millisec1));

                    servico.Start();
                    servico.WaitForStatus(ServiceControllerStatus.Running, timeout);
                }
                else
                {
                    servico.Start();
                    throw new Exception(string.Format("{0} --> foi parado e a seguir iniciado", servico.DisplayName));
                }
            }
            catch
            {
                throw;
            }
        }
    }
}
