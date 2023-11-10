using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Scaffold.EntityFrameworks.Models;

namespace Scaffold.EntityFrameworks.Contexts;

public partial class EstudosContext : DbContext
{
    public EstudosContext()
    {
    }

    public EstudosContext(DbContextOptions<EstudosContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Autores> Autores { get; set; }

    public virtual DbSet<Empresas> Empresas { get; set; }

    public virtual DbSet<Enderecos> Enderecos { get; set; }

    public virtual DbSet<Estados> Estados { get; set; }

    public virtual DbSet<Livros> Livros { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-9UIRIFE;Initial Catalog=Estudos;User Id=sa;Password=123;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Autores>(entity =>
        {
            entity.HasKey(e => e.AutorID).HasName("PK__Autores__F58AE9092AA2ED2A");

            entity.Property(e => e.AutorID).ValueGeneratedNever();
            entity.Property(e => e.NomeAutor)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Empresas>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Empresa");

            entity.Property(e => e.Cnpj)
                .HasMaxLength(14)
                .IsUnicode(false);
            entity.Property(e => e.Cpf)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.DataAbertura).HasColumnType("date");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.InscricaoEstadual)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Nome)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Site)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.Telefone)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Enderecos>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Endereco");

            entity.Property(e => e.Bairro)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Cep)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.Cidade)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Complemento)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Logradouro)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Numero)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Estados>(entity =>
        {
            entity.Property(e => e.Regiao)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Sigla)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.UF)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Livros>(entity =>
        {
            entity.HasKey(e => e.LivroID).HasName("PK__Livros__548655DD9713AF1A");

            entity.Property(e => e.LivroID).ValueGeneratedNever();
            entity.Property(e => e.TituloLivro)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.Autor).WithMany(p => p.Livros)
                .HasForeignKey(d => d.AutorID)
                .HasConstraintName("FK__Livros__AutorID__5EBF139D");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
