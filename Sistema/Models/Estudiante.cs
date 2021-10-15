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
        public String matricula { get; set; }
        public String nombre { get; set; }
        public String paterno { get; set; }
        public String materno { get; set; }
        public String CURP { get; set; }
        public String tipoAlumno { get; set; }
        public String genero { get; set; }
        public String correo { get; set; }
        public String programaEducativo { get; set; }
        public String RFC_UE { get; set; }
        public String claveUniversidad { get; set; }
        public String claveBecaDual { get; set; }
        public int fechaIngresoDual { get; set; }
        public String telefono { get; set; }
        public String situacionAcademica { get; set; }
        public int fechaNacimiento { get; set; }
        public String municipio { get; set; }
        public int CP { get; set; }
        public String colonia { get; set; }
        public int fechaRegistro { get; set; }
        public String estatusGeneral { get; set; }
        public virtual UnidadEconomica UnidadEconomica { get; set; }
        public virtual Universidad Universidad { get; set; }
        public virtual BecaDual BecaDual { get; set; }

    }
}