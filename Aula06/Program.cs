namespace Aula06;

public class Programa
{
    public static void Main()
  {
    // condicionais

    Console.WriteLine("Digite sua idade:");
    int idade = int.Parse(Console.ReadLine());

    if (idade >= 18)
    {
      Console.WriteLine("Você é maior de idade.");
    }
    else
    {
      Console.WriteLine("Você é menor de idade.");
    }
  }
}