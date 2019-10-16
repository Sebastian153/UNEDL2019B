
import java.util.Arrays;
import java.util.Scanner;

//SIMULACION DE MATRICES.-
/*El usuario ingresara el tamaño de la matriz, asi mismo los diagonales de la matriz deberan de onbtener el valor absoluto y luego restar ambas giagonales, en caso de obtener menor que 0 multiplicarlo por -1 */
public class PVT3_13_09_Matriz_Absoluta 
import java.math.*;
import java.security.*;
import java.text.*;
import java.util.*;
import java.util.concurrent.*;
import java.util.regex.*;

class Result {

    /*
     * Complete the 'diagonalDifference' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY arr as parameter.
     */

    public static int diagonalDifference(List<List<Integer>> arr) {
        
                      int fila=arr.size();
                      int columnas= arr.size();
                     int matrizuno[][];
                     

                      
                      int sumaDiagonal =0;
                     int sumaDiagonal2 =0;
                     int sumaTotalDiagonales=0;
                     
                     
                     

                      matrizuno = new int [fila][fila];

                     
                      //Ingreso de valores
        for(int i=0;i<arr.size();i++){
            for(int j=0;j<arr.size();j++){
                            matrizuno[i][j] = arr.get(i).get(j);
            }
      }
        
            for(int i=0;i<matrizuno.length;i++) {    
                sumaDiagonal += matrizuno[i][i]; 
            } 
            for (int i=0;i<matrizuno.length;i++){
                                   sumaDiagonal2 += matrizuno [ i ][ fila - i - 1 ] ;
               }
       

                    sumaTotalDiagonales = sumaTotalDiagonales + sumaDiagonal;
                    sumaTotalDiagonales = sumaTotalDiagonales - sumaDiagonal2;

                       if(sumaTotalDiagonales<0){
                           sumaTotalDiagonales = (sumaTotalDiagonales)*(-1);
                           return sumaTotalDiagonales;
                       }
                       else {
                                 return sumaTotalDiagonales ;

                       }        
            }

}

public class Solution {
    public static void main(String[] args) throws IOException {
        BufferedReader bufferedReader = new BufferedReader(new InputStreamReader(System.in));
   TextWriter textWriter = new StreamWriter(@"C:\Users\super\compare.txt");

        int n = Integer.parseInt(bufferedReader.readLine().trim());

        List<List<Integer>> arr = new ArrayList<>();

        for (int i = 0; i < n; i++) {
            String[] arrRowTempItems = bufferedReader.readLine().replaceAll("\\s+$", "").split(" ");

            List<Integer> arrRowItems = new ArrayList<>();

            for (int j = 0; j < n; j++) {
                int arrItem = Integer.parseInt(arrRowTempItems[j]);
                arrRowItems.add(arrItem);
            }

            arr.add(arrRowItems);
        }

        int result = Result.diagonalDifference(arr);

        bufferedWriter.write(String.valueOf(result));
        bufferedWriter.newLine();

        bufferedReader.close();
        bufferedWriter.close();
    }
}
