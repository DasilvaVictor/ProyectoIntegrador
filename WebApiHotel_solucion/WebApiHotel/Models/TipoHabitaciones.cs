using System;
using System.Collections.Generic;

namespace WebApiHotel.Models
{
    public partial class TipoHabitaciones
    {
        public int Id { get; set; }
        public string TipoHabitacion { get; set; }
        public int HabitacionId { get; set; }

        public Habitaciones Habitacion { get; set; }
    }
}
