using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorFlotasTransporte.Models
{
    public class Vehiculo
    {
        public string Matricula { get; set; }
        public string Tipo { get; set; }
        public int Capacidad { get; set; }
        public string Estado { get; set; } // Disponible, En uso, En mantenimiento
        public int Kilometraje { get; set; }

        public Vehiculo(string matricula, string tipo, int capacidad, string estado, int kilometraje)
        {
            Matricula = matricula;
            Tipo = tipo;
            Capacidad = capacidad;
            Estado = estado;
            Kilometraje = kilometraje;
        }
    }
}