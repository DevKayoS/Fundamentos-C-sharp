namespace HelloWorld.Condicionais;

public class Switch
{
    void UsandoSwitchEnum()
    {
        // switch com enum
        Cor cor = Cor.Roxo;

        string fuscao = cor switch
        {
            Cor.Roxo => "fuscao roxo",
            Cor.Preto => "fuscao preto",
            Cor.Azul => "fuscao azul",
            Cor.Verde => "fusca verde",
            _ => "fuscao desconhecido"
        };
        
        switch (cor)
        {
            case Cor.Azul:
            {
                Console.WriteLine("Azul");  
            }
                break;
            case Cor.Preto:
            {
                Console.WriteLine("Preto"); 
            }
                break;
            case Cor.Roxo:
            {
                Console.WriteLine("Roxo");
            }
                break;
            default:
            {
                Console.WriteLine("Outra cor");
            }
                break;
        }
    }

    void UsandoSwitchString()
    {
        string texto = "ze da manga";
        switch (texto)
        {
            case "Kayo":
            {
                Console.WriteLine("O nome é Kayo");
            }
                break;
            case "Julia":
            {
                Console.WriteLine("O nome é Julia");
            }
                break;
            default:
            {
                Console.WriteLine("Outro nome");
            }
                break;
            
        }
    }

    void UsandoSwitchInt()
    {
        int numero = 90;
        string resultado = numero switch
        {
            7 => "Julia",
            9 => "Kayo",
            10 => "ben10",
            12 => "ben12",
            _ => "Nome desconhecido"
        };

        Console.WriteLine(resultado);
        switch (numero)
        {
            case  9:
            {
                Console.WriteLine("meu aniversario");
            }
                break;
            case 7:
            {
                Console.WriteLine("aniversario esposa");
            }
                break;
            case >= 12:
            {
                Console.WriteLine("aniversario ");
            }
                break;
        }  
    }
}