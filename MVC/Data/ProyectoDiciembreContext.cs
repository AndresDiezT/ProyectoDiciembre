using MVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC.Data
{
    public class ProyectoDiciembreContext : DbContext
    {
        public ProyectoDiciembreContext() : base("name=ProyectoDiciembre") { }

        public DbSet<TipoDocumento> TiposDocumento { get; set; }
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TipoDocumento>()
                .ToTable("TiposDocumento")
                .HasKey(t => t.Id);

            modelBuilder.Entity<TipoDocumento>()
                .Property(t => t.Id)
                .IsRequired()
                .HasColumnName("Id");

            modelBuilder.Entity<TipoDocumento>()
                .Property(t => t.Title)
                .IsRequired()
                .HasColumnName("Title")
                .HasMaxLength(4);

            modelBuilder.Entity<Persona>()
                .ToTable("Personas")
                .HasKey(p => p.Id);
            modelBuilder.Entity<Persona>()
                .Property(p => p.Id)
                .IsRequired()
                .HasColumnName("Id");
            modelBuilder.Entity<Persona>()
                .Property(p => p.Nombre)
                .IsRequired()
                .HasColumnName("Nombre")
                .HasMaxLength(50);
            modelBuilder.Entity<Persona>()
                .Property(p => p.Apellido)
                .IsRequired()
                .HasColumnName("Apellido")
                .HasMaxLength(50);
            modelBuilder.Entity<Persona>()
                .Property (p => p.NumeroIdentificacion)
                .IsRequired()
                .HasColumnName("NumeroIdentificacion")
                .HasMaxLength(10);

            base.OnModelCreating(modelBuilder);
        }
    }
}