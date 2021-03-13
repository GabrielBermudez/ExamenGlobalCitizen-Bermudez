using ExamenIngresoGlobalCitizen.ParteC;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenIngresoGlobalCitizen.ParteB
{
    class TiendaRopa
    {
        private String nombre, direccion;
        List<Pantalon> listaPantalones = new List<Pantalon>();
        List<Camisa> listaCamisas = new List<Camisa>();

        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        internal List<Pantalon> ListaPantalones { get => listaPantalones; set => listaPantalones = value; }
        internal List<Camisa> ListaCamisas { get => listaCamisas; set => listaCamisas = value; }

        public void InicialiarDatosTienda()
        {
            Console.Write("Ingrese el nombre de la tienda: ");
            Nombre = Console.ReadLine();

            Console.Write("Ingrese la dirección de la tienda: ");
            Direccion = Console.ReadLine();

        }
    }

}
