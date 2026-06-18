namespace Aula03;

public class Programa
{
    public static void Main()
  {
    // variável consigo atribuir novos valores
    int number = 10;

    Console.WriteLine("O número é: " + number);

    number = 20;

    Console.WriteLine("O número agora é: " + number);

    Console.WriteLine("================================");

    // constante não consigo atribuir novos valores
    const string nome = "Renan";
    Console.WriteLine("O nome é: " + nome);

    // nome = "Leandro"; // Isso causará um erro de compilação, pois 'nome' é uma constante

    Console.WriteLine("================================");

    // Variável de tipo var, o tipo é inferido pelo compilador, atribui o valor e o tipo automaticamente
    var idade = 30; // O tipo de 'idade' é inferido como int
    Console.WriteLine("A idade é: " + idade);

    Console.WriteLine("================================");

    // Variável de tipo dynamic, o tipo é determinado em tempo de execução, pode ser alterado durante a execução do programa
    dynamic valor = 10; // O tipo de 'valor' é inicialmente int
    Console.WriteLine("O valor é: " + valor);
    valor = "uma string"; // O tipo de 'valor' muda para string em tempo de execução
    Console.WriteLine("O valor agora é: " + valor);
  }
}