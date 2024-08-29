namespace HelloWorld.funcoes;

public class Funcoes
{
    public void UsandoFuncoes()
    {
        var matematica = new OperacoesMatematicas();
        
        int resultado = matematica.Adicionar(valor1: 1, valor2: 8);

        var resultadoComNome = matematica.Somar(valor1: 10, valor2: 32,  name: "Kayo");

        int numeroResultado = resultadoComNome.resultadoDaAdicao; 
        string nomeResultado = resultadoComNome.autor; 
        
        Console.WriteLine(resultadoComNome);
        Console.WriteLine(numeroResultado);
        Console.WriteLine(nomeResultado);
        
        (int resultadoa, string name) = matematica.Somar(valor1: 10, valor2: 32,  name: "Kayo");

        Console.WriteLine(resultadoa);
        Console.WriteLine(name);
    }
}