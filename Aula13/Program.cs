namespace Aula13;

public class Programa
{
  public static void Main()
  {
    // do/while - executa pelo menos uma vez
    int numero = 1;

    do
    {
      Console.WriteLine($"Número: {numero}");
      numero++;
    }
    while (numero <= 5);
  }
}