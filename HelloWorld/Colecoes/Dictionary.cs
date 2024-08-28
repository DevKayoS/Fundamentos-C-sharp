namespace HelloWorld.Colecoes;

public class Dictionary
{
    void UsandoDicionarios()
    {
        Dictionary<int, string> dicionario = new Dictionary<int, string>();
        
        dicionario.Add(1, "Kayo");
        dicionario.Add(2, "Julia");
        dicionario.Add(6, "Mango");

        string valor = dicionario[1];
        bool existe = dicionario.ContainsKey(3);
        
        Console.WriteLine(valor);
        Console.WriteLine(existe);
        
        Dictionary<string, bool> online = new Dictionary<string, bool>(); 
        online.Add("Kayo", true);
        online.Add("Julia", false);

        bool isOnline = online["Julia"];

        Console.WriteLine(isOnline);
    }
}