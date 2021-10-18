using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sistema.Models
{
    public class UnidadEconomica
    {
        [Key]
        public String RFC_UE { get; set; }
        public String NombreComercial { get; set; }
        public String Cargo { get; set; }
        public String RazonSocial { get; set; }
        public String Colonia { get; set; }
        public String Sector { get; set; }
        public String Localidad { get; set; }
        public String ProgramaEducativo { get; set; }
        public int CP { get; set; }
        public String Telefono { get; set; }
        public String Municipio { get; set; }
        public String RepresentanteLegal { get; set; }
        public int ClaveMentorEmpresarial { get; set; }
        public virtual MentorEmpresarial MentorEmpresarial { get; set; }
    }
}