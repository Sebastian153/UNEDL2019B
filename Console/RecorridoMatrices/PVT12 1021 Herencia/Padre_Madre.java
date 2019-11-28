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

public class Padre_Madre {
    private final String colorOjos;
    private final String tipoCabello;
    private final String colorCabello;
    private final String colorPiel;
    private final float altura;
    
    public Padre_Madre(String colorOjos, String tipoCabello, String colorCabello, String colorPiel, float altura){
        this.colorOjos = colorOjos;
        this.tipoCabello = tipoCabello;
        this.colorCabello = colorCabello;
        this.colorPiel = colorPiel;
        this.altura = altura;
        
    }

    public String getColorOjos() {
        return colorOjos;
    }

    public String getTipoCabello() {
        return tipoCabello;
    }

    public String getColorCabello() {
        return colorCabello;
    }

    public String getColorPiel() {
        return colorPiel;
    }

    public float getAltura() {
        return altura;
    }
    
    //Metodos
    protected void Caracter(){
        System.out.println("- Caracter fuerte");
    }
    
    protected void Boca(){
        System.out.println("- Boca del padre ");
    }
    
    protected void Dientes(){
        System.out.println("- Sonrie mucho");
    }
}