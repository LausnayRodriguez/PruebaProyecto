package TiendaEjercicio;


import TiendaEjercicio.Bicicleta;


public class Carreras extends Bicicleta {

    int peso;

    public Carreras(int rin, int nvel, String marca, int peso) {
        super(rin, nvel, marca);
        this.peso = peso;
    }

    @Override
    public String toString() {
        return super.toString() + peso;
    }

}
