using ExamenIngresoGlobalCitizen.ParteA;
using ExamenIngresoGlobalCitizen.ParteB;
using System;

namespace ExamenIngresoGlobalCitizen
{
    class Program
    {
        static void Main(string[] args)
        {
            TiendaRopa tiendaRopa = new TiendaRopa();
            Vendedor vendedor = new Vendedor();
            

            while (true)
            {
                Console.WriteLine("---------------------------------------\n"+
                    "*******Cotizador Express*********");
                Console.WriteLine("Tienda: "+(tiendaRopa.Nombre != null ? tiendaRopa.Nombre : "") +
                          "\t\tDirección: " + (tiendaRopa.Direccion != null ? tiendaRopa.Direccion:"") 
                          + "\n---------------------------------------\n");

                Console.WriteLine("Nombre: " + (vendedor.Nombre ?? "") +
                                  "\nApellido: " + (vendedor.Apellido ?? "") + 
                                  "\nCódigo Vendedor: " + (vendedor.CodigoVendedor.ToString() ?? "") +
                                  "\n---------------------------------------\n");


                
                

                if (tiendaRopa.Nombre == null || vendedor.Nombre == null)
                {
                    Console.WriteLine("1) Datos de la Tienda \n" +
                                  "2) Datos del Vendedor \n" +
                                  "3) Salir"
                    );
                    int respuesta = int.Parse(Console.ReadLine());
                    switch (respuesta)
                    {
                        case 1:
                            tiendaRopa.InicialiarDatosTienda();
                            break;

                        case 2:
                            vendedor.InicializarDatos();
                            break;

                        case 3:
                            Environment.Exit(1);
                            break;

                        default:
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("1) Datos de la Tienda \n" +
                                  "2) Datos del Vendedor \n" +
                                  "3) Crear Cotizacion \n" +
                                  "4) Historial Cotizaciones \n" +
                                  "5) Salir"
                    );
                    int respuesta = int.Parse(Console.ReadLine());
                    switch (respuesta)
                    {
                        case 1:
                            tiendaRopa.InicialiarDatosTienda();
                            break;

                        case 2:
                            vendedor.InicializarDatos();
                            break;

                        case 3:
                            vendedor.CrearCotizacion();
                            break;

                        case 4:
                            if (vendedor.HistorialCotizaciones != null)
                                vendedor.MostrarHistorial();
                            else
                                Console.WriteLine("No hay historial para mostrar...");
                            break;

                        case 5:
                            Environment.Exit(1);
                            break;

                        default:
                            break;
                    }
                }
            }



            
        }
    }
}
