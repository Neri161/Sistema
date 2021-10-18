using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Sistema.Models
{
    public partial class DB : DbContext
    {
        public DB()
            : base("name=DB")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
        public virtual DbSet<BecaDual> BecaDual { get; set; }
        public virtual DbSet<CatalogoProyecto> CatalogoProyecto { get; set; }
        public virtual DbSet<Estudiante> Estudiante { get; set; }
        public virtual DbSet<Mentor> Mentor { get; set; }
        public virtual DbSet<MentorEmpresarial> MentorEmpresarial { get; set; }
        public virtual DbSet<ProgramaEducativo> ProgramaEducativo { get; set; }
        public virtual DbSet<Responsable> Responsable { get; set; }
        public virtual DbSet<UnidadEconomica> UnidadEconomica { get; set; }
        public virtual DbSet<Universidad> Universidad { get; set; }
    }
}
