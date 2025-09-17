class Program
{
    public static void Main(string[] args)
    {
        string amigo1 = "Juan";
        string amigo2 = "Jorge";
        string amigo3 = "Jose";

        SaludarAmigo(amigo1);
        SaludarAmigo(amigo2);
        SaludarAmigo(amigo3);
    }

    public static void SaludarAmigo(string nombre)
    {
        Console.WriteLine($"¡Hola {nombre}, que tengas un buen dia!");
    }
}