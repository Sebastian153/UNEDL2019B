using System;

namespace pilaecuaciones
{
    using System.Collections;

    class Program

    {

        static void Main(string[] args)

        {

            Console.WriteLine("Ingresar la ecuacion para ver si es congruente o incongruente:  ");

            String IngresarEcuacion = Console.ReadLine();



            Stack ecuacionEvaluar = new Stack();



            for (int i = 0; i < IngresarEcuacion.Length; ++i)

            {

                if ((IngresarEcuacion[i] == '(') || (IngresarEcuacion[i] == '{') || (IngresarEcuacion[i] == '['))

                {

                    ecuacionEvaluar.Push(IngresarEcuacion[i]);

                }

                else if (ecuacionEvaluar.Count > 0)

                {

                    switch (IngresarEcuacion[i])

                    {

                        case ']':
                            ecuacionEvaluar.Pop();

                            break;

                        case '}':
                            ecuacionEvaluar.Pop();

                            break;

                        case ')':
                            ecuacionEvaluar.Pop();

                            break;

                    }

                }

            }

            if (ecuacionEvaluar.Count == 0)

            {

                Console.WriteLine("LA ECUACION ESTA CORRECTA");

            }

            else

            {

                Console.WriteLine("LA ECUACION NO ES CORRECTA");

            }

        }

    }

}
