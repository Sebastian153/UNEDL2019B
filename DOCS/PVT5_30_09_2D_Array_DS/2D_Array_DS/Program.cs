
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution
{

    // Complete the hourglassSum function below.
    static int hourglassSum(int[][] arr)
    {

        List<int> respuesta = new List<int>();
        int hourglass;
        int hourglassM = 0;


        for (int fila = 0; fila < 4; fila++)
        {
            for (int columna = 0; columna < 4; columna++)
            {
                hourglass = arr[fila][columna] + arr[fila][columna + 1] + arr[fila][columna + 2] + arr[fila + 1][columna + 1] + arr[fila + 2][columna] + arr[fila + 2][columna + 1] + arr[fila + 2][columna + 2];

                respuesta.Add(hourglass);


            }
        }
        hourglassM = respuesta[0];
        for (int i = 0; i < respuesta.Count; i++)
        {

            if (hourglassM < respuesta[i])
            {

                hourglassM = respuesta[i];
            }

        }
        return hourglassM;

    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int[][] arr = new int[6][];

        for (int i = 0; i < 6; i++)
        {
            arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        }

        int result = hourglassSum(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
