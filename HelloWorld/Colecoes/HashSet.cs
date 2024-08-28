namespace HelloWorld.Colecoes;

public class HashSet
{
    void UsandoHahSet()
    {
        HashSet<int> set =  new HashSet<int>();
        set.Add(1);
        set.Add(2);
        set.Add(3);
        set.Add(3); // hashset aceita apenas valores unicos

        Console.WriteLine(set.Count);
    }
}