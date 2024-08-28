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
}