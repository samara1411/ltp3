using System;
using System.Text;

class calculadora
{
    static void Main(string[] args)
    {
        Console.OutputEncoding=Encoding.UTF8;
        Console.WriteLine ("Insira o primeiro número para somar com outro:");
        int numero1=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine ("Insira o outro  número para somar com o primeiro:");
        int numero2=Convert.ToInt32(Console.ReadLine());
        int soma=numero1+numero2;
            if (numero1==numero2)
            {
                int triplo=3*soma;
                Console.WriteLine ("Os valores que você digitou são iguais, logo o triplo da soma é :"+triplo);
            }
            else{
                Console.WriteLine ("A soma dos valores digitados acima é :" + soma);
            }
        }
}