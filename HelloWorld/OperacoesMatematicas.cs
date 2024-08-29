namespace HelloWorld;

public class OperacoesMatematicas
{
    public int Adicionar(int valor1, int valor2) => valor1 + valor2;

    public (int resultadoDaAdicao, string autor) Somar(int valor1, int valor2, string name)
    {
        var resultado = valor1 + valor2;

        return (resultado, name);
    }

    public void Teste(int valor1, int valor2 = 9, string author = "Kayo")
    {
        Console.WriteLine(valor1 + valor2);
        Console.WriteLine(author);
    }
}