string var1;
string var2;
int var3;

Console.Write("Ingrese un texto aqui: ");
var1 = Console.ReadLine();

Console.Write("Ingrese la letra buscada:");
var2 = Console.ReadLine();

Console.WriteLine($"{var1}, {var2}");

var3 = var1.IndexOf(var2);

Console.Write($"El indice de la primera aparicion del caracter buscado en el string es: {var3}");