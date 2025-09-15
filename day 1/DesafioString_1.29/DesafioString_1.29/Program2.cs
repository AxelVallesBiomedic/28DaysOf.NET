

Console.WriteLine("Ingrese su nombre");
string nombre = Console.ReadLine();

Console.WriteLine("Ingrese su apellido");
string apellido = Console.ReadLine();

string nombreCompleto = string.Concat(nombre + " " + apellido);

Console.WriteLine($"Su nombre completo es: {nombreCompleto}");