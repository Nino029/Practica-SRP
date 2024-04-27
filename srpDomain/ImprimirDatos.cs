using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace srpDomain
{
    public class ImprimirDatos
    {

        public void ImprimirPersona(Persona persona)
        {
            Console.WriteLine($"  Nombre: {persona.Nombre}");
            Console.WriteLine($"  Edad: {persona.Edad}");
            Console.WriteLine($"  Dirección: {persona.Direccion}");
            Console.WriteLine($"  Correo Electrónico: {persona.CorreoElectronico}");
        }

    }
}
