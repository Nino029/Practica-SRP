
using srpDomain;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("\n");
        Console.WriteLine("======PERSONA:=======");
        Persona persona = new Persona(" Baljeet", 30, "123 Calle Principal", "Baljeet@gmail.com");

       
        ImprimirDatos imprimir = new ImprimirDatos();
        imprimir.ImprimirPersona(persona);

     
        IEnviarCorreo enviarcorreo = new EnviarcorreoGmail();
        Console.WriteLine("\n");
        Console.WriteLine("======Correo Enviado:=======");
        var mensaje = "Hola usted fue Contratado por la empresa Claro en la India";
        enviarcorreo.EnviarCorreo(persona.CorreoElectronico, mensaje);


    }
}