namespace HelloWorld;

public static class OperacoesMatematicas
{
    public static int Adicionar(int valor1, int valor2) => valor1 + valor2;

    public static  (int resultadoDaAdicao, string autor) Somar(int valor1, int valor2, string name)
    {
        var resultado = valor1 + valor2;

        return (resultado, name);
    }

  
}