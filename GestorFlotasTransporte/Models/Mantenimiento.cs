using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorFlotasTransporte.Models
{
    public class Mantenimiento
    {
        public int Id { get; set; }
        public string MatriculaVehiculo { get; set; }
        public string Tipo { get; set; } // Preventivo, Correctivo
        public DateTime FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public string Descripcion { get; set; }

        public Mantenimiento(int id, string matriculaVehiculo, string tipo,
                            DateTime fechaInicio, DateTime? fechaFin, string descripcion)
        {
            Id = id;
            MatriculaVehiculo = matriculaVehiculo;
            Tipo = tipo;
            FechaInicio = fechaInicio;
            FechaFin = fechaFin;
            Descripcion = descripcion;
        }
    }
}