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
        public String claveUniversidad { get; set; }
        public String password { get; set; }
        public String nombre { get; set; }
        public String colonia { get; set; }
        public String localidad { get; set; }
        public String Direccion { get; set; }
        public int CP { get; set; }
        public String municipio { get; set; }

    }
}