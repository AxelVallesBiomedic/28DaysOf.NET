namespace DesafioC__4._59_OperadorTernario
{
    internal class Program
    {
        static int temperatura;
        static string sensacionTermica;

        static void Main(string[] args)
        {
           temperatura = IsNumber();
            SensacionTermica(temperatura);
        }

        static int IsNumber()
        {
            Console.WriteLine("Que temperatura hay afuera? Escribe el valor en numeros");

            string? typedValue = Console.ReadLine();

            bool isNum = int.TryParse(typedValue, out temperatura);

            if (isNum == false)
            {
                Console.WriteLine("Ese valor no es un numero, error");
                Environment.Exit(1);
            }
            return temperatura;
        }

        static void SensacionTermica(int temperatura)
        {
            sensacionTermica = temperatura <= 15 ? "Hace mucho frio" : temperatura >= 16 && temperatura <= 28 ? "Hace un clima agradable" : "Hace mucho calor";

            Console.WriteLine(sensacionTermica);
        }
    }
}
