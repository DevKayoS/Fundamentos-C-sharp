namespace HelloWorld.TiposPrimitivos;

public class String
{
    void Testando()
    {
        // variaveis do tipo texto
        // char -> apenas um caracter
        // string

        char letra = 'a';
        char caracter = '@';

        string texto = "este curso é legal dms";
        char primeiraLetraDoTexto = texto[0];

        string meuNome = "               Kayo Vinicius           ";
        string nomeSemEspaco = meuNome.Trim();

        bool comecaComALetraK = nomeSemEspaco.StartsWith("Kay");
        string textoAposReplace = nomeSemEspaco.Replace('i', '2');

        Console.WriteLine(meuNome);
        Console.WriteLine(nomeSemEspaco);
        Console.WriteLine(comecaComALetraK);
        Console.WriteLine(textoAposReplace);

        bool existe = texto.Contains("curso");
        bool igual = texto.Equals("curso");

        Console.WriteLine(existe);
        Console.WriteLine(igual);

    }
}