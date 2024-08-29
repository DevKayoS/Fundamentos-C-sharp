using System.Globalization;

namespace HelloWorld;

class Program
{
    static void Main()
    {
        var carro = new Carro("Ferrari")
        {
            cor = Cor.Vermelho,
            LancadoEm = new DateOnly(2021, 01, 07)
        };
        
        var outroCarro = new Carro("Fuscao Preto")
        {
            cor = Cor.Preto,
            LancadoEm = new DateOnly(1978, 01, 07)
        };

        carro.NomeDoModelo();
        outroCarro.NomeDoModelo();
    }
}
