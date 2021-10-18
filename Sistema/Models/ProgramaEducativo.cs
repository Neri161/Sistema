using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Sistema.Models
{
    public class ProgramaEducativo
    {
        [Key]
        public String ClaveProgramaEducativo { get; set; }
        public String ClaveAsignatura { get; set; }
        public String Version { get; set; }
        public String NombreProgramaEducativo { get; set; }
        public virtual CatalogoCompetencia CatalogoCompetencia { get; set; }
    }
}