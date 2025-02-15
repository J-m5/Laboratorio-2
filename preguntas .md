# Preguntas Programacion
** **
## ¿Para qué crees que se usan los operadores lógicos en programación?
** **
Se usan para evaluar condiciones que dependen de mas de un criterio, permiten combinar varias expresiones logicas y determinar el resultado basado en su combinacion.
## ¿Por qué es importante declarar correctamente el tipo de dato de una variable?
** **
Porque define el tipo de informacion que puede almacenar, optimiza el uso de  memoria y evita errores en el programa.

## Enunciado 1 clasificacion de edad
** **
using System;

class Program

{
    static void Main()

    {
        Console.Write("Ingrese su edad: ");
       
        int edad = Convert.ToInt32(Console.ReadLine());

        if (edad < 12)
        {
            Console.WriteLine("Niño");
        }
        else if (edad >= 12 && edad <= 17)
        {
            Console.WriteLine("Adolescente");
        }
        else if (edad >= 18 && edad <= 59)
        {
            Console.WriteLine("Adulto");
        }
        else
        {
            Console.WriteLine("Adulto mayor");
        }
    }
}

## ¿Qué estructura usarías? ¿if-else o switch? ¿Por qué?
utilice if-else porque debido a que las condiciones no son casos discretos con valores fijos como en switch
** **
## Enunciado 2 Dia de la semana
** **
using System;

class Program

{
    static void Main()

    {
        Console.Write("Ingrese un número del 1 al 7: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        switch (numero)
        {
            case 1:
                Console.WriteLine("Lunes");
                break;
            case 2:
                Console.WriteLine("Martes");
                break;
            case 3:
                Console.WriteLine("Miércoles");
                break;
            case 4:
                Console.WriteLine("Jueves");
                break;
            case 5:
                Console.WriteLine("Viernes");
                break;
            case 6:
                Console.WriteLine("Sábado");
                break;
            case 7:
                Console.WriteLine("Domingo");
                break;
            default:
                Console.WriteLine("Número inválido. Ingrese un número del 1 al 7.");
                break;
        }
    }
}
## ¿Qué estructura usarías? ¿if-else o switch? ¿Por qué?
utilice switch porque tenemos un conjunto de casos discretos que se asocian directamente a un valor.
** **
## Enunciado 3 Verificacion de accesso
** **
using System;

class Program

{
    static void Main()

    {
        string usuarioCorrecto = "admin";
        string contrasenaCorrecta = "1234";

        Console.Write("Ingrese su nombre de usuario: ");
        string usuarioIngresado = Console.ReadLine();

        Console.Write("Ingrese su contraseña: ");
        string contrasenaIngresada = Console.ReadLine();

        if (usuarioIngresado == usuarioCorrecto && contrasenaIngresada == contrasenaCorrecta)
        {
            Console.WriteLine("Acceso concedido");
        }
        else if (usuarioIngresado == usuarioCorrecto && contrasenaIngresada != contrasenaCorrecta)
        {
            Console.WriteLine("Contraseña incorrecta");
        }
        else
        {
            Console.WriteLine("Usuario no registrado");
        }
    }
}

## ¿Qué estructura usarías? ¿if-else o switch? ¿Por qué?
utilice if-else porque switch no permite comparar multiples condiciones al mismo tiempo.
** **


