namespace Aula09;

public class Programa
{
  public static void Main()
  {
    // Operadores Lógicos

    Console.WriteLine("Operadores lógicos");
    bool estaLogado = true;
    bool possuiPermissaoAdmin = false;

    Console.WriteLine("O usuário está logado? " + estaLogado);
    Console.WriteLine("O usuário possui permissão de administrador? " + (estaLogado && possuiPermissaoAdmin));

    if (estaLogado)
    {
      Console.WriteLine("O usuário tem acesso ao sistema.");
      if (possuiPermissaoAdmin)
      {
        Console.WriteLine("O usuário tem acesso às funcionalidades de administrador.");
      }
      else
      {
        Console.WriteLine("O usuário não tem acesso às funcionalidades de administrador.");
      }
    }
    else
    {
      Console.WriteLine("O usuário não tem acesso ao sistema.");
    }

    if (estaLogado || possuiPermissaoAdmin)
    {
      Console.WriteLine("O usuário tem acesso ao sistema ou é administrador.");
    }
    else
    {
      Console.WriteLine("O usuário não tem acesso ao sistema e não é administrador.");
    }
  }
}