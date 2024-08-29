namespace HelloWorld;
internal class Carro
{
  public string Modelo { get; set;}
  public DateOnly LancadoEm { get; set; }
  public Cor cor { get; set; }


  public Carro(string modelo)
  {
    Modelo = modelo;
  }

  public void NomeDoModelo() => Console.WriteLine(Modelo);
  public void CorDoCarro() => Console.WriteLine(cor);
  public void DataDeLancamento() => Console.WriteLine(LancadoEm);
  
  
}



