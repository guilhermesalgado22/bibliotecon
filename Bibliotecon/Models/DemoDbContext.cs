using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Bibliotecon.Models;

public partial class DemoDbContext : DbContext
{
    public DemoDbContext()
    {
    }

    public DemoDbContext(DbContextOptions<DemoDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cidade> TbCidades { get; set; }
    public virtual DbSet<Reserva> TbReserva { get; set; }

    public virtual DbSet<Devolucao> TbDevolucaos { get; set; }

    public virtual DbSet<Endereco> TbEnderecos { get; set; }

    public virtual DbSet<Estado> TbEstados { get; set; }

    public virtual DbSet<Exemplar> TbExemplars { get; set; }

    public virtual DbSet<ExemplarEmprestimo> TbExemplarEmprestimos { get; set; }

    public virtual DbSet<Funcionario> TbFuncionarios { get; set; }

    public virtual DbSet<Leitor> TbLeitors { get; set; }

    public virtual DbSet<Livro> TbLivro { get; set; }

    public IQueryable<string> ListarTitulosLivros()
    {
        return TbLivro.Select(l => l.Titulo);
    }



    public virtual DbSet<Reserva> TbReservas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=localhost;database=db_bibliotecon;user=root;password=33551427Gui$", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.32-mysql"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Cidade>(entity =>
        {
            entity.HasKey(e => e.CodCidade).HasName("PRIMARY");

            entity.ToTable("tb_cidade");

            entity.HasIndex(e => e.CodEstado, "cod_estado");

            entity.Property(e => e.CodCidade).HasColumnName("cod_cidade");
            entity.Property(e => e.CodEstado).HasColumnName("cod_estado");
            entity.Property(e => e.Nome)
                .HasMaxLength(50)
                .HasColumnName("nome");

            entity.HasOne(d => d.CodEstadoNavigation).WithMany(p => p.TbCidades)
                .HasForeignKey(d => d.CodEstado)
                .HasConstraintName("tb_cidade_ibfk_1");
        });

        modelBuilder.Entity<Devolucao>(entity =>
        {
            entity.HasKey(e => e.CodDevolucao).HasName("PRIMARY");

            entity.ToTable("tb_devolucao");

            entity.HasIndex(e => e.CodEmprestimo, "cod_emprestimo");

            entity.HasIndex(e => e.CodExemplar, "cod_exemplar");

            entity.HasIndex(e => e.CodFuncionario, "cod_funcionario");

            entity.Property(e => e.CodDevolucao).HasColumnName("cod_devolucao");
            entity.Property(e => e.CodEmprestimo).HasColumnName("cod_emprestimo");
            entity.Property(e => e.CodExemplar).HasColumnName("cod_exemplar");
            entity.Property(e => e.CodFuncionario).HasColumnName("cod_funcionario");
            entity.Property(e => e.DataDevolucao).HasColumnName("data_devolucao");
            entity.Property(e => e.Multa).HasColumnName("multa");
            entity.Property(e => e.Status).HasColumnName("status");

            entity.HasOne(d => d.CodEmprestimoNavigation).WithMany(p => p.TbDevolucaos)
                .HasForeignKey(d => d.CodEmprestimo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("tb_devolucao_ibfk_2");

            entity.HasOne(d => d.CodExemplarNavigation).WithMany(p => p.TbDevolucaos)
                .HasForeignKey(d => d.CodExemplar)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("tb_devolucao_ibfk_3");

            entity.HasOne(d => d.CodFuncionarioNavigation).WithMany(p => p.TbDevolucaos)
                .HasForeignKey(d => d.CodFuncionario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("tb_devolucao_ibfk_1");
        });

        modelBuilder.Entity<Endereco>(entity =>
        {
            entity.HasKey(e => e.CodEndereco).HasName("PRIMARY");

            entity.ToTable("tb_endereco");

            entity.HasIndex(e => e.CodCidade, "cod_cidade");

            entity.Property(e => e.CodEndereco).HasColumnName("cod_endereco");
            entity.Property(e => e.Bairro)
                .HasMaxLength(50)
                .HasColumnName("bairro");
            entity.Property(e => e.CodCidade).HasColumnName("cod_cidade");
            entity.Property(e => e.DescEndereco)
                .HasMaxLength(50)
                .HasColumnName("desc_endereco");
            entity.Property(e => e.Numero).HasColumnName("numero");

            entity.HasOne(d => d.CodCidadeNavigation).WithMany(p => p.TbEnderecos)
                .HasForeignKey(d => d.CodCidade)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("tb_endereco_ibfk_1");
        });

        modelBuilder.Entity<Estado>(entity =>
        {
            entity.HasKey(e => e.CodEstado).HasName("PRIMARY");

            entity.ToTable("tb_estado");

            entity.Property(e => e.CodEstado).HasColumnName("cod_estado");
            entity.Property(e => e.Nome)
                .HasMaxLength(50)
                .HasColumnName("nome");
            entity.Property(e => e.Sigla)
                .HasMaxLength(2)
                .HasColumnName("sigla");
        });

        modelBuilder.Entity<Exemplar>(entity =>
        {
            entity.HasKey(e => e.CodExemplar).HasName("PRIMARY");

            entity.ToTable("tb_exemplar");

            entity.HasIndex(e => e.CodFuncionario, "cod_funcionario");

            entity.HasIndex(e => e.CodLivro, "cod_livro");

            entity.Property(e => e.CodExemplar).HasColumnName("cod_exemplar");
            entity.Property(e => e.CodFuncionario).HasColumnName("cod_funcionario");
            entity.Property(e => e.CodLivro).HasColumnName("cod_livro");
            entity.Property(e => e.Status).HasColumnName("status");

            entity.HasOne(d => d.CodFuncionarioNavigation).WithMany(p => p.TbExemplars)
                .HasForeignKey(d => d.CodFuncionario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("tb_exemplar_ibfk_2");

            entity.HasOne(d => d.CodLivroNavigation).WithMany(p => p.TbExemplars)
                .HasForeignKey(d => d.CodLivro)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("tb_exemplar_ibfk_1");
        });

        modelBuilder.Entity<ExemplarEmprestimo>(entity =>
        {
            entity.HasKey(e => e.CodEmprestimo).HasName("PRIMARY");

            entity.ToTable("tb_exemplar_emprestimo");

            entity.HasIndex(e => e.CodExemplar, "cod_exemplar");

            entity.HasIndex(e => e.CodFuncionario, "cod_funcionario");

            entity.HasIndex(e => e.CodLeitor, "cod_leitor");

            entity.Property(e => e.CodEmprestimo).HasColumnName("cod_emprestimo");
            entity.Property(e => e.CodExemplar).HasColumnName("cod_exemplar");
            entity.Property(e => e.CodFuncionario).HasColumnName("cod_funcionario");
            entity.Property(e => e.CodLeitor).HasColumnName("cod_leitor");
            entity.Property(e => e.DataDevolucao).HasColumnName("data_devolucao");
            entity.Property(e => e.DataEmprestimo).HasColumnName("data_emprestimo");

            entity.HasOne(e => e.Reserva)
          .WithMany()
          .HasForeignKey(e => e.CodReserva)
          .OnDelete(DeleteBehavior.ClientSetNull)
          .HasConstraintName("FK_tb_exemplar_emprestimo_tb_reserva_ReservaCodReserva");

            entity.HasOne(d => d.CodExemplarNavigation).WithMany(p => p.TbExemplarEmprestimos)
                .HasForeignKey(d => d.CodExemplar)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("tb_exemplar_emprestimo_ibfk_2");

            entity.HasOne(d => d.CodFuncionarioNavigation).WithMany(p => p.TbExemplarEmprestimos)
                .HasForeignKey(d => d.CodFuncionario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("tb_exemplar_emprestimo_ibfk_1");

            entity.HasOne(d => d.CodLeitorNavigation).WithMany(p => p.TbExemplarEmprestimos)
                .HasForeignKey(d => d.CodLeitor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("tb_exemplar_emprestimo_ibfk_3");
        });

        modelBuilder.Entity<Funcionario>(entity =>
        {
            entity.HasKey(e => e.CodCadastro).HasName("PRIMARY");

            entity.ToTable("tb_funcionario");

            entity.HasIndex(e => e.CodCidade, "cod_cidade");

            entity.HasIndex(e => e.CodEndereco, "cod_endereco");

            entity.HasIndex(e => e.CodEstado, "cod_estado");

            entity.Property(e => e.CodCadastro).HasColumnName("cod_cadastro");
            entity.Property(e => e.CodCidade).HasColumnName("cod_cidade");
            entity.Property(e => e.CodEndereco).HasColumnName("cod_endereco");
            entity.Property(e => e.CodEstado).HasColumnName("cod_estado");
            entity.Property(e => e.Cpf)
                .HasMaxLength(14)
                .HasColumnName("cpf");
            entity.Property(e => e.DataNascimento).HasColumnName("data_nascimento");
            entity.Property(e => e.Nome)
                .HasMaxLength(50)
                .HasColumnName("nome");
            entity.Property(e => e.Rg)
                .HasMaxLength(13)
                .HasColumnName("rg");
            entity.Property(e => e.Salario)
                .HasPrecision(10, 2)
                .HasColumnName("salario");
            entity.Property(e => e.Sexo)
                .HasMaxLength(1)
                .HasColumnName("sexo");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Telefone)
                .HasMaxLength(13)
                .HasColumnName("telefone");

            entity.HasOne(d => d.CodCidadeNavigation).WithMany(p => p.TbFuncionarios)
                .HasForeignKey(d => d.CodCidade)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("tb_funcionario_ibfk_3");

            entity.HasOne(d => d.CodEnderecoNavigation).WithMany(p => p.TbFuncionarios)
                .HasForeignKey(d => d.CodEndereco)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("tb_funcionario_ibfk_2");

            entity.HasOne(d => d.CodEstadoNavigation).WithMany(p => p.TbFuncionarios)
                .HasForeignKey(d => d.CodEstado)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("tb_funcionario_ibfk_1");
        });

        modelBuilder.Entity<Leitor>(entity =>
        {
            entity.HasKey(e => e.CodLeitor).HasName("PRIMARY");

            entity.ToTable("tb_leitor");

            entity.HasIndex(e => e.CodCidade, "cod_cidade");

            entity.HasIndex(e => e.CodEndereco, "cod_endereco");

            entity.HasIndex(e => e.CodEstado, "cod_estado");

            entity.Property(e => e.CodLeitor).HasColumnName("cod_leitor");
            entity.Property(e => e.CodCidade).HasColumnName("cod_cidade");
            entity.Property(e => e.CodEndereco).HasColumnName("cod_endereco");
            entity.Property(e => e.CodEstado).HasColumnName("cod_estado");
            entity.Property(e => e.Cpf)
                .HasMaxLength(14)
                .HasColumnName("cpf");
            entity.Property(e => e.DataNascimento).HasColumnName("data_nascimento");
            entity.Property(e => e.Nome)
                .HasMaxLength(50)
                .HasColumnName("nome");
            entity.Property(e => e.PrazoDevolucao).HasColumnName("prazo_devolucao");
            entity.Property(e => e.Rg)
                .HasMaxLength(13)
                .HasColumnName("rg");
            entity.Property(e => e.Sexo)
                .HasMaxLength(1)
                .HasColumnName("sexo");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Telefone)
                .HasMaxLength(13)
                .HasColumnName("telefone");

            entity.HasOne(d => d.CodCidadeNavigation).WithMany(p => p.TbLeitors)
                .HasForeignKey(d => d.CodCidade)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("tb_leitor_ibfk_3");

            entity.HasOne(d => d.CodEnderecoNavigation).WithMany(p => p.TbLeitors)
                .HasForeignKey(d => d.CodEndereco)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("tb_leitor_ibfk_2");

            entity.HasOne(d => d.CodEstadoNavigation).WithMany(p => p.TbLeitors)
                .HasForeignKey(d => d.CodEstado)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("tb_leitor_ibfk_1");
        });

        modelBuilder.Entity<Livro>(entity =>
        {
            entity.HasKey(e => e.CodLivro).HasName("PRIMARY");

            entity.ToTable("tb_livro");

            entity.Property(e => e.CodLivro).HasColumnName("cod_livro");
            entity.Property(e => e.AnoPublicacao).HasColumnName("ano_publicacao");
            entity.Property(e => e.Autor)
                .HasMaxLength(50)
                .HasColumnName("autor");
            entity.Property(e => e.Categoria)
                .HasMaxLength(50)
                .HasColumnName("categoria");
            entity.Property(e => e.Editora)
                .HasMaxLength(50)
                .HasColumnName("editora");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Titulo)
                .HasMaxLength(50)
                .HasColumnName("titulo");
        });

        modelBuilder.Entity<Reserva>(entity =>
        {
            entity.HasKey(e => e.CodReserva).HasName("PRIMARY");

            entity.ToTable("tb_reserva");

            entity.HasIndex(e => e.CodExemplar, "cod_exemplar");

            entity.HasIndex(e => e.CodFuncionario, "cod_funcionario");

            entity.HasIndex(e => e.CodLeitor, "cod_leitor");

            entity.Property(e => e.CodReserva).HasColumnName("cod_reserva");
            entity.Property(e => e.CodExemplar).HasColumnName("cod_exemplar");
            entity.Property(e => e.CodFuncionario).HasColumnName("cod_funcionario");
            entity.Property(e => e.CodLeitor).HasColumnName("cod_leitor");
            entity.Property(e => e.DataDevolucao).HasColumnName("data_devolucao");
            entity.Property(e => e.DataReserva).HasColumnName("data_reserva");

            entity.HasOne(d => d.CodExemplarNavigation).WithMany(p => p.TbReservas)
                .HasForeignKey(d => d.CodExemplar)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("tb_reserva_ibfk_2");

            entity.HasOne(d => d.CodFuncionarioNavigation).WithMany(p => p.TbReservas)
                .HasForeignKey(d => d.CodFuncionario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("tb_reserva_ibfk_3");

            entity.HasOne(d => d.CodLeitorNavigation).WithMany(p => p.TbReservas)
                .HasForeignKey(d => d.CodLeitor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("tb_reserva_ibfk_1");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
