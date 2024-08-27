using HelloWorld.Teste;

namespace HelloWorld;

class Program
{
    // executar sem retornar nada
    static void Main()
    {
        Carro meuCarro = new Carro();

        meuCarro.Ligar();
        meuCarro.Desligar();


        Biscoito meuBiscoito = new Biscoito();

        meuBiscoito.Temperatura();
    }
}
