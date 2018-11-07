using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiHotel.Models
{
    public class Tipo
    {
        public int Id { get; set; }
        public string TipoHabitacion { get; set; }
        public int HabitacionId { get; set; }
    }
}
