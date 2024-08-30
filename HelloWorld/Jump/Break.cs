namespace HelloWorld.Jump;

public class Break
{
    void UsandoBreak()
    {
        var numero = 0;

        while (numero < 100)
        {
            Console.WriteLine(numero);
            if (numero == 5) break;
            
            numero++;
        }

        Console.WriteLine("aqui");
    }
}