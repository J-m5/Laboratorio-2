using System;

class Program
{
    static void Main()
    {

        int numeroEntero;
        double numeroDecimal;
        string texto;
        bool valorBooleano;

        Console.WriteLine("Ingresa un numero entero: ");
        numeroEntero = int.Parse(Console.ReadLine());

        Console.Write("Ingresa un numero decimal: ");
        numeroDecimal = double.Parse(Console.ReadLine());

        Console.Write("Ingrese un texto: ");
        texto = Console.ReadLine();

        Console.Write("Ingrese un valor veradero o falso (true/false): ");
        valorBooleano = bool.Parse(Console.ReadLine());

        Console.WriteLine("El numero entero es: " + numeroEntero);
        Console.WriteLine("El numero decimal es: " + numeroDecimal);
        Console.WriteLine("El texto es: " + texto);
        Console.WriteLine("el valor booleano es: " + valorBooleano);
    }
}