using System;
using System.Text;

class numero_par
{
    static void Main(string[] args)
    {
        Console.OutputEncoding=Encoding.UTF8;
        Console.WriteLine ("Insira um número pra saber se ele é um número par ou impar:");
        int numero=Convert.ToInt32(Console.ReadLine());
            if (numero % 2==0)
            {
            Console.WriteLine ("O "+ numero + " é um número par");
            }
            else
            {
                Console.WriteLine ("O "+ numero + " é um número impar");
            }
        }
}