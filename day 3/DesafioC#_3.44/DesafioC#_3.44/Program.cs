namespace DesafioC__3._44
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, resultado;

            int resultadoInt;
            Console.WriteLine("Ingresa el numerando: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingresa el denominador: ");
            b = Convert.ToDouble(Console.ReadLine());
            resultado = Division(a, b);
            Console.WriteLine($"El resultado de la division es: {resultado}");

            resultadoInt = (int)resultado;

        }

        public static double Division(double a, double b)
        {
            return a / b;
        }
    }
}
