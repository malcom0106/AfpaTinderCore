﻿// <auto-generated />
using System;
using AfpaTinderCore.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AfpaTinderCore.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20200513091119_mise a jour personne")]
    partial class miseajourpersonne
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AfpaTinderCore.Data.Models.Allure", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Statut")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Allure");
                });

            modelBuilder.Entity("AfpaTinderCore.Data.Models.Favori", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("FavoriPersonneId")
                        .HasColumnType("int");

                    b.Property<int>("PersonneId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FavoriPersonneId");

                    b.HasIndex("PersonneId");

                    b.ToTable("Favori");
                });

            modelBuilder.Entity("AfpaTinderCore.Data.Models.Loisir", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<bool>("Statut")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Loisirs");
                });

            modelBuilder.Entity("AfpaTinderCore.Data.Models.OrientationSexuelle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Statut")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("OrientationSexuelles");
                });

            modelBuilder.Entity("AfpaTinderCore.Data.Models.Personne", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int?>("AllureId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int>("Enfants")
                        .HasColumnType("int");

                    b.Property<bool>("IsAppliMobile")
                        .HasColumnType("bit");

                    b.Property<bool>("IsGeoloc")
                        .HasColumnType("bit");

                    b.Property<double>("Latitude")
                        .HasColumnType("float");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<double>("Longitude")
                        .HasColumnType("float");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int?>("OrientationSexuelleId")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int?>("SituationFamilialeId")
                        .HasColumnType("int");

                    b.Property<bool>("Statut")
                        .HasColumnType("bit");

                    b.Property<string>("Telephone")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<int?>("TypeRelationId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AllureId");

                    b.HasIndex("OrientationSexuelleId");

                    b.HasIndex("SituationFamilialeId");

                    b.HasIndex("TypeRelationId");

                    b.ToTable("Personnes");
                });

            modelBuilder.Entity("AfpaTinderCore.Data.Models.PersonneLoisir", b =>
                {
                    b.Property<int>("PersonneId")
                        .HasColumnType("int");

                    b.Property<int>("LoisirId")
                        .HasColumnType("int");

                    b.HasKey("PersonneId", "LoisirId");

                    b.HasIndex("LoisirId");

                    b.ToTable("PersonneLoisirs");
                });

            modelBuilder.Entity("AfpaTinderCore.Data.Models.SituationFamiliale", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Statut")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("SituationFamiliales");
                });

            modelBuilder.Entity("AfpaTinderCore.Data.Models.TypeRelation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Statut")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("TypeRelations");
                });

            modelBuilder.Entity("AfpaTinderCore.Data.Models.Favori", b =>
                {
                    b.HasOne("AfpaTinderCore.Data.Models.Personne", "FavoriPersonne")
                        .WithMany()
                        .HasForeignKey("FavoriPersonneId");

                    b.HasOne("AfpaTinderCore.Data.Models.Personne", "Personne")
                        .WithMany("Favoris")
                        .HasForeignKey("PersonneId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AfpaTinderCore.Data.Models.Personne", b =>
                {
                    b.HasOne("AfpaTinderCore.Data.Models.Allure", "Allure")
                        .WithMany()
                        .HasForeignKey("AllureId");

                    b.HasOne("AfpaTinderCore.Data.Models.OrientationSexuelle", "OrientationSexuelle")
                        .WithMany()
                        .HasForeignKey("OrientationSexuelleId");

                    b.HasOne("AfpaTinderCore.Data.Models.SituationFamiliale", "SituationFamiliale")
                        .WithMany()
                        .HasForeignKey("SituationFamilialeId");

                    b.HasOne("AfpaTinderCore.Data.Models.TypeRelation", "TypeRelation")
                        .WithMany()
                        .HasForeignKey("TypeRelationId");
                });

            modelBuilder.Entity("AfpaTinderCore.Data.Models.PersonneLoisir", b =>
                {
                    b.HasOne("AfpaTinderCore.Data.Models.Loisir", "Loisir")
                        .WithMany("PersonneLoisirs")
                        .HasForeignKey("LoisirId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AfpaTinderCore.Data.Models.Personne", "Personne")
                        .WithMany("PersonneLoisirs")
                        .HasForeignKey("PersonneId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
