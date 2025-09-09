// Se ingresan tres valores por teclado, si todos son iguales se imprime la suma del primero 
// con el segundo y a este resultado se lo multiplica por el tercero.

using System;

namespace tres_valores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Increse numero 1: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Increse numero 2: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.Write("Increse numero 3: ");
            int num3 = int.Parse(Console.ReadLine());
            int suma;
            int producto;

            if (num1 == num2 && num1 == num3)
            {
                suma = num1 + num2;
                producto = suma * num3;
                Console.WriteLine($"La suma del primero con el segundo es: {suma}");
                Console.WriteLine($"El resultado de la suma multiplicado por el 3ro es: {producto}");
            }
            else
            {
                Console.WriteLine("Los tres numeros no son iguales");
            }

            Console.ReadLine();
        }
    }
}