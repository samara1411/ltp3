using System;

public class nomecompleto
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Escreva seu nome completo: "); // perguntar ao usuário
        string nomeUsuario = Console.ReadLine(); // criar uma variável

        Console.WriteLine("Escreva sua idade: "); // perguntar ao usuário
        int idadeUsuario = Convert.ToInt32(Console.ReadLine()); // criar uma variável inteira
       Console.WriteLine("Seu nome completo: " + nomeUsuario.ToUpper()); // imprimir a variável
       Console.WriteLine("Seu nome completo: " + nomeUsuario.ToLower()); // imprimir a variável
       string nomeSemEspacos = nomeUsuario.Replace(" ", "");
       Console.WriteLine("Seu nome tem : " + nomeSemEspacos.Length+" caracteres");
       int ano=2023 - idadeUsuario;
       int cem=ano+100;
        Console.WriteLine("Voce nasceu em "+ ano + " e completara 100 anos em " +cem );
      
    }
}
