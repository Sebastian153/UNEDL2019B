/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

import java.util.Scanner;
import java.util.UUID;



 /*Existen en la carrera de Ingenieria de Software de la UNEDL
ocho semestres, cada semestre cuenta con diferente cantidad
de alumnos, cada alumno tiene una calificacion distinta por
cada materia.Utilizando "Jagged Arrays" implemente un algoritmo
que despliegue las calificaciones de cada alumno y de cada semestre.*/
 
public class PVT10_10_09_Jagged_Arrays {
     
     Scanner entrada = new Scanner(System.in);

  
String [] alumnos1 = {"Luis", "Fernando", "Juan", "Maria", "Fernanda","Martha","Luisa","Pepe","castillo"};
int [] calificacionesporsemestre ={90,70,75,70,95,99,85,70,80};
int [] semestre ={1,2,3,4,5,6,7,8};
        int [] []  arr =  new  int [ 8 ]  [];

        


             

    public void simulacion(){
        
        

        for(int i=0; i<arr.length;i++){
            for(int j=0;j<semestre.length;j++){
                            for(int k=0;k<calificacionesporsemestre.length;k++){

       
                                int posicion = (int)(Math.random() * alumnos1.length);
                                int posicion1 = (int)(Math.random()*semestre.length);
                              int posicion2 = (int)(Math.random()*calificacionesporsemestre.length);

            
                System.out.println("\n--------\n"+"Alumno: "+alumnos1[posicion]+" \nSemestre:  "+semestre[posicion1]+"\nCalificacion: "+calificacionesporsemestre[posicion2]);
                
                     }

                 }
        }
    
    }
   public static void main(String []args){
       
       PVT10_10_09_Jagged_Arrays  instanciaClasePrincipal= new PVT10_10_09_Jagged_Arrays();
       
       instanciaClasePrincipal.simulacion();
       
   }
    
}
