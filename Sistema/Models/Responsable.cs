using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace Sistema.Models
{
    public class Responsable
    {
        [Key]
        public int ClaveResponsable { get; set; }
        public String ClaveProgramaEducativo { get; set; }
        public String CURP { get; set; }
        public String Nombre { get; set; }
        public String ApellidoPaterno { get; set; }
        public String ApellidoMaterno { get; set; }
        public String Cargo { get; set; }
        public int Telefono { get; set; }
        public String Correo { get; set; }
        public String TipoResponsable { get; set; }
        public virtual ProgramaEducativo ProgramaEducativo { get; set; }
    }
}