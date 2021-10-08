using System;
namespace RobertoCobeña3A5
{
	    class Program
    {
       static void Main(string[] args)
	        {
            Console.Write("Ingrese su número entero:");
            int num1 = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num1; i++){
                for (int j = 1; j <= num1-i; j++)
                    Console.Write(" ");
                for (int j = 1; j <= 2*i-1; j++)
                    Console.Write("*");
                Console.Write("\n");}
        }
    }
}