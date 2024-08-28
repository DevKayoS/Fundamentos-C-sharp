namespace HelloWorld.OutrosTiposDeDados;

public class Var
{
    static void UsandoVar()
    {
        string nome = "Kayo Vinicius";
        int meuNumero = 9;
        
        //deixando o compilador escolher  o tipo da variavel
        var nome2 = "kayo Vinicius";

        string meuSobrenome;
        var variavel = DateTime.UtcNow;
        Console.WriteLine(variavel);
    }
}