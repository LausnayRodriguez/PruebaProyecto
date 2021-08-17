package TiendaEjercicio;


import TiendaEjercicio.Bicicleta;


public class Bicicross extends Bicicleta{
    String material;
    
    public Bicicross(int rin, int nvel, String marca, String material){
        super(rin, nvel, marca);
        this.material=material;
        
    
    }

    @Override
    public String toString() {
        return super.toString() + material;
    }
}
