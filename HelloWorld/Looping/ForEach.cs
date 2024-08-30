namespace HelloWorld.Looping;

public class ForEach
{
    void UsandoForeach()
    {
        var lista = new List<string> { "Kayo", "Julia", "mango joe" };
    
        foreach (var nome in lista)
        {
            Console.WriteLine(nome);
        }
        
        // dictionary
        var dicionario = new Dictionary<int, string> {{1, "kayo"}, {2, "julia"} };
        foreach (var item in dicionario)
        {
            Console.WriteLine(item);
            Console.WriteLine(item.Key);
            Console.WriteLine(item.Value);
        }
    }
}