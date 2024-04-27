using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace srpDomain
{
    public class EnviarcorreoGmail: IEnviarCorreo
    {

        public void EnviarCorreo(string destinatario, string mensaje)
        {
            Console.WriteLine($" Se ha enviado el correo exitosamente a: {destinatario}, El mensaje es: {mensaje}");

        }
    }
}
