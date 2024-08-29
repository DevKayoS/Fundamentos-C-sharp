using System.Globalization;

namespace HelloWorld;

class Program
{
    static void Main()
    {
        var resultado = OperacoesMatematicas.Adicionar(1, 2);

        var carro = new Carro("Fuscao Preto");
        var carro2 = new Carro("Ferrari");
        
        carro.NomeDoModelo();
        carro2.NomeDoModelo();
        
        
    }
}
