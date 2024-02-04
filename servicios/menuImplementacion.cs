using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioDeCompanyeroObligatorio.servicios
{
    /// <summary>
    /// Implementacion la cual llevara toda la logica para  menus de la app
    /// <author>ilp-310124</author>
    /// </summary>
    internal class menuImplementacion : menuInterfaz
    {
        public int mostrarMenuYSelecion()
        {
            int opcion;
            Console.WriteLine("Selecciones una opcion");
            Console.WriteLine("0.Cerra menu");
            Console.WriteLine("1.Agregar nuevo paciente");
            Console.WriteLine("2.Borrar paciente(que se borre a través del dni)");
            Console.WriteLine("3.Mostrar paciente");
            opcion=Convert.ToInt32(Console.ReadLine());
            return opcion;
        }

        public string pedirDni()
        {
            Console.WriteLine("Introduzca su Dni");
            string dni=Console.ReadLine();
            return dni;
        }
    }
}
