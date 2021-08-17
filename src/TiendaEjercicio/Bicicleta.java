package TiendaEjercicio;


public class Bicicleta {
    int rin;
    int nvel;
    String marca;
    
    public Bicicleta(int rin, int nvel, String marca){
        this.rin=rin;
        this.nvel=nvel;
        this.marca=marca;
    }

    @Override
    public String toString() {
        return "Bicicleta{" + "rin=" + rin + ", nvel=" + nvel + ", marca=" + marca + '}';
    }
    
    
}
