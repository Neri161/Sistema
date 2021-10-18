namespace Sistema.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migracion1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BecaDuals",
                c => new
                    {
                        ClaveBecaDual = c.Int(nullable: false, identity: true),
                        Fuente = c.String(),
                        Duracion = c.String(),
                        Periodicidad = c.String(),
                        TipoBeca = c.String(),
                    })
                .PrimaryKey(t => t.ClaveBecaDual);
            
            CreateTable(
                "dbo.CatalogoProyectoes",
                c => new
                    {
                        NombreProyecto = c.String(nullable: false, maxLength: 128),
                        ClaveProgramaEducativo = c.String(maxLength: 128),
                        RFC_UE = c.String(maxLength: 128),
                        AreaConocimiento = c.String(),
                        Etapa = c.String(),
                        FechaInicio = c.Int(nullable: false),
                        FechaTermino = c.Int(nullable: false),
                        NumeroHoras = c.Int(nullable: false),
                        FechaCambioEstatus = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.NombreProyecto)
                .ForeignKey("dbo.ProgramaEducativoes", t => t.ClaveProgramaEducativo)
                .ForeignKey("dbo.UnidadEconomicas", t => t.RFC_UE)
                .Index(t => t.ClaveProgramaEducativo)
                .Index(t => t.RFC_UE);
            
            CreateTable(
                "dbo.ProgramaEducativoes",
                c => new
                    {
                        ClaveProgramaEducativo = c.String(nullable: false, maxLength: 128),
                        ClaveAsignatura = c.String(maxLength: 128),
                        Version = c.String(),
                        NombreProgramaEducativo = c.String(),
                    })
                .PrimaryKey(t => t.ClaveProgramaEducativo)
                .ForeignKey("dbo.CatalogoCompetencias", t => t.ClaveAsignatura)
                .Index(t => t.ClaveAsignatura);
            
            CreateTable(
                "dbo.CatalogoCompetencias",
                c => new
                    {
                        ClaveAsignatura = c.String(nullable: false, maxLength: 128),
                        Periodo = c.String(),
                        UnidadCompetencia = c.String(),
                        NombreAsignatura = c.String(),
                        Actividad = c.String(),
                    })
                .PrimaryKey(t => t.ClaveAsignatura);
            
            CreateTable(
                "dbo.UnidadEconomicas",
                c => new
                    {
                        RFC_UE = c.String(nullable: false, maxLength: 128),
                        NombreComercial = c.String(),
                        Cargo = c.String(),
                        RazonSocial = c.String(),
                        Colonia = c.String(),
                        Sector = c.String(),
                        Localidad = c.String(),
                        ProgramaEducativo = c.String(),
                        CP = c.Int(nullable: false),
                        Telefono = c.String(),
                        Municipio = c.String(),
                        RepresentanteLegal = c.String(),
                        ClaveMentorEmpresarial = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RFC_UE)
                .ForeignKey("dbo.MentorEmpresarials", t => t.ClaveMentorEmpresarial, cascadeDelete: true)
                .Index(t => t.ClaveMentorEmpresarial);
            
            CreateTable(
                "dbo.MentorEmpresarials",
                c => new
                    {
                        ClaveMentorEmpresarial = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        ApellidoPaterno = c.String(),
                        ApellidoMaterno = c.String(),
                        Telefono = c.Int(nullable: false),
                        Correo = c.String(),
                    })
                .PrimaryKey(t => t.ClaveMentorEmpresarial);
            
            CreateTable(
                "dbo.Estudiantes",
                c => new
                    {
                        Matricula = c.String(nullable: false, maxLength: 128),
                        Nombre = c.String(),
                        Paterno = c.String(),
                        Materno = c.String(),
                        CURP = c.String(),
                        TipoAlumno = c.String(),
                        Genero = c.String(),
                        Correo = c.String(),
                        ProgramaEducativo = c.String(),
                        RFC_UE = c.String(maxLength: 128),
                        ClaveUniversidad = c.String(maxLength: 128),
                        ClaveBecaDual = c.String(),
                        FechaIngresoDual = c.Int(nullable: false),
                        Telefono = c.String(),
                        SituacionAcademica = c.String(),
                        FechaNacimiento = c.Int(nullable: false),
                        Municipio = c.String(),
                        CP = c.Int(nullable: false),
                        Colonia = c.String(),
                        FechaRegistro = c.Int(nullable: false),
                        EstatusGeneral = c.String(),
                        BecaDual_ClaveBecaDual = c.Int(),
                    })
                .PrimaryKey(t => t.Matricula)
                .ForeignKey("dbo.BecaDuals", t => t.BecaDual_ClaveBecaDual)
                .ForeignKey("dbo.UnidadEconomicas", t => t.RFC_UE)
                .ForeignKey("dbo.Universidads", t => t.ClaveUniversidad)
                .Index(t => t.RFC_UE)
                .Index(t => t.ClaveUniversidad)
                .Index(t => t.BecaDual_ClaveBecaDual);
            
            CreateTable(
                "dbo.Universidads",
                c => new
                    {
                        ClaveUniversidad = c.String(nullable: false, maxLength: 128),
                        Password = c.String(),
                        Nombre = c.String(),
                        Colonia = c.String(),
                        Localidad = c.String(),
                        Direccion = c.String(),
                        CP = c.Int(nullable: false),
                        Municipio = c.String(),
                    })
                .PrimaryKey(t => t.ClaveUniversidad);
            
            CreateTable(
                "dbo.Mentors",
                c => new
                    {
                        CURP_mentor = c.String(nullable: false, maxLength: 128),
                        RFC_UE = c.String(maxLength: 128),
                        ClaveProgramaEducativo = c.String(maxLength: 128),
                        TipoMentor = c.String(),
                        Nombre = c.String(),
                        ApellidoPaterno = c.String(),
                        ApellidoMaterno = c.String(),
                        Cargo = c.String(),
                        Telefono = c.Int(nullable: false),
                        Correo = c.String(),
                    })
                .PrimaryKey(t => t.CURP_mentor)
                .ForeignKey("dbo.ProgramaEducativoes", t => t.ClaveProgramaEducativo)
                .ForeignKey("dbo.UnidadEconomicas", t => t.RFC_UE)
                .Index(t => t.RFC_UE)
                .Index(t => t.ClaveProgramaEducativo);
            
            CreateTable(
                "dbo.Responsables",
                c => new
                    {
                        ClaveResponsable = c.Int(nullable: false, identity: true),
                        ClaveProgramaEducativo = c.String(maxLength: 128),
                        CURP = c.String(),
                        Nombre = c.String(),
                        ApellidoPaterno = c.String(),
                        ApellidoMaterno = c.String(),
                        Cargo = c.String(),
                        Telefono = c.Int(nullable: false),
                        Correo = c.String(),
                        TipoResponsable = c.String(),
                    })
                .PrimaryKey(t => t.ClaveResponsable)
                .ForeignKey("dbo.ProgramaEducativoes", t => t.ClaveProgramaEducativo)
                .Index(t => t.ClaveProgramaEducativo);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Responsables", "ClaveProgramaEducativo", "dbo.ProgramaEducativoes");
            DropForeignKey("dbo.Mentors", "RFC_UE", "dbo.UnidadEconomicas");
            DropForeignKey("dbo.Mentors", "ClaveProgramaEducativo", "dbo.ProgramaEducativoes");
            DropForeignKey("dbo.Estudiantes", "ClaveUniversidad", "dbo.Universidads");
            DropForeignKey("dbo.Estudiantes", "RFC_UE", "dbo.UnidadEconomicas");
            DropForeignKey("dbo.Estudiantes", "BecaDual_ClaveBecaDual", "dbo.BecaDuals");
            DropForeignKey("dbo.CatalogoProyectoes", "RFC_UE", "dbo.UnidadEconomicas");
            DropForeignKey("dbo.UnidadEconomicas", "ClaveMentorEmpresarial", "dbo.MentorEmpresarials");
            DropForeignKey("dbo.CatalogoProyectoes", "ClaveProgramaEducativo", "dbo.ProgramaEducativoes");
            DropForeignKey("dbo.ProgramaEducativoes", "ClaveAsignatura", "dbo.CatalogoCompetencias");
            DropIndex("dbo.Responsables", new[] { "ClaveProgramaEducativo" });
            DropIndex("dbo.Mentors", new[] { "ClaveProgramaEducativo" });
            DropIndex("dbo.Mentors", new[] { "RFC_UE" });
            DropIndex("dbo.Estudiantes", new[] { "BecaDual_ClaveBecaDual" });
            DropIndex("dbo.Estudiantes", new[] { "ClaveUniversidad" });
            DropIndex("dbo.Estudiantes", new[] { "RFC_UE" });
            DropIndex("dbo.UnidadEconomicas", new[] { "ClaveMentorEmpresarial" });
            DropIndex("dbo.ProgramaEducativoes", new[] { "ClaveAsignatura" });
            DropIndex("dbo.CatalogoProyectoes", new[] { "RFC_UE" });
            DropIndex("dbo.CatalogoProyectoes", new[] { "ClaveProgramaEducativo" });
            DropTable("dbo.Responsables");
            DropTable("dbo.Mentors");
            DropTable("dbo.Universidads");
            DropTable("dbo.Estudiantes");
            DropTable("dbo.MentorEmpresarials");
            DropTable("dbo.UnidadEconomicas");
            DropTable("dbo.CatalogoCompetencias");
            DropTable("dbo.ProgramaEducativoes");
            DropTable("dbo.CatalogoProyectoes");
            DropTable("dbo.BecaDuals");
        }
    }
}
