using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApiHotel.Models
{
    public partial class Habitaciones
    {
        [Key]
        public int Codigo { get; set; }
        public string Detalle { get; set; }
        public string Numero { get; set; }
        public double Precio { get; set; }

        public EstadoHabitaciones EstadoHabitaciones { get; set; }
        public TipoHabitaciones TipoHabitaciones { get; set; }
    }
}
