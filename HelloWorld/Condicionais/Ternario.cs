namespace HelloWorld.Condicionais;

public class Ternario
{
    void UsandoTernario()
    {
        int numero = 7;
        string autor = numero == 7 || numero < 10 ? "Kayo" : "ze da manga";

        Console.WriteLine(autor);
    }
}