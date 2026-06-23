namespace Aula21; // Todo arquivo tem um namespace, que é o nome do projeto, para evitar conflitos de nomes entre projetos diferentes

public class Car
{
  // Atributos
  public string Marca { get; set; }
  public string Modelo { get; set; }
  public string Cor { get; set; }
  public int Ano { get; set; }


  public static void Main()
  {
    Console.WriteLine("Aula 21");
  }
}