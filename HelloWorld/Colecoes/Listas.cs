namespace HelloWorld.Colecoes;

public class Listas
{
    void UsandoListas()
    {
        List<int> lista = new List<int>();
        
        lista.Add(1);
        lista.Add(2);
        lista.Add(3);
        Console.WriteLine(lista[1]);
        Console.WriteLine(lista.Count);

        lista.Remove(2);
        Console.WriteLine(lista[0]);
        Console.WriteLine(lista.Count);
    }

    void UsandoListasMaisDetalhadas()
    {
        List<string> strings = new List<string>();
        strings.Add("Ola");
        strings.Add("world");
        strings.Add("Kayo");
        strings.Add("Vinicius");

        string resultado = $"{strings[0]} {strings[1]}";

        Console.WriteLine(resultado);

        string resultado2 = string.Join(";", strings);

        Console.WriteLine(resultado2);
        
        List<int> ints = new List<int>();
        ints.Add(1);
        
        List<decimal> decimals = new List<decimal>();
        decimals.Add(2.5m);
        
        List<bool> bools = new List<bool>();
        bools.Add(true);

        List<object> objetos = new List<object>();
        objetos.Add("hello");
        objetos.Add(12);
        objetos.Add(true);
        objetos.Add(2.3);
    }
}