using System.Text;

namespace HelloWorld
{
     class TiposPrimitivos
    {
        void Numericos()
        {   
            double numero1 = 3.14;
            float numero2 = 0.14f;
            decimal numero3 = 3.14m;


            int numero4 = 1000;
        }

        void Boolean()
        {
            bool ativo = false;
            bool ativo2 = true;
        }

        void String()
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

        void OperacoesComString()
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
        }

    }
}
