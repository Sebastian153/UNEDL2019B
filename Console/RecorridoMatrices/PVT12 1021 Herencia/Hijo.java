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
public class Hijo extends Padre_Madre{
    private String OrejasMedianas;
    private String Dedosbelludos;
    
    public Hijo(String tipoCabello, String colorOjos,  String colorCabello, String colorPiel, float altura, String orejasMedianas, String dedosbelludos){
        //Con super le decimos a java cuales de los atributos está heredando de la clase padre.
        //Esto sirva para ya no inicializarlas de nuevo
        super(colorOjos,tipoCabello,colorCabello,colorPiel,altura);
        
        this.OrejasMedianas = orejasMedianas;
        this.Dedosbelludos = dedosbelludos;
    }
    
    public void HerenciaMostrar(){
        System.out.println("Los atributos que heheredado de mis padres");
        System.out.println("- TIPO DE CABELLO: "+getTipoCabello()+
                           "\n- COLOR OJOS: "+getColorOjos()+
                            "\n- COLOR CABELLO: "+getColorCabello()+
                           "\n- PIEL: "+getColorPiel()+
                           
                           "\n- Altura: "+getAltura());
        
        System.out.println("\nMi propio atributo hijo: ");
        
        System.out.println("- Orejas medianas "+OrejasMedianas+
                           "\n- Manos con pelo XD: "+Dedosbelludos);
        
    }
    
    
    
}