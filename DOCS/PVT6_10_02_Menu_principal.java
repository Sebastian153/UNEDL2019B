
import java.util.Scanner;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author super
 */
public class PVT6_10_02_Menu_principal{

    static int digito1;
    static int digito2;
    static int operacion;
    static int resultado;
  

    public static void main(String[] args) {
        Scanner entrada = new Scanner(System.in);
        PVT6_10_02_simulacion op = new PVT6_10_02_simulacion();

        
        System.out.print("Ingrese el primer valor: ");
        digito1 = entrada.nextInt();
        System.out.print("Ingrese el segundo valor: ");
        digito2 = entrada.nextInt();
        

            System.out.println(" ////////////////////OPERADORES/////////////////// ");
            
            System.out.println("\n________ARITMETICOS__________");
            System.out.println("\n1.-SUMA +");
            System.out.println("\n2.-RESTA -");
            System.out.println("\n3.-MULTIPLICACION *");
            System.out.println("\n4.-DIVISION /");
            System.out.println("\n5.-PORCENTAJE %");
            
            System.out.println("\n________RELACIONALES__________");
            System.out.println("\n6.- MENOR QUE  <");
            System.out.println("\n7.- MENOR O IGUAL QUE <=");
            System.out.println("\n8.- MAYOR QUE >");
            System.out.println("\n9.- MAYOR O IGUAL QUE >=");
            System.out.println("\n10.- DECREMENTO ++");
            System.out.println("\n11.- MAYOR O IGUAL QUE - -");


            System.out.println("\n________LOGICOS__________");
            System.out.println("\n12.- NO ES IGUAL  A  != ");
            System.out.println("\n13.- IGUAL A ==");
            System.out.println("\n14.- LOGICO Y && ");
            System.out.println(" \n 15 LOGICO O ||");
                        
          
            System.out.println("Preciones 0 para salir");
            
        for(int i=0;i<5;i++){
            System.out.print("Ingrese el operador: ");
            operacion = entrada.nextInt();
            
            System.out.println("\nResultados");
            
            if (operacion >= 1 && operacion <= 5) {
                System.out.println("Operador Aritmético");
                resultado = op.operacion(digito1, digito2, operacion);
                System.out.println(" = "+resultado);
                
            }
          else if(operacion >= 6 && operacion <=9){
                System.out.println("Operador Relacional");
                resultado = op.operacion(digito1, digito2, operacion);
                System.out.println(" = "+resultado);
            }
           else if(operacion >=10 && operacion <=11){
                System.out.println("Operador de Equidad");
                resultado = op.operacion(digito1, digito2, operacion);
                System.out.println(" = "+resultado);
            }
            else if(operacion>=12 && operacion<=13){
                System.out.println("Operadores Lógicos");
                resultado = op.operacion(digito1, digito2, operacion);
                System.out.println("La expresion es: "+resultado);
            }
         
            i--;
        }

        

        

    }

}