﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Sistema.Models
{
    public class CatalogoCompetencia
    {
        [Key]
        public String ClaveAsignatura { get; set; }
        public String Periodo { get; set; }
        public String UnidadCompetencia { get; set; }
        public String NombreAsignatura { get; set; }
        public String Actividad { get; set; }

    }
}