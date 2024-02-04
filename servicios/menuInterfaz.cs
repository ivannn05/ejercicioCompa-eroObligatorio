using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioDeCompanyeroObligatorio.servicios
{
    /// <summary>
    /// Interfaz que contendra los metodos para el funcionamiento del menu
    /// <author>ilp-310124</author>
    /// </summary>
    internal interface menuInterfaz
    {
        /// <summary>
        /// Metodo que muestra el menu principal
        /// <author>ilp-310124</author>
        /// </summary>
        /// <returns></returns>
        public int mostrarMenuYSelecion();

        /// <summary>
        /// Metodo que pide el dni 
        /// <author>ilp-310124</author>
        /// </summary>
        /// <returns></returns>
        public string pedirDni();
    }
}
