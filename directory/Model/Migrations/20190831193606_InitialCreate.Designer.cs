﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Model;

namespace Model.Migrations
{
    [DbContext(typeof(SurveyContext))]
    [Migration("20190831193606_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Model.Balance", b =>
                {
                    b.Property<int>("Income")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BankBalance");

                    b.Property<int>("ExpenseTotal");

                    b.Property<string>("UserId");

                    b.HasKey("Income");

                    b.ToTable("Balance");
                });

            modelBuilder.Entity("Model.Expense", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Date");

                    b.Property<int>("ExpenseTotal");

                    b.Property<string>("UserId");

                    b.HasKey("CategoryId");

                    b.ToTable("Expense");
                });

            modelBuilder.Entity("Model.Goal", b =>
                {
                    b.Property<int>("TargetAmount")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ExpenseTotal");

                    b.Property<int>("RemainingExpense");

                    b.Property<string>("UserId");

                    b.HasKey("TargetAmount");

                    b.ToTable("Goal");
                });

            modelBuilder.Entity("Model.Login", b =>
                {
                    b.Property<string>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Password");

                    b.HasKey("UserId");

                    b.ToTable("Login");
                });

            modelBuilder.Entity("Model.Registration", b =>
                {
                    b.Property<int>("PhoneNumber")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EmailAddress");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Password");

                    b.Property<string>("UserId");

                    b.HasKey("PhoneNumber");

                    b.ToTable("Registration");
                });
#pragma warning restore 612, 618
        }
    }
}
