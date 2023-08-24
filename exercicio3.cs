using System;
using System.Text;

class calculadora_Idade
{
    static void Main(string[] args)
    {
        Console.OutputEncoding=Encoding.UTF8;//para exibir corretamente os caracteres acentuados
        Console.WriteLine ("Digite o ano em que você nasceu:");
        int anoNascimento=Convert.ToInt32(Console.ReadLine());
        int idade=DateTime.Now.Year-anoNascimento;
        
        Console.WriteLine("Você tem "+ idade + " anos de idade.");
    }
}