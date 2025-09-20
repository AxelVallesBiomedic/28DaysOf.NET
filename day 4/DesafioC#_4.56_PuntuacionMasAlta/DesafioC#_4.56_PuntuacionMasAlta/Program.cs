namespace DesafioC__4._56_PuntuacionMasAlta
{
    internal class Program
    {
        static string nombre;
        static int puntaje;

        static int puntajeMasAlto = 69420;
        static string nombreGanadorMaximo = "Joe Mama";

        static void Main(string[] args)
        {
            PuntajeObtenido();
        }

        static void PuntajeObtenido()
        {
            Console.WriteLine("Ingrese puntaje obtenido");
            puntaje = Convert.ToInt32(Console.ReadLine());

            if(puntaje > puntajeMasAlto)
            {
                Console.WriteLine("Nuevo puntaje maximo obtenido!!");
                while (string.IsNullOrEmpty(nombre))
                {
                    Console.WriteLine("Ingrese Su nombre: ");
                    nombre = Console.ReadLine();

                    if (string.IsNullOrEmpty(nombre))
                    {
                        Console.WriteLine("El nombre no puede estar vacio");
                    }                
                }
                puntajeMasAlto = puntaje;
                nombreGanadorMaximo = nombre;

                Console.WriteLine($"La puntuacion mas alta ahora es de {puntajeMasAlto}, obtenida por el jugador {nombreGanadorMaximo}");
            }

            else
            {
                Console.WriteLine($"La puntuacion mas alta sigue siendo {puntajeMasAlto}, obtenida por el jugador {nombreGanadorMaximo}");
            }
        }
    }
}
