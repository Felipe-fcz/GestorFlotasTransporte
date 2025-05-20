using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorFlotasTransporte.Models
{
    public class Conductor
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Licencia { get; set; }
        public bool Disponible { get; set; }

        public Conductor(string id, string nombre, string licencia, bool disponible)
        {
            Id = id;
            Nombre = nombre;
            Licencia = licencia;
            Disponible = disponible;
        }
    }
}