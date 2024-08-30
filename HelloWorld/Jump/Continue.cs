namespace HelloWorld.Jump;

public class Continue
{
    void UsandoContinue()
    {
        var numero = 0;

        while (numero < 10)
        {
            numero++;
            if (numero >= 5 && numero <= 7 ) continue;
            Console.WriteLine(numero);
        }

        Console.WriteLine("aqui");
    }
}