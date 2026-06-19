namespace Aula10;

public class Programa
{
  public static void Main()
  {
     // if else - calculadora simples
      Console.WriteLine("Digite o primeiro número:");
      double num1 = Convert.ToDouble(Console.ReadLine());

      Console.WriteLine("Digite o segundo número:");
      double num2 = Convert.ToDouble(Console.ReadLine());

      Console.WriteLine("Escolha a operação (+, -, *, /):");
      string operacao = Console.ReadLine();

      double resultado;
      if (operacao == "+")
      {
          resultado = num1 + num2;
          Console.WriteLine($"Resultado: {resultado}");
      }
      else if (operacao == "-")
      {
          resultado = num1 - num2;
          Console.WriteLine($"Resultado: {resultado}");
      }
      else if (operacao == "*")
      {
          resultado = num1 * num2;
          Console.WriteLine($"Resultado: {resultado}");
      }
      else if (operacao == "/")
      {
          if (num2 != 0)
          {
              resultado = num1 / num2;
              Console.WriteLine($"Resultado: {resultado}");
          }
          else
          {
              Console.WriteLine("Erro: Divisão por zero não é permitida.");
          }
      }
      else
      {
          Console.WriteLine("Operação inválida.");
      }
  }
}