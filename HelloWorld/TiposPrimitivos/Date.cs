using System.Globalization;

namespace HelloWorld.TiposPrimitivos;

public class Date
{
    void Teste()
    {
        DateOnly dia = new DateOnly(2024, 12, 1);

        string diaEmTexto = dia.ToString("dd MMMM yyyy", new CultureInfo("pt-br"));    
        string diaEmTextoTeste = dia.ToLongDateString();

        DateTime dataHora = new DateTime(2024, 12, 1, 20,12,1);

        DateTime hoje = DateTime.Today;
        DateTime hojeHora =  DateTime.UtcNow;

        DateTime novaData = hojeHora.AddDays(1);
        
        Console.WriteLine(hoje);
        Console.WriteLine(hojeHora);
        Console.WriteLine(novaData);
    }
}