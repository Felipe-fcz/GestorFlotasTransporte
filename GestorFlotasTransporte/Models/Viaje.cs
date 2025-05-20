using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorFlotasTransporte.Models
{
    public class Viaje
    {
        public int Id { get; set; }
        public string MatriculaVehiculo { get; set; }
        public string IdConductor { get; set; }
        public string Ruta { get; set; }
        public DateTime FechaHoraSalida { get; set; }
        public DateTime FechaHoraLlegada { get; set; }
        public string Estado { get; set; } // Programado, En curso, Completado, Cancelado

        public Viaje(int id, string matriculaVehiculo, string idConductor, string ruta,
                    DateTime fechaHoraSalida, DateTime fechaHoraLlegada, string estado)
        {
            Id = id;
            MatriculaVehiculo = matriculaVehiculo;
            IdConductor = idConductor;
            Ruta = ruta;
            FechaHoraSalida = fechaHoraSalida;
            FechaHoraLlegada = fechaHoraLlegada;
            Estado = estado;
        }
    }
}
