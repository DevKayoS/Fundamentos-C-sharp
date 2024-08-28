namespace HelloWorld.OutrosTiposDeDados;

public class Null
{
    static void UsandoNull()
    {
        int? idade = null;

        bool informouIdade = idade.HasValue;

        Console.WriteLine(informouIdade);
    }
}