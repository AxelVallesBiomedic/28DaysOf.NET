int num1;
int num2;
int suma;

Console.Write("Programa para sumar dos numeros \nIngrese primer numero: ");
num1 = int.Parse(Console.ReadLine());
Console.Write("Ingrese segundo numero:");
num2 = int.Parse(Console.ReadLine());

suma = num1 + num2;

Console.WriteLine($"La suma de tus numeros es: {suma}");
