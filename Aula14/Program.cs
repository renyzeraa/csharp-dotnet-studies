namespace Aula14;

public class Programa
{
  public static void Main()
  {
    // for - tabuada do 5
    int numero = 5;

    for (int i = 1; i <= 10; i++)
    {
      Console.WriteLine($"{numero} x {i} = {numero * i}");
    }
  }
}