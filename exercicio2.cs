using System;
using System.Text;

class nome_completo
{
    static void Main(string[] args)
    {
        Console.OutputEncoding=Encoding.UTF8;
        Console.WriteLine ("Insira seu nome:");
        string primeiro_nome=Console.ReadLine(); 
        Console.WriteLine ("Insira seu sobrenome:");
        string segundo_nome=Console.ReadLine(); 
        Console.WriteLine ("Seu nome completo é "+ primeiro_nome  + " " + segundo_nome);
        
        }
}