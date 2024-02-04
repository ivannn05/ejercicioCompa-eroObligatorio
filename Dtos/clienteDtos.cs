using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioDeCompanyeroObligatorio.Dtos
{
    /// <summary>
    /// Clase Dtos la cual llevara todos los atributos de los clientes con su informacion
    /// <author>ilp-310124</author>
    /// </summary>
    internal class clienteDtos
    {
        //Atributos
       long id;
       string dni;
       string nombre;
       string apellidos;
       string nombreCompleto;
       int edad;
       DateTime horaDelIngreso;

        //Constructores 
        public clienteDtos(long id, string dni, string nombre, string apellidos, string nombreCompleto, int edad, DateTime horaDelIngreso)
        {
            this.id = id;
            this.dni = dni;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.nombreCompleto = nombre + apellidos;
            this.edad = edad;
            this.horaDelIngreso = horaDelIngreso;
        }

        public clienteDtos()
        {
        }

        //Getters y Setters
        public long Id { get => id; set => id = value; }
        public string Dni { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string NombreCompleto { get => nombreCompleto; set => nombreCompleto = value; }
        public int Edad { get => edad; set => edad = value; }
        public DateTime Horadelingreso { get => horaDelIngreso; set => horaDelIngreso = value; }

        public string ToString()
        {
            string datos = "Nombre de paciente=" + "" + this.nombreCompleto; 
               

            return datos;
        }

    }
}
