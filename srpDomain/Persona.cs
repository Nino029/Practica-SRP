using static System.Runtime.InteropServices.JavaScript.JSType;

namespace srpDomain
{
  /* Este codigo esta violentando el principio SRP porque  la clase persona tiene  mas de una responsabilidad, Por ejemplo 
  el método enviarCorreoElectronico está relacionado con enviar correos electrónicos, 
  lo cual es una responsabilidad adicional a la de representar la información de una persona.*/

    public class Persona
    {
        public string Nombre { get; private set; }
        public int Edad { get; private set; }
        public string Direccion { get; private set; }
        public string CorreoElectronico { get; private set; }

        public Persona(string nombre, int edad, string direccion, string correoElectronico)
        {
            Nombre = nombre;
            Edad = edad;
            Direccion = direccion;
            CorreoElectronico = correoElectronico;
        }

    }
}
