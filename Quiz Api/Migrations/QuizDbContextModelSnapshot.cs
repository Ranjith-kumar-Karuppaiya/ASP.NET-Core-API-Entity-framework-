﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Quiz_Api.Models;

#nullable disable

namespace Quiz_Api.Migrations
{
    [DbContext(typeof(QuizDbContext))]
    partial class QuizDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Quiz_Api.Models.Participant", b =>
                {
                    b.Property<int>("ParticipantId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ParticipantId"), 1L, 1);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Score")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TimeTaken")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ParticipantId");

                    b.ToTable("Participants");
                });

            modelBuilder.Entity("Quiz_Api.Models.Question", b =>
                {
                    b.Property<int>("QId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("QId"), 1L, 1);

                    b.Property<string>("Answer")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ImageName")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Option1")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Option2")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Option3")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Option4")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("QuestionInWords")
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("QId");

                    b.ToTable("Questions");
                });
#pragma warning restore 612, 618
        }
    }
}