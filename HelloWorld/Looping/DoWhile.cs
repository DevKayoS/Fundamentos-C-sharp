namespace HelloWorld.Looping;

public class DoWhile
{
    void UsandoDoWhile()
    {
        var numero = 10;

        do
        {
            Console.WriteLine("Teste");
            numero++;
        } while (numero < 10);

        Console.WriteLine(numero);
    }
}