namespace Aula04;

public class Programa
{
    public static void Main()
  {
    //input e output
    Console.WriteLine("-- Tela de login --");

    Console.WriteLine("Digite seu nome:");
    string nome = Console.ReadLine(); // so le string, para ler outros tipos de dados é necessário converter o valor lido
    Console.WriteLine("Olá, " + nome + "!");

    Console.WriteLine("Digite sua idade:");
    int idade = Convert.ToInt32(Console.ReadLine()); // Convert.ToInt32() é um método que converte uma string em um inteiro, caso a string não seja um número válido, ele lança uma exceção
    Console.WriteLine("Você tem " + idade + " anos.");
  }
}