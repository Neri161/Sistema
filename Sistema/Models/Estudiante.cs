using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sistema.Models
{
    public class Estudiante
    {
        [Key]
        public String Matricula { get; set; }
        public String Nombre { get; set; }
        public String Paterno { get; set; }
        public String Materno { get; set; }
        public String CURP { get; set; }
        public String TipoAlumno { get; set; }
        public String Genero { get; set; }
        public String Correo { get; set; }
        public String ProgramaEducativo { get; set; }
        public String RFC_UE { get; set; }
        public String ClaveUniversidad { get; set; }
        public String ClaveBecaDual { get; set; }
        public int FechaIngresoDual { get; set; }
        public String Telefono { get; set; }
        public String SituacionAcademica { get; set; }
        public int FechaNacimiento { get; set; }
        public String Municipio { get; set; }
        public int CP { get; set; }
        public String Colonia { get; set; }
        public int FechaRegistro { get; set; }
        public String EstatusGeneral { get; set; }
        public virtual UnidadEconomica UnidadEconomica { get; set; }
        public virtual Universidad Universidad { get; set; }
        public virtual BecaDual BecaDual { get; set; }

    }
}