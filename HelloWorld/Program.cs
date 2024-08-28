using System.Globalization;

namespace HelloWorld;

class Program
{
    static void Main()
    {
        var matematica = new OperacoesMatematicas();
        
        matematica.Adicionar(valor1: 1, valor2: 8);
        
        matematica.Subtrair(valor1: 1, valor2: 8);
        matematica.Subtrair(valor2: 8, valor1: 1);
    }
}
