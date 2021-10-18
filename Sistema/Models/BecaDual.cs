using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sistema.Models
{
    public class BecaDual
    {
        [Key]
        public int ClaveBecaDual { get; set; }
        public String Fuente { get; set; }
        public String Duracion { get; set; }
        public String Periodicidad { get; set; }
        public String TipoBeca { get; set; }

    }
}