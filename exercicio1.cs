using System;
using System.Text;

class numero
{
    static void Main(string[] args)
    {
        Console.OutputEncoding=Encoding.UTF8;
        Console.WriteLine ("Insira um número inteiro:");
        int numero=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine ("você digitou o número "+ numero);
    }
    }