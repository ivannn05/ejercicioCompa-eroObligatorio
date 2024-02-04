using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ejercicioDeCompanyeroObligatorio.Dtos;

namespace ejercicioDeCompanyeroObligatorio.servicios
{
    /// <summary>
    /// Interfaz que contendra los metodos para el funcionamiento de los clientes
    /// <author>ilp-310124</author>
    /// </summary>
    internal interface operativaInterfaz
    {
        /// <summary>
        /// Metodo para añadir nuevo cliente 
        /// <author>ilp-310124</author>
        /// </summary>
        public void anyadirNuevoCliente(List<clienteDtos> listaAntigua);
        /// <summary>
        /// Metodo para eliminar cliente 
        /// <author>ilp-310124</author>
        /// </summary>
        public void eliminarCliente(List<clienteDtos> listaClientes);
        /// <summary>
        /// Metodo para mostrar los clientes
        /// <author>ilp-310124</author>
        /// </summary>
        public void mostrarClientes(List<clienteDtos> listaClientes);
    }
}
