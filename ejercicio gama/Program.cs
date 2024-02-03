// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main(string[] args)
    {
        //declaracion de variables
        int a = 10;
        int b = 15;
        int c = 20;

        Console.WriteLine("Valor de A " + a);
        Console.WriteLine("Valor de B " + b);
        Console.WriteLine("Valor de C " + c);
        Console.WriteLine();

        //operaciones
        a = a + 10;
        b = b + 5;
        c = c + 5;

        Console.WriteLine("El valor final de A es " + a);
        Console.WriteLine($"El valor final de B es {b}");
        Console.WriteLine($"El valor final de C es {c}");

        Console.WriteLine("Introduzca el primer valor");
        double num1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Introduzca el segundo valor");
        double num2 = double.Parse(Console.ReadLine());

        //proceso
        double suma = num1 + num2;
        double resta = num1 - num2;
        double multiplicar = num1 * num2;
        double divide = num1 / num2;
        double resto = num1 % num2;

        Console.WriteLine($"Este es el resultado de la suma: {suma}");
        Console.WriteLine($"Este es el resultado de la resta: {resta}");
        Console.WriteLine($"Este es el resultado de la multiplicación: {multiplicar}");
        Console.WriteLine($"Este es el resultado de la división: {divide}");
        Console.WriteLine($"Este es el resultado del resto: {resto}");
    }
}