using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace AgendaMais.Classes
{
    class WhatsApp
    {
        string from_number = "(858) 780-4506";

        WhatsApp(string p_from_number)
        {
            from_number = p_from_number;

            try
            {
                //Enviar SMS
                Twilio.TwilioClient.Init("AC41ce1817ded9ea7083f2a60bfa6a6c61", "f9fc7929c20e7398bd92b9a320c4a62d");

                //Enviar Whats
                Twilio.TwilioClient.Init("AC41ce1817ded9ea7083f2a60bfa6a6c61", "f9fc7929c20e7398bd92b9a320c4a62d");
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        #region Enviar SMS
        private void EnviarSMS(string numero, string msg)
        {
            var resultado = MessageResource.Create(
                to: new PhoneNumber(numero),
                from: new PhoneNumber(from_number),
                body: msg);
        }
        #endregion

        #region Enviar Whats
        private void EnviarWhats(string numero, string msg)
        {
            var message = MessageResource.Create(
               from: new PhoneNumber($"whatsapp:{from_number}"),
               to: new PhoneNumber($"whatsapp:{numero}"),
               body: msg
           );
        }
        #endregion

    }
}
