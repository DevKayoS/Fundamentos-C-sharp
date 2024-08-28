namespace HelloWorld.OutrosTiposDeDados;

public class Enum
{
    enum NivelDeDificuldade
    {
        Baixo = 0,
        Medio = 1,
        Alto = 2
    }
    static void TrabalhandoComEnum()
    {
        NivelDeDificuldade nivel = NivelDeDificuldade.Alto;

        int nivelInteiro = (int)nivel;
        
        Console.WriteLine(nivel);
        Console.WriteLine(nivelInteiro);
    }
}