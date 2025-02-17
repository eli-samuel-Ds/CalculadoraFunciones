using System;
using System.Diagnostics;

namespace CalculadoraFunciones
{
    internal class Program
    {
        static double Sumar(double a, double b)
        {
            return (a + b);
        }
        static double Restar(double a, double b)
        {
            return (a - b);
        }
        static double Multi(double a, double b)
        {
            return (a * b);
        }
        static double Divi(double a, double b)
        {
            return (a / b);
        }
        static double Pote(double a, double b)
        {
            return Math.Pow(a, b);
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Calculadora Basica:\n");

                Console.Write("Elige que hacer:" +
                              "\n   1. Sumar" +
                              "\n   2. Restar" +
                              "\n   3. Multiplicar" +
                              "\n   4. Dividir" +
                              "\n   5. Potencia" +
                              "\n   6. Salir" +
                              "\nColoca el numero: ");
                string OptionElegir = Console.ReadLine();
                Console.WriteLine();

                switch (OptionElegir)
                {
                    case "1":
                        Console.WriteLine("Sumar");
                        Console.Write("Introduce un numero: ");
                        double a = double.Parse(Console.ReadLine());
                        Console.Write("Introduce un numero: ");
                        double b = double.Parse(Console.ReadLine());
                        Console.WriteLine($"{a} + {b} = {Sumar(a, b)}");
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.WriteLine("Restar");
                        Console.Write("Introduce un numero: ");
                        a = double.Parse(Console.ReadLine());
                        Console.Write("Introduce un numero: ");
                        b = double.Parse(Console.ReadLine());
                        Console.WriteLine($"{a} - {b} = {Restar(a, b)}");
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.WriteLine("Multiplicar");
                        Console.Write("Introduce un numero: ");
                        a = double.Parse(Console.ReadLine());
                        Console.Write("Introduce un numero: ");
                        b = double.Parse(Console.ReadLine());
                        Console.WriteLine($"{a} X {b} = {Multi(a, b)}");
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.WriteLine("Divir");
                        Console.Write("Introduce un numero: ");
                        a = double.Parse(Console.ReadLine());
                        Console.Write("Introduce un numero: ");
                        b = double.Parse(Console.ReadLine());
                        Console.WriteLine($"{a} % {b} = {Divi(a, b)}");
                        Console.ReadKey();
                        break;
                    case "5":
                        Console.WriteLine("Potencia");
                        Console.Write("Introduce un numero: ");
                        a = double.Parse(Console.ReadLine());
                        Console.Write("Introduce un numero: ");
                        b = double.Parse(Console.ReadLine());
                        Console.WriteLine($"{a} ^ {b} = {Pote(a, b)}");
                        Console.ReadKey();
                        break;
                    case "6":
                        return;
                    default:
                        Console.WriteLine("Opcion Invalida");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
