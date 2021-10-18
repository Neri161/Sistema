using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Sistema.Models
{
    public class Mentor
    {
        [Key]
        public String CURP_mentor { get; set; }
        public String RFC_UE { get; set; }
        public String ClaveProgramaEducativo { get; set; }
        public String TipoMentor { get; set; }
        public String Nombre { get; set; }
        public String ApellidoPaterno { get; set; }
        public String ApellidoMaterno { get; set; }
        public String Cargo { get; set; }
        public int Telefono { get; set; }
        public String Correo { get; set; }
        public virtual UnidadEconomica UnidadEconomica { get; set; }
        public virtual ProgramaEducativo ProgramaEducativo { get; set; }
    }
}