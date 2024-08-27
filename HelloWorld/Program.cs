namespace HelloWorld;

class Program
{
    static void Main()
    {
        string texto = " o usuario {0} gosta do numero {1}";

        string textFormated = string.Format(texto, "Kayo", "4");

        Console.WriteLine(textFormated)

    }
}
