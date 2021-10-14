using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sistema.Models
{
    public class Responsables
    {
        public int claveResponsable { get; set; }
        public String CURP { get; set; }
        public String nombre { get; set; }
        public String apellidoPaterno { get; set; }
        public String apellidoMaterno { get; set; }
        public String cargo { get; set; }
        public int telefono { get; set; }
        public String correo { get; set; }
        public String tipoResponsable { get; set; }
    }
}