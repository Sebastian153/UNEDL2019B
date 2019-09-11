/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author Sebastian Rivera
 */
public class RecorridoMatriz {
    private int filas;
    private int columnas;
    private int matriz [][]= {{1,3,5,7},{4,7,9,7},{2,6,8,0},{2,4,5,2}};
    private int mtrizResultante [][] = new int [filas][columnas];
    
    public void simulacion(){
        
        System.out.print("\nLa matriz que usted ingreso es:");
		//control cÃ­clico, se ejecutara un numero de veces en el que se le indico y aumentara de 1 en 1
		for(int i=0;i<matriz.length;i++) 
		//abres llaves para for (int i=0;i<filas;i++) 
		{
			
			//impresion para salto
			   System.out.println("");

				//control cÃ­clico, se ejecutara un numero de veces en el que se le indico y aumentara de 1 en 1
			   for (int j=0;j<matriz.length;j++)
			   //abres llaves para for (int j=0;j<columnas;j++)
			   {
				
				   //impresion de pantalla
				   System.out.print(matriz[i][j]+" ");
                                   
                                   
			//cierras llaves para for (int j=0;j<columnas;j++)
			}
		//cierras llaves para for (int i=0;i<filas;i++) 	
		}
        
    }
    public void impresion(){
        
    }
    public static void main (String []args){
        RecorridoMatriz intanciaClasePrincipal = new RecorridoMatriz();
         intanciaClasePrincipal.simulacion();
         intanciaClasePrincipal.impresion();
    }
    
}
