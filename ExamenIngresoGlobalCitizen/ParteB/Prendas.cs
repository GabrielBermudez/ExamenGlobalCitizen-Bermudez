using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenIngresoGlobalCitizen.ParteB
{
    class Prendas
    {

        private string calidadPrenda;
        private double precioPrenda;
        private int cantidadUnidades;

        public string CalidadPrenda { get => calidadPrenda; set => calidadPrenda = value; }
        public double PrecioPrenda { get => precioPrenda; set => precioPrenda = value; }
        public int CantidadUnidades { get => cantidadUnidades; set => cantidadUnidades = value; }
    }
}
