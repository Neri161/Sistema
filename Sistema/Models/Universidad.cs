using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sistema.Models
{
    public class Universidad
    {
        [Key]
        public String ClaveUniversidad { get; set; }
        public String Password { get; set; }
        public String Nombre { get; set; }
        public String Colonia { get; set; }
        public String Localidad { get; set; }
        public String Direccion { get; set; }
        public int CP { get; set; }
        public String Municipio { get; set; }

    }
}