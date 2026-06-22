using System.Text;

namespace Aula18;

public class Programa
{
  public static void Main()
  {
    Console.WriteLine("Aula 18 - System.IO (arquivos e diretorios)");

    string pastaBase = Path.Combine(AppContext.BaseDirectory, "dados");
    Directory.CreateDirectory(pastaBase);

    string caminhoArquivo = Path.Combine(pastaBase, "anotacoes.txt");
    string caminhoCopia = Path.Combine(pastaBase, "anotacoes-copia.txt");
    string caminhoMovido = Path.Combine(pastaBase, "anotacoes-movido.txt");

    // 1) Criar arquivo e escrever conteudo inicial.
    File.WriteAllText(caminhoArquivo, "Primeira linha criada com File.WriteAllText.\n");

    // 2) Inserir mais conteudo no final (append).
    File.AppendAllText(caminhoArquivo, "Segunda linha adicionada com File.AppendAllText.\n");
    File.AppendAllLines(caminhoArquivo, new[]
    {
      "Terceira linha com File.AppendAllLines.",
      "Quarta linha com data/hora: " + DateTime.Now
    });

    // 3) Ler o arquivo inteiro.
    Console.WriteLine("\nConteudo completo do arquivo:");
    Console.WriteLine(File.ReadAllText(caminhoArquivo));

    // 4) Ler linha por linha.
    Console.WriteLine("Linhas separadas:");
    string[] linhas = File.ReadAllLines(caminhoArquivo, Encoding.UTF8);
    for (int i = 0; i < linhas.Length; i++)
    {
      Console.WriteLine($"[{i + 1}] {linhas[i]}");
    }

    // 5) Informacoes do arquivo.
    FileInfo info = new(caminhoArquivo);
    Console.WriteLine("\nInformacoes do arquivo original:");
    Console.WriteLine($"Nome: {info.Name}");
    Console.WriteLine($"Tamanho: {info.Length} bytes");
    Console.WriteLine($"Criado em: {info.CreationTime}");
    Console.WriteLine($"Ultima alteracao: {info.LastWriteTime}");

    // 6) Copiar e mover arquivo.
    File.Copy(caminhoArquivo, caminhoCopia, overwrite: true);
    Console.WriteLine("\nArquivo copiado para: " + caminhoCopia);

    if (File.Exists(caminhoMovido))
    {
      File.Delete(caminhoMovido);
    }

    File.Move(caminhoCopia, caminhoMovido);
    Console.WriteLine("Arquivo movido para: " + caminhoMovido);

    // 7) Criar arquivo com StreamWriter (outra forma de escrita).
    string caminhoLog = Path.Combine(pastaBase, "log.txt");
    using (StreamWriter writer = new(caminhoLog, append: true))
    {
      writer.WriteLine("--- Novo registro ---");
      writer.WriteLine("Horario: " + DateTime.Now);
      writer.WriteLine("Arquivo principal existe? " + File.Exists(caminhoArquivo));
    }

    // 8) Listar arquivos da pasta.
    Console.WriteLine("\nArquivos na pasta de dados:");
    string[] arquivos = Directory.GetFiles(pastaBase);
    foreach (string arquivo in arquivos)
    {
      Console.WriteLine(Path.GetFileName(arquivo));
    }

    // 9) Exemplo de delecao segura.
    string caminhoTemporario = Path.Combine(pastaBase, "temporario.txt");
    File.WriteAllText(caminhoTemporario, "Arquivo temporario para excluir.");

    if (File.Exists(caminhoTemporario))
    {
      File.Delete(caminhoTemporario);
      Console.WriteLine("\nArquivo temporario removido com sucesso.");
    }

    Console.WriteLine("\nFim da aula 18.");
  }
}
