using System.Globalization;

namespace HelloWorld;

class Program
{
    static void Main()
    {
        int numero = 10;
        double saldo = 100.50;
        bool ativo = true;
        string autor = "Kayo";
        List<int> lista = new List<int>() { 7, 12 };
        Cor cores = Cor.Preto;

        if (cores == Cor.Preto && numero >= 0 && ativo == false)
        {
            Console.WriteLine("passando");
        }
    }
}
