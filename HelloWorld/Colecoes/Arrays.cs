namespace HelloWorld.Colecoes;

public class Arrays
{
    void UsandoArrays()
    {
        // arrays precisam ter tamanhos fixos
        int[] inteiros = new int[10];
        
        inteiros[0] = 1;
        inteiros[1] = 5;
        inteiros[2] = 10;
        
        // dizendo que o array tem 10 linhas e 10 colunas
        int[,] inteiros2 = new int[10, 10];

        inteiros2[0, 0] = 1;
        inteiros2[0, 3] = 2;

        Console.WriteLine(inteiros2[0,0]);
        Console.WriteLine(inteiros2[0,1]);
        Console.WriteLine(inteiros2[0,2]);
        Console.WriteLine(inteiros2[0,3]);
    }
}