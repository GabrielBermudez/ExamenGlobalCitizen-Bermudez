using ExamenIngresoGlobalCitizen.ParteB;
using ExamenIngresoGlobalCitizen.ParteC;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenIngresoGlobalCitizen.ParteA
{
    class Vendedor
    {
        private String nombre;
        private String apellido;
        private String codigoVendedor;
        private List<Cotizacion> historialCotizaciones;
        private TiendaRopa tiendaDeRopa = new TiendaRopa();

        public Vendedor()
        {
            tiendaDeRopa.ListaCamisas.Add(new Camisa("Corta", true, 200,"Standar",200)); //manga corta cuello mao
            tiendaDeRopa.ListaCamisas.Add(new Camisa("Corta", false, 300, "Premium",300)); //manga corta cuello normal
            tiendaDeRopa.ListaCamisas.Add(new Camisa("Larga", true, 150, "Standar",500)); //manga larga cuello mao
            tiendaDeRopa.ListaCamisas.Add(new Camisa("Larga", false, 350, "Premium",700)); //manga larga cuello normal

            tiendaDeRopa.ListaPantalones.Add(new Pantalon("Chupin", 1500, "Premium",1800)); //chupin
            tiendaDeRopa.ListaPantalones.Add(new Pantalon("Normal", 500, "Standar",1300)); //normales

            HistorialCotizaciones = new List<Cotizacion>();

        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string CodigoVendedor { get => codigoVendedor; set => codigoVendedor = value; }
        internal List<Cotizacion> HistorialCotizaciones { get => historialCotizaciones; set => historialCotizaciones = value; }
        internal TiendaRopa TiendaDeRopa { get => tiendaDeRopa; set => tiendaDeRopa = value; }


    public void InicializarDatos()
        {
            int newValue;
            bool bandera = false;
            while (!bandera)
            {
                Console.Write("Por favor ingrese su nombre: ");
                Nombre = Console.ReadLine();

                Console.Write("Por favor ingrese su apellido: ");
                Apellido = Console.ReadLine();

                Console.Write("Por favor ingrese su codigo de vendedor: ");
                CodigoVendedor = Console.ReadLine();

                bandera = int.TryParse(CodigoVendedor, out newValue);
                if (!bandera)
                    Console.WriteLine("El codigo del vendedor debe ser un numero entero");
            }
            
            
        }

        public void CrearCotizacion()
        {
            Cotizacion cotizacion = new Cotizacion();

            cotizacion.NroIdentificacion = historialCotizaciones.Count+1;
            cotizacion.FechaHora = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            cotizacion.Vendedor_codigoVendedor = CodigoVendedor;

            Console.WriteLine("Seleccione el tipo de prenda que desea cotizar: \n" +
                "1) Pantalones\n" +
                "2) Camisas\n");
            int tipo_prenda = int.Parse(Console.ReadLine());

            switch (tipo_prenda)
            {
                case 1:
                    Pantalon pantalon = MostrarPantalones();
                    if(pantalon != null)
                        CotizacionPantalones(pantalon,cotizacion);
                    break;

                case 2:
                    Camisa camisa = MostrarCamisas();
                    if (camisa != null)
                        CotizacionCamisas(camisa, cotizacion);
                    break;

                default:
                    break;
            }

        }

        public void MostrarHistorial()
        {
            Console.WriteLine("Numero de Identificacion | \t Fecha-Hora\t |  Codigo del Vendedor  |  Prenda Cotizada |\t\t  Cantidad  | Resultado Cotización");

            foreach (var cotizacion in historialCotizaciones)
            {
                Console.WriteLine("         " + cotizacion.NroIdentificacion + "             |   "
                                + cotizacion.FechaHora + " |        "
                                + cotizacion.Vendedor_codigoVendedor + " |        "
                                + cotizacion.PrendaCotizada + "   |        "
                                + cotizacion.Cantidad + "   |  "
                                + "$" + cotizacion.ResultadoCotizacion);
            }
        }


        public Pantalon MostrarPantalones()
        {
            int aux = 0;
            string seleccion;
            int newValue;
            bool bandera;
            Console.WriteLine("Seleccione el pantalón que desea cotizar: \n" +
                "Tipo de Pantalon   |    Precio   |   Cantidad  |  Calidad");
            foreach (var pantalon in TiendaDeRopa.ListaPantalones)
            {
                Console.WriteLine((aux + 1) + ") " + pantalon.Tipo_pantalon + "\t\t " + pantalon.PrecioPrenda + "\t\t "
                                          + pantalon.CantidadUnidades + "\t " + pantalon.CalidadPrenda);
                aux++;
            }
            Console.WriteLine((aux + 1) + ") Salir");
            seleccion = Console.ReadLine();
            bandera = int.TryParse(seleccion, out newValue);
            if (bandera)
            {
                if (newValue == aux + 1)
                    return null;
                if (newValue <= 0 || newValue > aux + 1)
                {
                    MostrarPantalones();
                }
                else
                {
                    return TiendaDeRopa.ListaPantalones[newValue - 1];
                }

            }
            Console.WriteLine("Asegurese de ingresar numeros enteros...");
            return null;


        }

        public Camisa MostrarCamisas()
        {
            int aux = 0;
            string seleccion;
            int newValue;
            bool bandera;
            Console.WriteLine("Seleccione la camisa que desea cotizar: \n" +
                "Tipo de Camisa   |    Precio   |   Cantidad  |  Calidad | Cuello Mao");
            foreach (var camisa in TiendaDeRopa.ListaCamisas)
            {
                Console.WriteLine((aux + 1) + ") " + camisa.Tipo_manga + "\t\t " + camisa.PrecioPrenda + "\t\t"
                                          + camisa.CantidadUnidades + "\t\t " + camisa.CalidadPrenda + "\t " + (camisa.Cuello_mao?"Si":"No") );
                aux++;
            }
            Console.WriteLine((aux + 1) + ") Salir");
            seleccion = Console.ReadLine();
            bandera = int.TryParse(seleccion, out newValue);
            if (bandera)
            {
                if (newValue == aux + 1)
                    return null;
                if (newValue <= 0 || newValue > aux + 1)
                {
                    MostrarCamisas();
                }
                else
                {
                    return TiendaDeRopa.ListaCamisas[newValue - 1];
                }

            }
            Console.WriteLine("Asegurese de ingresar numeros enteros...");
            return null;
        }

        public void CotizacionPantalones(Pantalon pantalon, Cotizacion cotizacion)
        {
            bool flag = true;
            Console.Write("Ingrese la cantidad de unidades a cotizar: ");
            cotizacion.Cantidad = int.Parse(Console.ReadLine());

            foreach (Pantalon item in TiendaDeRopa.ListaPantalones)
            {
                if (item == pantalon)
                {
                    if (item.CantidadUnidades - cotizacion.Cantidad >= 0)
                        item.CantidadUnidades -= cotizacion.Cantidad;
                    else
                        flag = false;
                    break;
                }
            }
            cotizacion.PrendaCotizada = "Pantalon " + pantalon.Tipo_pantalon + " " +pantalon.CalidadPrenda;
            cotizacion.PrecioPrenda = pantalon.PrecioPrenda;

            cotizacion.ResultadoCotizacion = cotizacion.Cantidad * cotizacion.PrecioPrenda;
            if (flag)
                historialCotizaciones.Add(cotizacion);
            else
                Console.WriteLine("No se pudo generar la cotización por falta de stock");
        }


        public void CotizacionCamisas(Camisa camisa, Cotizacion cotizacion)
        {
            bool flag = true;
            Console.Write("Ingrese la cantidad de unidades a cotizar: ");
            cotizacion.Cantidad = int.Parse(Console.ReadLine());

            foreach (Camisa item in TiendaDeRopa.ListaCamisas)
            {
                if (item == camisa)
                {
                    if (item.CantidadUnidades - cotizacion.Cantidad >= 0)
                        item.CantidadUnidades -= cotizacion.Cantidad;
                    else
                        flag = false;
                    break;
                }
            }
            cotizacion.PrendaCotizada = "Camisa mangas " + camisa.Tipo_manga + " " + camisa.CalidadPrenda;
            cotizacion.PrecioPrenda = camisa.PrecioPrenda;

            cotizacion.ResultadoCotizacion = cotizacion.Cantidad * cotizacion.PrecioPrenda;

            if (flag)
                historialCotizaciones.Add(cotizacion);
            else
                Console.WriteLine("No se pudo generar la cotización por falta de stock");
        }
    }
}
