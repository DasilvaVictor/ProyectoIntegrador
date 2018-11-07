using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiHotel.Models
{
    public class Estado
    {
        public int Id { get; set; }
        public string EstadoHabitacion { get; set; }
        public int HabitacionId { get; set; }
    }
}
