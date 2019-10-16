
import java.util.Arrays;
import java.util.Scanner;

//SIMULACION DE MATRICES.-
/*El usuario ingresara el tamaño de la matriz, asi mismo los diagonales de la matriz deberan de onbtener el valor absoluto y luego restar ambas giagonales, en caso de obtener menor que 0 multiplicarlo por -1 */
public class PVT1_02_09_Matriz_Absoluta {
     Scanner entrada = new Scanner(System.in);
        
        
	private int matriz[];
        
	private int filas;
	
	private int columnas;
        
	 private int matrizUno[][]=new int[filas][columnas];
         
	private int matrizResultante [][] = new  int[filas][columnas];
        
                    private int sumaDiagonal =0;
                    private int sumaDiagonal2 =0;
                    private int sumaTotalDiagonales=0;

                    
        
    public void simulacion(){
        
	entrada = new Scanner(System.in);
	
		 System.out.println(" ::::::::MATRIZ :::::::: ");

		System.out.println("Ingresa la cantidad de n filas de tu matriz: ");
		
		filas=entrada.nextInt();
		
		System.out.println("Ingresa la cantidad de n columnas de tu matriz: ");

			columnas = entrada.nextInt();
			
			matrizUno=new int [filas][columnas];
			
		 matrizResultante  = new int[filas][columnas];

		for (int i=0;i<matrizUno.length;i++)
		{
			
			
			for (int j=0;j<matrizUno.length;j++) 
			{
				
				System.out.println("Ingresa el elemanto de la fila "+(i+1)+" y la columna "+(j+1)+" de tu matriz : ");

				
				matrizUno [i][j] = entrada.nextInt();
				
				
			
			}
			
		
		}
  
		

    }
    
    public void imprimirSimulacion(){
        
        System.out.print("\nLa matriz que usted ingreso es:");
		for(int i=0;i<filas;i++) 
		{
			
			   System.out.println("");

			   for (int j=0;j<columnas;j++)
			   {
				
				   System.out.print(matrizUno[i][j]+" ");
                                   
                                   
			}
		}
//SUMA DIAGONALES
               for(int i=0;i<matrizUno.length;i++) { 
                   
                
                       
                sumaDiagonal += matrizUno[i][i]; 
} 
                  for (int i=0;i<matrizUno.length;i++){
                                   sumaDiagonal2 += matrizUno [ i ][ filas - i - 1 ] ;

               }
                  
               System.out.println("\nLa suma de la diagonal uno es: "+sumaDiagonal);
               
                   System.out.println("\nLa suma de la diagonal dos es: "+sumaDiagonal2);
                   
                   sumaTotalDiagonales = sumaTotalDiagonales + sumaDiagonal -sumaDiagonal2;
                   
                   
                       if(sumaTotalDiagonales<-1){
                           sumaTotalDiagonales = (sumaTotalDiagonales)*(-1);
                           
                   System.out.println("La suma de las diagonales es de: "+sumaDiagonal+" + "+sumaDiagonal2+" ="+sumaTotalDiagonales);
                       }
                       else {
                                              System.out.println("La suma de las diagonales es de: "+sumaDiagonal+" + "+sumaDiagonal2+" = "+sumaTotalDiagonales);

                       }
                   

                   
    }
    
   public static void main(String []args){
       
       PVT1_02_09_Matriz_Absoluta  instanciaClasePrincipal= new PVT1_02_09_Matriz_Absoluta();
       
       instanciaClasePrincipal.simulacion();
       instanciaClasePrincipal.imprimirSimulacion();
       
   }
    
}
