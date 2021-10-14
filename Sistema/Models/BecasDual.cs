using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sistema.Models
{
    public class BecasDual
    {
        [Key]
        public int claveBecaDual { get; set; }
        public String fuente { get; set; }
        public String duracion { get; set; }
        public String periodicidad { get; set; }
        public String tipoBeca { get; set; }

    }
}