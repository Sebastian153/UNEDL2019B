/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Herencia;

/**
 *
 * @author super
 */
public class Menu_Principal {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args)
    {
        Hijo SebitasXD = new Hijo("Cafés","Delgado","Claro","Cabello_Delgado", (float) 1.70,"Sí","Sí");
        SebitasXD.HerenciaMostrar(); //Llamamos los atributos que heredamos en el metodo de la clase hijo
        
        //Llamamos con nuestro objeto los metodos que tenga nuestra clase padre, ya que los hemos heredado directamente
        System.out.println("\nLa herencia que me han dado  ");
        SebitasXD.Caracter();
        SebitasXD.Boca();
        SebitasXD.Dientes();
        
        //Llamamos con nuestro objeto los metodos que he aprendido de otras personas
        
        
    }
}