namespace Aula11;

public class Programa
{
  public static void Main()
  {
    // switch - menu simples
    int opcao = 2;

    switch (opcao)
    {
      case 1:
        Console.WriteLine("Você escolheu: Cadastrar");
        break;
      case 2:
        Console.WriteLine("Você escolheu: Listar");
        break;
      case 3:
        Console.WriteLine("Você escolheu: Sair");
        break;
      default:
        Console.WriteLine("Opção inválida.");
        break;
    }
  }
}