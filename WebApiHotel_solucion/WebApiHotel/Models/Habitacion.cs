using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using WebApiHotel.Models;

namespace WebApiHotel.Data
{
    public partial class Habitacion
    {
        [Key]
        public int Codigo { get; set; }
        public string Detalle { get; set; }
        public string Numero { get; set; }
        public double Precio { get; set; }
        public Tipo Tipo { get; set; }
        public Estado Estado { get; set; }
    }
}
