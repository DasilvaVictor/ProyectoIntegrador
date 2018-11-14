using System;
using System.Collections.Generic;

namespace WebApiHotel.Models
{
    public partial class EstadoHabitaciones
    {
        public int Id { get; set; }
        public string EstadoHabitacion { get; set; }
        public int HabitacionId { get; set; }
        public Habitaciones Habitacion { get; set; }
    }
}
