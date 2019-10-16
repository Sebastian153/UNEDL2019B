/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author super
 */

using System.CodeDom.Compiler;
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

class Solution {

    // Complete the compareTriplets function below.
    static List<int> PVT1_02_09_Matriz_Absoluta_Hackerrank(List<int> a, List<int> b) {

    List<int> respuesta = new List<int>();
        int alice=0;
       
        int bob=0; 

 

        int i=0;
        while(i<a.Count){

            if(a[i]>b[i]){
                alice++;
            }else if(a[i]<b[i]){
                bob++;
            }
        i++;
        }
                    respuesta.Add(alice);
                     respuesta.Add(bob);
                    return respuesta;

      
    }
    static void Main(string[] args) {
   TextWriter textWriter = new StreamWriter(@"C:\Users\super\compare.txt");

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

            List<int> result = CompareTriplets(a, b);

            textWriter.WriteLine(String.Join(" ", result));


        textWriter.Flush();
        textWriter.Close();
    }
}
