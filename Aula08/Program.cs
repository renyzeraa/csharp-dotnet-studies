namespace Aula08;

public class Programa
{
    public static void Main()
  {
     // operadores relacionais

     Console.WriteLine("Operadores relacionais");
     Console.WriteLine("Digite o primeiro número: ");
     int.TryParse(Console.ReadLine(), out int numero1);

     Console.WriteLine("Digite o segundo número: ");
     int.TryParse(Console.ReadLine(), out int numero2);

     Console.WriteLine($"O primeiro número é maior que o segundo? {numero1 > numero2}");
     Console.WriteLine($"O primeiro número é menor que o segundo? {numero1 < numero2}");
     Console.WriteLine($"O primeiro número é igual ao segundo? {numero1 == numero2}");
     Console.WriteLine($"O primeiro número é diferente do segundo? {numero1 != numero2}");
    
  }
}