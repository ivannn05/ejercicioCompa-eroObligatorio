using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ejercicioDeCompanyeroObligatorio.Dtos;


namespace ejercicioDeCompanyeroObligatorio.servicios
{
    /// <summary>
    /// Implementacion que contendra la logica de los metodos de los pacientes
    /// <author>ilp-310124</author>
    /// </summary>
    internal class operativaImplementacion : operativaInterfaz
    {
        public void anyadirNuevoCliente(List<clienteDtos> listaAntigua)
        {
            clienteDtos cliente = crearNuevoCliente();

            listaAntigua.Add(cliente);
        }
        /// <summary>
        /// Metodo complementario para añadir nuevo cliente y pedir los datos del cliente 
        /// <author>ilp-310124</author>
        /// </summary>
        /// <returns></returns>
        private clienteDtos crearNuevoCliente()
        {
            clienteDtos nuevoCliente = new clienteDtos();

            Console.WriteLine("Introduzca su id ");
            nuevoCliente.Id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduzca su dni");
            nuevoCliente.Dni = Console.ReadLine();

            Console.WriteLine("Introduzca su nombre");
            nuevoCliente.Nombre = Console.ReadLine();

            Console.WriteLine("Introduzca su apellidos  ");
            nuevoCliente.Apellidos = Console.ReadLine();

            Console.WriteLine("Introduzca su edad ");
            nuevoCliente.Edad = Convert.ToInt32(Console.ReadLine());

            DateTime fechaHoyPropiedad = DateTime.Now;
            string formattedDateTime = fechaHoyPropiedad.ToString("yy-MM-ddTHH:mm:ss.fff");
            nuevoCliente.Horadelingreso = formattedDateTime.ToString();


          /*  nuevoCliente.Horadelingreso = fechaHoyPropiedad.ToString("yy - MM - ddThh:mm: ss.ms");
            "yy'-'MM'-'dd'T'hh':'mm':'ss"*/

            Console.WriteLine("Nuevo cliente registrado  ");
            return nuevoCliente;
        }


        public void eliminarCliente(List<clienteDtos> listaClientes)
        {
            menuInterfaz mi = new menuImplementacion();

            string dniBuscar = mi.pedirDni();
            //Objeto especifico:Se elimina por refencia de valores , no por valores 
            clienteDtos clienteABorrar = new clienteDtos();
            foreach (clienteDtos cliente in listaClientes)
            {
                if (cliente.Dni.Equals(dniBuscar))
                {
                    clienteABorrar = cliente;
                    break;
                }
            }
            listaClientes.Remove(clienteABorrar);


           
        }

        public void mostrarClientes(List<clienteDtos> listaClientes)
        {
            foreach(clienteDtos cliente in listaClientes)
            { 
                Console.WriteLine(cliente.ToString());
            }

           
        }
    } 
}   

