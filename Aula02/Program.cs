namespace Aula02;

public class Programa
{
    public static void Main()
  {
    // Comentário de uma linha

    /*
     * Comentário de múltiplas linhas
     * Pode ser usado para explicar o código ou desativar temporariamente
     */

    string nome = "Renan"; // Declaração de uma variável do tipo string

    Console.WriteLine("Olá, mundo! Meu nome é " + nome);

    int idade = 28; // Declaração de uma variável do tipo int

    Console.WriteLine("Eu tenho " + idade + " anos.");

    double altura = 1.78; // Declaração de uma variável do tipo double

    Console.WriteLine("Minha altura é " + altura + " metros.");

    char letra = 'R'; // Declaração de uma variável do tipo char
    // usamos somente quando quermos definir um caractere, como uma letra ou símbolo

    Console.WriteLine("A primeira letra do meu nome é " + letra + ".");

    bool estudante = true; // Declaração de uma variável do tipo bool

    Console.WriteLine("Sou estudante? " + (estudante ? "Sim" : "Não"));
  }
}