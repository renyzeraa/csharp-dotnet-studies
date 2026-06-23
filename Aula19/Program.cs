namespace Aula19;

public class Programa
{
  public static void Main()
  {
    List<string> listaCompras = new();
    bool continuar = true;

    Console.WriteLine("Aula 19 - Gerenciador de Lista de Compras");

    while (continuar)
    {
      ExibirMenu();
      Console.Write("Escolha uma opcao: ");
      string? opcao = Console.ReadLine()?.Trim();

      switch (opcao)
      {
        case "1":
          ListarItens(listaCompras);
          break;

        case "2":
          AdicionarItem(listaCompras);
          break;

        case "3":
          RemoverItem(listaCompras);
          break;

        case "0":
          continuar = !DesejaSair();
          break;

        case null:
        case "":
          Console.WriteLine("Opcao vazia. Digite um numero valido do menu.");
          break;

        default:
          Console.WriteLine("Opcao invalida. Tente novamente.");
          break;
      }

      Console.WriteLine();
    }

    Console.WriteLine("Programa encerrado.");
  }

  private static void ExibirMenu()
  {
    Console.WriteLine("\n===== MENU =====");
    Console.WriteLine("1 - Listar itens");
    Console.WriteLine("2 - Adicionar item");
    Console.WriteLine("3 - Remover item");
    Console.WriteLine("0 - Sair");
  }

  private static void ListarItens(List<string> listaCompras)
  {
    if (listaCompras.Count == 0)
    {
      Console.WriteLine("Sua lista esta vazia.");
      return;
    }

    Console.WriteLine("\nItens da lista:");
    for (int i = 0; i < listaCompras.Count; i++)
    {
      Console.WriteLine($"{i + 1}. {listaCompras[i]}");
    }
  }

  private static void AdicionarItem(List<string> listaCompras)
  {
    Console.Write("Digite o nome do item para adicionar: ");
    string? item = Console.ReadLine()?.Trim();

    if (string.IsNullOrWhiteSpace(item))
    {
      Console.WriteLine("Nome do item invalido. Nada foi adicionado.");
      return;
    }

    if (listaCompras.Any(i => string.Equals(i, item, StringComparison.OrdinalIgnoreCase)))
    {
      Console.WriteLine("Esse item ja existe na lista.");
      return;
    }

    listaCompras.Add(item);
    Console.WriteLine($"Item '{item}' adicionado com sucesso.");
  }

  private static void RemoverItem(List<string> listaCompras)
  {
    if (listaCompras.Count == 0)
    {
      Console.WriteLine("A lista esta vazia. Nao ha itens para remover.");
      return;
    }

    ListarItens(listaCompras);
    Console.Write("Digite o numero do item para remover: ");
    string? entrada = Console.ReadLine()?.Trim();

    if (!int.TryParse(entrada, out int indiceInformado))
    {
      Console.WriteLine("Entrada invalida. Digite um numero inteiro.");
      return;
    }

    int indiceReal = indiceInformado - 1;
    if (indiceReal < 0 || indiceReal >= listaCompras.Count)
    {
      Console.WriteLine("Numero fora da faixa da lista.");
      return;
    }

    string itemRemovido = listaCompras[indiceReal];
    listaCompras.RemoveAt(indiceReal);
    Console.WriteLine($"Item '{itemRemovido}' removido com sucesso.");
  }

  private static bool DesejaSair()
  {
    Console.Write("Tem certeza que deseja sair? (S/N): ");
    string? resposta = Console.ReadLine()?.Trim();

    if (string.IsNullOrWhiteSpace(resposta))
    {
      Console.WriteLine("Resposta vazia. Retornando ao menu.");
      return false;
    }

    return resposta.Equals("S", StringComparison.OrdinalIgnoreCase)
      || resposta.Equals("SIM", StringComparison.OrdinalIgnoreCase);
  }
}
