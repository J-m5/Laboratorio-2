using System;

class Program
{
     static void Main()
    {
        Console.Write("Ingrese el primer numero: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Ingrese el segundo numero: ");
        int num2 = int.Parse(Console.ReadLine());

        Console.WriteLine("La suma de los dos numeros es: " + (num1 + num2));
        Console.WriteLine("La resta de los dos numeros es: " + (num1 - num2));
        Console.WriteLine("La multiplicacion de los dos numeros es: " + (num1 * num2));
        Console.WriteLine("La division de los numeros es: " + (num1 / num2));

        Console.Write("Ingrese un numero decimal: ");
        double num3 = double.Parse(Console.ReadLine());

        Console.Write("Ingrese otro numero decimal: ");
        double num4 = double.Parse(Console.ReadLine());

        Console.Write("Ingrese un numero float: ");
        float num5 = float.Parse(Console.ReadLine());

        Console.Write("Ingrese otro numero float: ");
        float num6 = float.Parse(Console.ReadLine());

        Console.Write("Ingrese un numero int16: ");
        int num7 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese otro numero int16: ");
        int num8 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese un numero Byte (0-255): ");
        byte num9 = byte.Parse(Console.ReadLine());

        Console.Write("Ingrese otro numero Byte (0-255): ");
        byte num10 = byte.Parse(Console.ReadLine());

        Console.WriteLine("La suma de double: " + (num3 + num4));
        Console.WriteLine("La multiplicacion de float: " + (num5 * num6));
        Console.WriteLine("La resta de int16: " + (num7 - num8));
        Console.WriteLine("La division de byte: " + (num9 / num9));

    }
}
