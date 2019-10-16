using System;

namespace Oracion_Palindromo
{
    class Program
    {

        static void Main(string[] args)
        {
            string palabra_Ingresar;
            
            string reverso=" ";
            string palabra_Ingresar_no_espacios=" ";

            Console.WriteLine("Ingresa la oracion: ");
            palabra_Ingresar = Console.ReadLine();
            int pal = palabra_Ingresar.Length;
            for (int x = palabra_Ingresar.Length - 1; x >= 0; x--)
            {
                if (palabra_Ingresar.Substring(x, 1) != " ") { 
                    reverso = reverso + palabra_Ingresar.Substring(x, 1);
                }
            }


            for (int i = 0; i < palabra_Ingresar.Length; i++)
            {
                if (palabra_Ingresar.Substring(i, 1) != " ")
                {
                    palabra_Ingresar_no_espacios += palabra_Ingresar.Substring(i, 1);
                }
            }

           


            if (palabra_Ingresar_no_espacios == reverso)
            {
                Console.WriteLine("ES PALINDRIMO"+palabra_Ingresar_no_espacios);

            }
            else
            {
                Console.WriteLine("NO PALINDRIMO");
            }
            Console.ReadKey();

        }
    }
}
