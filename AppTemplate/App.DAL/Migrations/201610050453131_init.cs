namespace App.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ajedrez",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NoMesa = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.RegistroAjedrez",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FechaHoraInicio = c.DateTime(nullable: false),
                        FechaHoraFinal = c.DateTime(nullable: false),
                        IdAlumno = c.Int(nullable: false),
                        IdAjedrez = c.Int(nullable: false),
                        Ajedrez_Id = c.Int(),
                        Alumno_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Ajedrez", t => t.Ajedrez_Id)
                .ForeignKey("dbo.Alumno", t => t.Alumno_Id)
                .Index(t => t.Ajedrez_Id)
                .Index(t => t.Alumno_Id);
            
            CreateTable(
                "dbo.Alumno",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NoControl = c.Int(nullable: false),
                        Grupo = c.String(),
                        Nombre = c.String(),
                        Foto = c.String(),
                        Bloqueado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.RegistroComputadora",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FechaHoraInicio = c.DateTime(nullable: false),
                        FechaHoraFinal = c.DateTime(nullable: false),
                        IdAlumno = c.Int(nullable: false),
                        IdComputadora = c.Int(nullable: false),
                        Alumno_Id = c.Int(),
                        Computadora_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Alumno", t => t.Alumno_Id)
                .ForeignKey("dbo.Computadora", t => t.Computadora_Id)
                .Index(t => t.Alumno_Id)
                .Index(t => t.Computadora_Id);
            
            CreateTable(
                "dbo.Computadora",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NoCubiculo = c.Int(nullable: false),
                        ModeloCompu = c.String(),
                        Status = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Registro_de_Libro",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FechadeSalida = c.DateTime(nullable: false),
                        FechaLimite = c.DateTime(nullable: false),
                        FechadeEntrega = c.DateTime(nullable: false),
                        DetallesdelLibro = c.String(),
                        IdAlumno = c.Int(nullable: false),
                        IdLibro = c.Int(nullable: false),
                        Alumno_Id = c.Int(),
                        Libro_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Alumno", t => t.Alumno_Id)
                .ForeignKey("dbo.Libro", t => t.Libro_Id)
                .Index(t => t.Alumno_Id)
                .Index(t => t.Libro_Id);
            
            CreateTable(
                "dbo.Libro",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Disponible = c.String(),
                        Materia = c.String(),
                        Detalles = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Strikes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Motivo = c.String(),
                        IdAlumno = c.Int(nullable: false),
                        IdUsuario = c.Int(nullable: false),
                        Alumno_Id = c.Int(),
                        Usuario_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Alumno", t => t.Alumno_Id)
                .ForeignKey("dbo.Usuario", t => t.Usuario_Id)
                .Index(t => t.Alumno_Id)
                .Index(t => t.Usuario_Id);
            
            CreateTable(
                "dbo.Usuario",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Contrasena = c.String(),
                        Username = c.String(),
                        APaterno = c.String(),
                        AMaterno = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Strikes", "Usuario_Id", "dbo.Usuario");
            DropForeignKey("dbo.Strikes", "Alumno_Id", "dbo.Alumno");
            DropForeignKey("dbo.Registro_de_Libro", "Libro_Id", "dbo.Libro");
            DropForeignKey("dbo.Registro_de_Libro", "Alumno_Id", "dbo.Alumno");
            DropForeignKey("dbo.RegistroComputadora", "Computadora_Id", "dbo.Computadora");
            DropForeignKey("dbo.RegistroComputadora", "Alumno_Id", "dbo.Alumno");
            DropForeignKey("dbo.RegistroAjedrez", "Alumno_Id", "dbo.Alumno");
            DropForeignKey("dbo.RegistroAjedrez", "Ajedrez_Id", "dbo.Ajedrez");
            DropIndex("dbo.Strikes", new[] { "Usuario_Id" });
            DropIndex("dbo.Strikes", new[] { "Alumno_Id" });
            DropIndex("dbo.Registro_de_Libro", new[] { "Libro_Id" });
            DropIndex("dbo.Registro_de_Libro", new[] { "Alumno_Id" });
            DropIndex("dbo.RegistroComputadora", new[] { "Computadora_Id" });
            DropIndex("dbo.RegistroComputadora", new[] { "Alumno_Id" });
            DropIndex("dbo.RegistroAjedrez", new[] { "Alumno_Id" });
            DropIndex("dbo.RegistroAjedrez", new[] { "Ajedrez_Id" });
            DropTable("dbo.Usuario");
            DropTable("dbo.Strikes");
            DropTable("dbo.Libro");
            DropTable("dbo.Registro_de_Libro");
            DropTable("dbo.Computadora");
            DropTable("dbo.RegistroComputadora");
            DropTable("dbo.Alumno");
            DropTable("dbo.RegistroAjedrez");
            DropTable("dbo.Ajedrez");
        }
    }
}
