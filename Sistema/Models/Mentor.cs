using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sistema.Models
{
    public class Mentor
    {
        public String CURP_mentor { get; set; }
        public String tipoMentor { get; set; }
        public String nombre { get; set; }
        public String apellidoPaterno { get; set; }
        public String apellidoMaterno { get; set; }
        public String cargo { get; set; }
        public int telefono { get; set; }
        public String correo { get; set; }
    }
}