namespace Aula16;

public class Programa
{
  public static void Main()
  {
    // arrays - acessando posições e tamanho
    int[] numeros = { 10, 20, 30, 40, 50 };

    Console.WriteLine($"Primeiro número: {numeros[0]}");
    Console.WriteLine($"Último número: {numeros[numeros.Length - 1]}");
    Console.WriteLine($"Quantidade de itens: {numeros.Length}");
  }
}