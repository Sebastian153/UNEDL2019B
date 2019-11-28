using System;
public delegate int Numbers(int Numero1, int Numero2, int Numero3, int Numero4, int Numero5);

namespace Delegados
{
    class Program
    {
        
        static int Numero1 = 0, Numero2 = 0, Numero3 = 0, Numero4 = 0, Numero5 = 0;
        static int suma = 0, mayor = 0, promedio = 0;

        public static int Suma(int Numero1, int Numero2, int Numero3, int Numero4, int Numero5)
        {
            suma = Numero1 + Numero2 + Numero3 + Numero4 + Numero5;
            return suma;
        }

        public static int Promedio(int Numero1, int Numero2, int Numero3, int Numero4, int Numero5)
        {
            promedio = (Numero1 + Numero2 + Numero3 + Numero4 + Numero5) / 5;
            return promedio;
        }


        public static int Mayor(int Numero1, int Numero2, int Numero3, int Numero4, int Numero5)
        {
            if (Numero1 > Numero2 && Numero1> Numero3 && Numero1 > Numero4 && Numero1 > Numero5)
            {
                mayor = Numero1;
            }
            
            else if (Numero2 > Numero1 && Numero2 > Numero3 && Numero2 > Numero4 && Numero2 > Numero5)
            {
                mayor = Numero2;
            }
            
            else if (Numero3 > Numero1 && Numero3 > Numero2 && Numero3 > Numero4 && Numero3 > Numero5)
                    {
                mayor = Numero3;
            }
            else if (Numero4 > Numero1 && Numero4 > Numero2 && Numero4 > Numero3 && Numero4 > Numero5)
            {
                mayor = Numero4;
            }
            else if (Numero5 > Numero1 && Numero5 > Numero2 && Numero5 > Numero3 && Numero5 > Numero4)
            {
                mayor = Numero5;
            }

            return mayor;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca el primer valor: ");
            Numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca el segundo valor: ");
            Numero2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca el tercer valor: ");
            Numero3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca el cuarto valor: ");
            Numero4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca bel quinto valor: ");
            Numero5 = int.Parse(Console.ReadLine());

            Numbers numero1 = new Numbers(Suma);
            Numbers numero2 = new Numbers(Promedio);
            Numbers numero3 = new Numbers(Mayor);
            numero1(Numero1, Numero2, Numero3, Numero4, Numero5);
            numero2(Numero1, Numero2, Numero3, Numero4, Numero5);
            numero3(Numero1, Numero2, Numero3, Numero4, Numero5);

            Console.WriteLine("La suma de los 5 numeros es de: {0}", suma);
            Console.WriteLine("El promedio de los valores es: {0}", promedio);
            Console.WriteLine("El valor mayor es de: {0}", mayor);
            Console.ReadKey();
        }
    }
}