﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using SysDente.Contexts;
using System;

namespace Models.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20180424134633_Inicial")]
    partial class Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SysDente.Entities.Agenda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Data");

                    b.Property<int>("DentistaId");

                    b.Property<string>("Hora");

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.HasIndex("DentistaId")
                        .IsUnique();

                    b.ToTable("Agendas");
                });

            modelBuilder.Entity("SysDente.Entities.Cidade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("EstadoId");

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.HasIndex("EstadoId")
                        .IsUnique();

                    b.ToTable("Cidades");
                });

            modelBuilder.Entity("SysDente.Entities.Convenio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("DentistaId");

                    b.Property<string>("Descricao");

                    b.Property<int>("EnderecoId");

                    b.Property<string>("Tipo");

                    b.HasKey("Id");

                    b.HasIndex("DentistaId")
                        .IsUnique();

                    b.HasIndex("EnderecoId")
                        .IsUnique();

                    b.ToTable("Convenios");
                });

            modelBuilder.Entity("SysDente.Entities.Dentista", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CPF");

                    b.Property<string>("Email");

                    b.Property<int>("EnderecoId");

                    b.Property<double>("Especialidade");

                    b.Property<string>("Nome");

                    b.Property<double>("Remuneracao");

                    b.Property<string>("Telefone");

                    b.HasKey("Id");

                    b.HasIndex("EnderecoId")
                        .IsUnique();

                    b.ToTable("Dentistas");
                });

            modelBuilder.Entity("SysDente.Entities.Empresa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CNPj");

                    b.Property<string>("Email");

                    b.Property<int>("EnderecoId");

                    b.Property<string>("Nome");

                    b.Property<string>("Telefone");

                    b.HasKey("Id");

                    b.HasIndex("EnderecoId")
                        .IsUnique();

                    b.ToTable("Empresas");
                });

            modelBuilder.Entity("SysDente.Entities.Endereco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CidadeId");

                    b.Property<string>("Numero");

                    b.Property<string>("Rua");

                    b.HasKey("Id");

                    b.HasIndex("CidadeId");

                    b.ToTable("Enderecos");
                });

            modelBuilder.Entity("SysDente.Entities.Estado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome");

                    b.Property<string>("UF");

                    b.HasKey("Id");

                    b.ToTable("Estados");
                });

            modelBuilder.Entity("SysDente.Entities.Exame", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("DentistaId");

                    b.Property<string>("Descricao");

                    b.Property<string>("Tipo");

                    b.HasKey("Id");

                    b.HasIndex("DentistaId")
                        .IsUnique();

                    b.ToTable("Exames");
                });

            modelBuilder.Entity("SysDente.Entities.Fornecedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("DentistaId");

                    b.Property<int>("EmpresaId");

                    b.HasKey("Id");

                    b.HasIndex("DentistaId")
                        .IsUnique();

                    b.HasIndex("EmpresaId")
                        .IsUnique();

                    b.ToTable("Fornecedores");
                });

            modelBuilder.Entity("SysDente.Entities.Funcionario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CPF");

                    b.Property<string>("DataNascimento");

                    b.Property<int>("DentistaId");

                    b.Property<string>("Email");

                    b.Property<int>("EnderecoId");

                    b.Property<double>("Especialidade");

                    b.Property<string>("Nome");

                    b.Property<double>("Remuneracao");

                    b.Property<string>("Telefone");

                    b.HasKey("Id");

                    b.HasIndex("DentistaId")
                        .IsUnique();

                    b.HasIndex("EnderecoId")
                        .IsUnique();

                    b.ToTable("Funcionarios");
                });

            modelBuilder.Entity("SysDente.Entities.HistoricoPaciente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao");

                    b.Property<int>("PacienteId");

                    b.Property<double>("Pagamento");

                    b.Property<string>("Servico");

                    b.HasKey("Id");

                    b.HasIndex("PacienteId")
                        .IsUnique();

                    b.ToTable("HistoricoPacientes");
                });

            modelBuilder.Entity("SysDente.Entities.Paciente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DataNascimento");

                    b.Property<int>("DentistaId");

                    b.Property<string>("Email");

                    b.Property<int>("EnderecoId");

                    b.Property<string>("Nome");

                    b.Property<string>("Telefone");

                    b.HasKey("Id");

                    b.HasIndex("DentistaId")
                        .IsUnique();

                    b.HasIndex("EnderecoId")
                        .IsUnique();

                    b.ToTable("Pacientes");
                });

            modelBuilder.Entity("SysDente.Entities.PacienteConvenio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ConvenioId");

                    b.Property<int>("PacienteId");

                    b.HasKey("Id");

                    b.HasIndex("ConvenioId")
                        .IsUnique();

                    b.HasIndex("PacienteId")
                        .IsUnique();

                    b.ToTable("PacienteConvenios");
                });

            modelBuilder.Entity("SysDente.Entities.Agenda", b =>
                {
                    b.HasOne("SysDente.Entities.Dentista", "Dentista")
                        .WithMany("Agendas")
                        .HasForeignKey("DentistaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SysDente.Entities.Cidade", b =>
                {
                    b.HasOne("SysDente.Entities.Estado", "Estado")
                        .WithMany("Cidades")
                        .HasForeignKey("EstadoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SysDente.Entities.Convenio", b =>
                {
                    b.HasOne("SysDente.Entities.Dentista", "Dentista")
                        .WithMany("Convenios")
                        .HasForeignKey("DentistaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SysDente.Entities.Endereco", "Endereco")
                        .WithMany("Convenios")
                        .HasForeignKey("EnderecoId");
                });

            modelBuilder.Entity("SysDente.Entities.Dentista", b =>
                {
                    b.HasOne("SysDente.Entities.Endereco", "Endereco")
                        .WithMany("Dentistas")
                        .HasForeignKey("EnderecoId");
                });

            modelBuilder.Entity("SysDente.Entities.Empresa", b =>
                {
                    b.HasOne("SysDente.Entities.Endereco", "Endereco")
                        .WithMany("Empresas")
                        .HasForeignKey("EnderecoId");
                });

            modelBuilder.Entity("SysDente.Entities.Endereco", b =>
                {
                    b.HasOne("SysDente.Entities.Cidade", "Cidade")
                        .WithMany("Enderecos")
                        .HasForeignKey("CidadeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SysDente.Entities.Exame", b =>
                {
                    b.HasOne("SysDente.Entities.Dentista", "Dentista")
                        .WithMany("Exames")
                        .HasForeignKey("DentistaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SysDente.Entities.Fornecedor", b =>
                {
                    b.HasOne("SysDente.Entities.Dentista", "Dentista")
                        .WithMany("Fornecedores")
                        .HasForeignKey("DentistaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SysDente.Entities.Empresa", "Empresa")
                        .WithMany()
                        .HasForeignKey("EmpresaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SysDente.Entities.Funcionario", b =>
                {
                    b.HasOne("SysDente.Entities.Dentista", "Dentista")
                        .WithMany("Funcionarios")
                        .HasForeignKey("DentistaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SysDente.Entities.Endereco", "Endereco")
                        .WithMany("Funcionarios")
                        .HasForeignKey("EnderecoId");
                });

            modelBuilder.Entity("SysDente.Entities.HistoricoPaciente", b =>
                {
                    b.HasOne("SysDente.Entities.Paciente", "Paciente")
                        .WithMany("HistoricoPacientes")
                        .HasForeignKey("PacienteId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SysDente.Entities.Paciente", b =>
                {
                    b.HasOne("SysDente.Entities.Dentista", "Dentista")
                        .WithMany("Pacientes")
                        .HasForeignKey("DentistaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SysDente.Entities.Endereco", "Endereco")
                        .WithMany("Pacientes")
                        .HasForeignKey("EnderecoId");
                });

            modelBuilder.Entity("SysDente.Entities.PacienteConvenio", b =>
                {
                    b.HasOne("SysDente.Entities.Convenio", "Convenio")
                        .WithMany("PacienteConvenios")
                        .HasForeignKey("ConvenioId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SysDente.Entities.Paciente", "Paciente")
                        .WithMany("PacienteConvenios")
                        .HasForeignKey("PacienteId");
                });
#pragma warning restore 612, 618
        }
    }
}