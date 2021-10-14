using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sistema.Models
{
    public class UnidadesEconomicas
    {
        [Key]
        public String RFC { get; set; }
        public String nombreComercial { get; set; }
        public String cargo { get; set; }
        public String razonSocial { get; set; }
        public String colonia { get; set; }
        public String sector { get; set; }
        public String localidad { get; set; }
        public String programaEducativo { get; set; }
        public int CP { get; set; }
        public String telefono { get; set; }
        public String municipio { get; set; }
        public String representanteLegal { get; set; }
    }
}