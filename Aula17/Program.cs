namespace Aula17;

public class Programa
{
  public static void Main()
  {
    // listas - adicionando, removendo e acessando itens
    List<string> frutas = new() { "Maçã", "Banana" };

    frutas.Add("Laranja");
    frutas.Remove("Banana");

    Console.WriteLine($"Primeira fruta: {frutas[0]}");
    Console.WriteLine($"Quantidade de itens: {frutas.Count}");

    foreach (string fruta in frutas)
    {
      Console.WriteLine($"Fruta: {fruta}");
    }
  }
}