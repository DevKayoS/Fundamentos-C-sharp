namespace HelloWorld;

public class OperacoesMatematicas
{
    public void Adicionar(int valor1, int valor2)
    {
        // valor1 + valor2
        var resultado = valor1 + valor2;

        Console.WriteLine(resultado);
    }

    public void Subtrair(int valor1, int valor2)
    {
        var resultado = valor1 - valor2;

        Console.WriteLine(resultado);
    }
}