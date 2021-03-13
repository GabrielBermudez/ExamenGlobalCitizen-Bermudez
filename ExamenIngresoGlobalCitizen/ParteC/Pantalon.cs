using ExamenIngresoGlobalCitizen.ParteB;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenIngresoGlobalCitizen.ParteC
{
    class Pantalon : Prendas
    {

        private String tipo_pantalon;

        public Pantalon(string tipo_pantalon, int cantidadUnidades, string calidadPrenda, double precioPrenda)
        {
            Tipo_pantalon = tipo_pantalon;
            CantidadUnidades = cantidadUnidades;
            CalidadPrenda = calidadPrenda;
            PrecioPrenda = precioPrenda;
        }

        public string Tipo_pantalon { get => tipo_pantalon; set => tipo_pantalon = value; }
    }
}

