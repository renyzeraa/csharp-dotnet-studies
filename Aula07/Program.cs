namespace Aula07;

public class Programa
{
    public static void Main()
  {
    // operadores de atribuição

    // iniciar uma variavel
    int x = 10;
    Console.WriteLine($"Valor inicial de x: {x}");

    // operador de atribuição simples
    x = 20;
    Console.WriteLine($"Valor de x após atribuição simples: {x}");

    // operador de atribuição composto
    x += 5; // equivalente a x = x + 5
    Console.WriteLine($"Valor de x após atribuição composta (x += 5): {x}");

    // operador de atribuição composto (incremento)
    x++; // equivalente a x = x + 1
    Console.WriteLine($"Valor de x após incremento (x++): {x}");
  }
}