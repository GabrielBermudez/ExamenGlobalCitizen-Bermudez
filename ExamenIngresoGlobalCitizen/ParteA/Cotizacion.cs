using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenIngresoGlobalCitizen.ParteA
{
    class Cotizacion
    {
        private long nroIdentificacion;
        private string fechaHora;
        private long vendedor_codigoVendedor;
        private String prendaCotizada;
        private double precioPrenda;
        private int cantidad;
        private double resultadoCotizacion;

        public long NroIdentificacion { get => nroIdentificacion; set => nroIdentificacion = value; }
        public string FechaHora { get => fechaHora; set => fechaHora = value; }
        public long Vendedor_codigoVendedor { get => vendedor_codigoVendedor; set => vendedor_codigoVendedor = value; }
        public string PrendaCotizada { get => prendaCotizada; set => prendaCotizada = value; }
        public double PrecioPrenda { get => precioPrenda; set => precioPrenda = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public double ResultadoCotizacion { get => resultadoCotizacion; set => resultadoCotizacion = value; }


    }
}
