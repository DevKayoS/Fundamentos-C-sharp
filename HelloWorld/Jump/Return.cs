namespace HelloWorld.Jump;

public class Return
{
    static void UsandoReturn()
    {
    
        var texto = Teste(5);
        Console.WriteLine(texto);
    }

    static string Teste(int numero)
    {

        Console.WriteLine("Teste 1");
        if (numero == 5)
        {
            Console.WriteLine("teste 2");
            return "kayo";
        }
        
        Console.WriteLine("Teste 3");

        return "Jujuba";
    }
}