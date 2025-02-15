using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el primer numero: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el segundo numero: ");
        int num2 = int.Parse(Console.ReadLine());

        Console.WriteLine("num1 > num2: num1 > num2");
        Console.WriteLine("num1 < num2: num1 < num2");
        Console.WriteLine("num1 == num2: num1 == num2");

        Console.WriteLine("num1 > 0 && num2 > 0: (ambos positivos): num1 > 0 && num2 > 0");
        Console.WriteLine("num1 < 0 || num2 < 0: (al mennos uno negativo): num1 < 0 || num2 < 0");







    }
}

