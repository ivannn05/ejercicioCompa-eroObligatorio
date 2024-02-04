using ejercicioDeCompanyeroObligatorio.Dtos;
using ejercicioDeCompanyeroObligatorio.servicios;
using System.ComponentModel;

namespace ejercicioDeCompanyeroObligatorio.controladores
{
    class Program
    {
        /// <summary>
        /// Metodo principal de la aplicacion , por la cual se lanzara la app
        /// <author>ilp-310124</author>
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            List<clienteDtos> cliente= new List<clienteDtos>();
            int opcion;
            bool cerrarMenu=false;
            menuInterfaz mi = new menuImplementacion();
            operativaInterfaz op = new operativaImplementacion();

            while(!cerrarMenu)
            {
                opcion=mi.mostrarMenuYSelecion();
                Console.WriteLine(opcion);
                switch(opcion)
                {
                    case 0:
                        cerrarMenu = true;
                        break;
                    case 1:
                        op.anyadirNuevoCliente(cliente);
                        break;
                    case 2:
                        op.eliminarCliente(cliente);
                        break;
                    case 3:
                        op.mostrarClientes(cliente);
                        break;

                }
            }
        }
    }
}
