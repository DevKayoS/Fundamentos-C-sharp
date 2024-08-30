namespace HelloWorld.Looping;

public class For
{
    void UsandoFor()
    {
        List<string> listaNome = new List<string> {"Kayo", "Julia", "Rafaela" };
        listaNome.Add("Andreia");
        listaNome.Add("Fabiana");
        listaNome.Add("Rogerio");
        listaNome.Add("Viniciu");

        // FINALMENTE ENTENDI ESSA MERDA DE LOOPING
        for (int i = 0; i < listaNome.Count; i++)
        {
            Console.WriteLine(listaNome[i]);
        }
    }
}