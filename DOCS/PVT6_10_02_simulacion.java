
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
public class PVT6_10_02_simulacion {
 
    float resultado = 0;
    
    int operacion(int variable_1,int variable_2,int operacion)
    {
        switch(operacion){
            case 1: System.out.println("SUMA");
                    resultado = (variable_1+variable_2);
                    break;
            case 2: System.out.println("RESTA");
                    resultado = (variable_1-variable_2);
                    break;
            case 3: System.out.println("MULTIPLICACION ");
                    resultado = (variable_1*variable_2);
                    break;
            case 4: System.out.println("DIVISION ");
                    resultado = (variable_1/variable_2);
                    break;
            case 5: System.out.println("RESIDUO");
                    resultado = (variable_1%variable_2);
                    break;
                
       
        
    
            case 6: System.out.println("MENOR QUE ");
                    if(variable_1<variable_2){
                        System.out.println(+resultado+" "+variable_1+" ES MENOR QUE "+variable_2);
                    }
                   else{
                        System.out.println(+resultado+" "+variable_1+" MENOR QUE "+variable_2);
                    }
                    break;
            case 7: System.out.println("MENOR O IGUAL QUE");
                    if(variable_1<=variable_2){
                        System.out.println(+resultado+" "+variable_1+" MENOR O IGUAL QUE "+variable_2);
                    }
                    else{
                        System.out.println(+resultado+" "+variable_1+" NO MENOR O IGUAL QUE "+variable_2);
                    }
                    break;
            case 8: System.out.println(" MAYOR QUE ");
                    if(variable_1>variable_2){
                        System.out.println(+resultado+" "+variable_1+" MAYOR QUE "+variable_2);
                    }
                    else{
                        System.out.println(+resultado+" "+variable_1+"NO  MENOR O IGUAL QUE "+variable_2);
                    }
                    break;
            case 9: System.out.println("MAYOR O IGUAL A ");
                    if(variable_1>=variable_2){
                        System.out.println(+resultado+" "+variable_1+" MAYOR O IGUAL A "+variable_2);
                    }
                    else{
                        System.out.println(+resultado+" "+variable_1+"NO ES  MAYORR O IGUAL QUE "+variable_2);
                    }
                    break;
        //}
            

    
   
            case 10: System.out.println(" - Diferente - ");
                    if(variable_1!=variable_2){
                        System.out.println(+resultado+" "+variable_1+" ES DIFERENTE DE "+variable_2);
                    }
                    else{
                        System.out.println(+resultado+" "+variable_1+" NO ES DIFERENTE DE "+variable_2);
                    }
                    break;
            case 11: System.out.println(" - Igual - ");
                    if(variable_1==variable_2){
                        System.out.println(+resultado+" "+variable_1+" IGUA A  "+variable_2);
                    }
                    else{
                        System.out.println(+resultado+" "+variable_1+" NO ES IGUAL A  "+variable_2);
                    }
                    break;
        
            case 12:System.out.println(" - AND - ");
                    System.out.println("Se evaluará si ambos valores son mayores a 30");
                     if((30<variable_1) && (30<variable_2)){
                        System.out.println(+resultado+" "+variable_1+" IGUA A  "+variable_2);
                    }
                    break;
            case 13:System.out.println(" - OR - ");
                    System.out.println("Se evaluará si un valores son mayores a 30");
                     if((30<variable_1)|| (30<variable_2)){
                        System.out.println(+resultado+" "+variable_1+" IGUA A  "+variable_2);
                    }
                    break;
        
          }  
    return (int) resultado;
    }
  
}