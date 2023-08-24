using System;
using System.Text;

class calculadora
{
    static void Main(string[] args)
    {
        Console.OutputEncoding=Encoding.UTF8;
        Console.WriteLine ("Insira o número que você quer saber a tabuada dele:");
        int numero=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine ("A tabuada do numero "+ numero + " é:  \n");
            for (int i=1; i<=10; i++)
            {
                int resultado=numero * i;
            Console.WriteLine (numero+" X "+ i +" = "+ resultado);
            }
        }
}