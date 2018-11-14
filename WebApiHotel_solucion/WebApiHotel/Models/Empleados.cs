using System;
using System.Collections.Generic;

namespace WebApiHotel.Models
{
    public partial class Empleados
    {
        public int Id { get; set; }
        public string Apellido { get; set; }
        public int Dni { get; set; }
        public string Direccion { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Nombre { get; set; }
        public int Telefono { get; set; }
      
    }
}
