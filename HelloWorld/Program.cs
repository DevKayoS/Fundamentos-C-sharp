using System.Globalization;

namespace HelloWorld;

class Program
{
    static void Main()
    {
        int numero = 10;

        var meuCarro = new Carro("Fuscao Preto")
        {
            cor = Cor.Preto,
            LancadoEm = new DateOnly(1970, 05, 09)                
        };
        
        meuCarro.NomeDoModelo();

        Console.WriteLine("teste");

    }
}
