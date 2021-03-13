# ExamenGlobalCitizen-Bermudez

1- Por favor, especifica tu nombre completo: Gabriel Maximiliano Bermudez

2- �C# permite herencia m�ltiple?
	C# no permite la herencia m�ltiple.

3- �Cu�ndo utilizar�a una Clase Abstracta en lugar de una Interfaz? Ejemplifique.
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

4- �Qu� implica una relaci�n de Generalizaci�n entre dos clases?
	Implica que entre ellas habra un relacion de padre e hija, 	es decir la superclase o clase padre se considera como 	generalizacion de la subclase o clase hija

5- �Qu� implica una relaci�n de Implementaci�n entre una clase y una interfaz? 
	Implica un contrato de lo que la clase que la implementa 	debe hacer

6- �Qu� diferencia hay entre la relaci�n de Composici�n y la Agregaci�n?
	La diferencia que hay entre la agregaci�n y la composici�n 	es que la agregacion indica que una clase es parte de otra
	en la que puede existir independientemente. En cambio en 	la composicion, la vida de la clase contenida esta 	estrictamente relacionada con la vida de la clase 	contenedor, si una se destruyera la otra no podria 	funcionar independientemente
	
7- Indique V o F seg�n corresponda. Diferencia entre Asociaci�n y Agregaci�n:

a- Una diferencia es que la segunda indica la relaci�n entre un �todo� y sus �partes�, mientras que en la primera los objetos est�n al mismo nivel contextual. V

b- Una diferencia es que la Agregaci�n es de cardinalidad 1 a muchos mientras que la Asociaci�n es de 1 a 1. V

c- Una diferencia es que, en la Agregaci�n, la vida o existencia de los objetos relacionados est� fuertemente ligada, es decir que si �muere� el objeto contenedor tambi�n morir�n las �partes�, en cambio en la Asociaci�n los objetos viven y existen independientemente de la relaci�n. F