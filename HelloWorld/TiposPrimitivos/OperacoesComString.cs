using System.Text;

namespace HelloWorld.TiposPrimitivos;

public class OperacoesComString
{
    void Tesntando()
    {
        string caminho = @"C:\teste\outraPasta\zeDaManga";

        string texto1 = "A primeira frase";
        string texto2 = "A segunda frase";

        string paragrafo = texto1 + " " + texto2;

        string paragrafo2 = $"{texto1} {texto2}";

        StringBuilder stringBuilder = new StringBuilder();

        stringBuilder.Append(paragrafo);
        stringBuilder.Append(paragrafo2);

        string resultado = stringBuilder.ToString();

        Console.WriteLine(paragrafo2);
        Console.WriteLine(resultado);


        string texto = " o usuario {0} gosta do numero {1}";

        string textFormated = string.Format(texto, "Kayo", 7);


        Console.WriteLine(textFormated);
    }
}