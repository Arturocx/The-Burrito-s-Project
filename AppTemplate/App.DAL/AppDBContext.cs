using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using App.Entities;
namespace App.DAL
{
  public  class AppDBContext : DbContext
   {
       protected override void OnModelCreating(DbModelBuilder modelBuilder)
       {
           
           modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
           base.OnModelCreating(modelBuilder);
       }

       public AppDBContext() : base("BurritosConnName")
       {
           this.Configuration.ValidateOnSaveEnabled = false;

       }
       static AppDBContext()
       {
           DbConfiguration.SetConfiguration(new MySql.Data.Entity.MySqlEFConfiguration());
       }

       public DbSet<Ajedrez> Ajedrez { get; set; }
       public DbSet<Alumno> Alumno { get; set; }
       public DbSet<Computadora> Computadoras { get; set; }
       public DbSet<Libro> Libro { get; set; }
       public DbSet<RegistroAjedrez> RegistroAjedrez { get; set; }
       public DbSet<RegistroComputadora> RegistroComputadora { get; set; }
       public DbSet<Registro_de_Libro> RegistroLibro { get; set; }
       public DbSet<Strikes> Strikes { get; set; }
       public DbSet<Usuario> Usuario { get; set; }
   }
}