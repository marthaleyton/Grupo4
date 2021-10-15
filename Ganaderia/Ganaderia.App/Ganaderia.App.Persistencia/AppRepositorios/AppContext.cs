using Microsoft.EntityFrameworkCore;
using Ganaderia.App.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;



namespace Ganaderia.App.Persistencia
{
   public class AppContext : DbContext
   {
       public DbSet<Persona> Personas { get; set; }
       public DbSet<Ganadero> Ganaderos { get; set; }
       public DbSet<Veterinario> Veterinarios { get; set; }
       public DbSet<Ejemplares> ejemplares { get; set; }
       //public DbSet<Solicitudes> solicitudes { get; set; }
       //public DbSet<HistoriaClinica> historiaClinica { get; set; }
       public DbSet<Vacuna> Vacunas { get; set; }



       protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
       {
           if (!optionsBuilder.IsConfigured) 
           { 
               optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog=Grupo4"); 
           }

       }

   }
}