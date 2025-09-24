namespace DesafioC__5._69_ProfesorPromedios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int calificacion = 0;
            double suma = 0;
            double promedio = 0;
            int contador = 0;
            string? texto = "";

            Console.WriteLine("Ingrese las calificaciones del alumno, cuando haya ingresado todas escriba `Fin` para obtener promedio");

            do
            {
                texto = Console.ReadLine();

                if(texto.ToLower() == "fin")               
                   break;              

                if (int.TryParse(texto, out calificacion))
                {
                    if (calificacion >= 0 && calificacion <= 10)
                    {
                        suma += calificacion;
                        contador++;
                    }

                    else
                        Console.WriteLine("Calificacion no valida, intente nuevamente");
                }

                else              
                    Console.WriteLine("Valor no es un numero, intente nuevamente");
                
            } while (texto != "Fin");

            if(contador == 0)
            {
                Console.WriteLine("No se ingresaron calificaciones validas");
                return;
            }

            promedio = suma / contador;
            Console.WriteLine($"El promedio del alumno es: {promedio}");
        }
    }
}
