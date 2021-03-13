using ExamenIngresoGlobalCitizen.ParteB;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenIngresoGlobalCitizen.ParteC
{
    class Camisa : Prendas
    {

        private String tipo_manga;
        private bool cuello_mao;

        public Camisa(string tipo_manga, bool cuello_mao, int cantidadUnidades, string calidadPrenda, double precioPrenda)
        {
            Tipo_manga = tipo_manga;
            Cuello_mao = cuello_mao;
            CantidadUnidades = cantidadUnidades;
            CalidadPrenda = calidadPrenda;
            PrecioPrenda = precioPrenda;
        }

        public string Tipo_manga { get => tipo_manga; set => tipo_manga = value; }
        public bool Cuello_mao { get => cuello_mao; set => cuello_mao = value; }
    }
}
