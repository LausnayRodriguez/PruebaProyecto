package poo;

public class Coche {

    private int ruedas;
    private int largo;
    private int ancho;
    private int motor;
    private int peso;
    String color;
    int pesoTotal;
    boolean asientosCuero, climatizador;

    public Coche() {

        ruedas = 4;
        largo = 300;
        ancho = 200;
        motor = 1600;
        peso = 500;

    }

    public String getLargo() {
        return "El largo del Coche es " + largo + " Cms";
    }

    public void setLargo(int largo) {
        this.largo = largo;
    }

    public void setColor(String color) {
        this.color = color;
    }

    public String getColor() {
        return color;
    }

}
