namespace DesafioC__4._53_LoginUsuario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? usuarioRegistro;
            string? passwordRegistro;
            bool logexitoso = false;
            string? user;
            string password;


            Console.WriteLine("=== Registro de Usuario ===");
            Console.Write("Ingrese un nombre de usuario: ");
            usuarioRegistro = Console.ReadLine();
            Console.Write("Ingrese una contraseña: ");
            passwordRegistro = Console.ReadLine();

            while (logexitoso == false)
            { 
            
                Console.WriteLine("\n=== Inicio de Sesión ===");
                Console.Write("Ingrese su nombre de usuario: ");

                user = Console.ReadLine();

                Console.Write("Ingrese su contraseña: ");
                password = Console.ReadLine();

                if (user == usuarioRegistro && password == passwordRegistro)
                {
                    Console.WriteLine($"Inicio de sesión exitoso, ¡Bienvenido {user}!");
                    logexitoso = true;
                }

                else
                {
                    Console.WriteLine("Error: Nombre de usuario o contraseña incorrectos. Intente de nuevo.");
                }

            }

        }
    }
}
