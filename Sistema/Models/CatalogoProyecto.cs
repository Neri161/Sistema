using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Sistema.Models
{
    public class CatalogoProyecto
    {
        [Key]
        public String NombreProyecto { get; set; }
        public String ClaveProgramaEducativo { get; set; }
        public String RFC_UE { get; set; }
        public String AreaConocimiento { get; set; }
        public String Etapa { get; set; }
        public int FechaInicio { get; set; }
        public int FechaTermino { get; set; }
        public char Estatus { get; set; }
        public int NumeroHoras { get; set; }
        public int FechaCambioEstatus { get; set; }
        public virtual ProgramaEducativo ProgramaEducativo { get; set; }
        public virtual UnidadEconomica UnidadEconomica { get; set; }

    }
}