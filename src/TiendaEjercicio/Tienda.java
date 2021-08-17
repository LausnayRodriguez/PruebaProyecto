package TiendaEjercicio;


import TiendaEjercicio.Carreras;
import java.util.ArrayList;
import java.util.Scanner;


public class Tienda {

    public static void main(String[] args) {
        Scanner sc=new Scanner(System.in);
        
        ArrayList<Carreras> listaCarreras=new ArrayList<Carreras>();
        
        String[] lista=new String[6];
        
        boolean salir=false;
        
        while(!salir){
            System.out.println("Opción 1: Agregar Bicicleta");
            System.out.println("Opción 2: Listar Stock");
            System.out.println("Opción 1: Salir");
            
            int opcion = Integer.parseInt(sc.nextLine());
            
            switch(opcion){
                case 1:
                 
                    
                case 2:
                    
                    
                case 3:
                    break;
            }
        }
    }
    
}
