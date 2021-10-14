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
        


    }
}