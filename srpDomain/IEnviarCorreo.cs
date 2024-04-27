using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace srpDomain
{
    public interface IEnviarCorreo
    {
        void EnviarCorreo(string destinatario, string mensaje);

    }
}
