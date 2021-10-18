using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Sistema.Models
{
    public class MentorEmpresarial
    {
        [Key]
        public int ClaveMentorEmpresarial { get; set; }
        public String Nombre { get; set; }
        public String ApellidoPaterno { get; set; }
        public String ApellidoMaterno { get; set; }
        public int Telefono { get; set; }
        public String Correo { get; set; }

    }
}