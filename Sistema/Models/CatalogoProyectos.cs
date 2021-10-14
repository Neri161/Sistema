using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sistema.Models
{
    public class CatalogoProyectos
    {
        public String NombreProyecto { get; set; }
        public String ClaveProgramaEducativo { get; set; }
        public String RFC_UnidadEconomica { get; set; }
        public String AreaConocimiento { get; set; }
        public String Etapa { get; set; }
        public int FechaInicio { get; set; }
        public int FechaTermino { get; set; }
        public char Estatus { get; set; }
        public int NumeroHoras { get; set; }
        public int FechaCambioEstatus { get; set; }

    }
}