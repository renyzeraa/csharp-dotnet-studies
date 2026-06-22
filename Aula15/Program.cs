namespace Aula15;

public class Programa
{
  public static void Main()
  {
    // foreach - percorrendo nomes
    string[] nomes = { "Ana", "Bruno", "Carlos" };

    foreach (string nome in nomes)
    {
      Console.WriteLine($"Nome: {nome}");
    }
  }
}