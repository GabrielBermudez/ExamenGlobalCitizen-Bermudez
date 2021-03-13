# ExamenGlobalCitizen-Bermudez

1- Por favor, especifica tu nombre completo: Gabriel Maximiliano Bermudez

2- ¿C# permite herencia múltiple?
	C# no permite la herencia múltiple.

3- ¿Cuándo utilizaría una Clase Abstracta en lugar de una Interfaz? Ejemplifique.
	Utilizaria una clase abstracta cuando al menos uno de sus 	metodos deba estar si o si implementado.

public abstract class Automovil  {
	private int puertas;

   	public Automovil  (int puertas) {
     		this.puertas= puertas;
   	}
  	public int getPuertas(){
     		return this.puertas;
  	}

   public abstract void getNombre();
}

public class Auto extends Automovil  {

   public Auto(){
      super(4); //4 puertas
   }

   @Override 
   public String getNombre(){
     return "Ford";
   }
}

4- ¿Qué implica una relación de Generalización entre dos clases?
	Implica que entre ellas habra un relacion de padre e hija, 	es decir la superclase o clase padre se considera como 	generalizacion de la subclase o clase hija

5- ¿Qué implica una relación de Implementación entre una clase y una interfaz? 
	Implica un contrato de lo que la clase que la implementa 	debe hacer

6- ¿Qué diferencia hay entre la relación de Composición y la Agregación?
	La diferencia que hay entre la agregación y la composición 	es que la agregacion indica que una clase es parte de otra
	en la que puede existir independientemente. En cambio en 	la composicion, la vida de la clase contenida esta 	estrictamente relacionada con la vida de la clase 	contenedor, si una se destruyera la otra no podria 	funcionar independientemente
	
7- Indique V o F según corresponda. Diferencia entre Asociación y Agregación:

a- Una diferencia es que la segunda indica la relación entre un “todo” y sus “partes”, mientras que en la primera los objetos están al mismo nivel contextual. V

b- Una diferencia es que la Agregación es de cardinalidad 1 a muchos mientras que la Asociación es de 1 a 1. V

c- Una diferencia es que, en la Agregación, la vida o existencia de los objetos relacionados está fuertemente ligada, es decir que si “muere” el objeto contenedor también morirán las “partes”, en cambio en la Asociación los objetos viven y existen independientemente de la relación. F