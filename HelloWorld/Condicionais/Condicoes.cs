namespace HelloWorld.Condicionais;

public class Condicoes
{
    static void IfElseElseIf()
    {
        int numero = 10;
        double saldo = 100.50;
        bool ativo = true;
        string autor = "Kayo";
        List<int> lista = new List<int>() { 7, 12 };
        Cor cores = Cor.Preto;

        if (saldo > 0)
        {
            Console.WriteLine("Este numero é positivo");
        }else if (saldo == 0)
        {
            Console.WriteLine("Este número é neutro");
        }
        else
        {
             Console.WriteLine("este numero é negativo");
        }

        if (ativo)
        {
            Console.WriteLine("usario ativo");
        }

        if (autor.Equals("Kayo"))
        {
            Console.WriteLine("o autor se chama Kayo");
        }

        if (lista.Count > 0)
        {
            Console.WriteLine("lista nao vazia");
        }
        
        if (lista.Contains(12))
        {
            Console.WriteLine("lista  contem 12");
        }

        if (cores == Cor.Preto)
        {
            Console.WriteLine("A cor é Preto");
        }
    }
}