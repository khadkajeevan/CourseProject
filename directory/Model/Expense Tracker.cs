using System;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Model
{
    public class SurveyContext : DbContext
    {
        public DbSet<Registration> Registration { get; set; }
        public DbSet<Login> Login { get; set; }
        public DbSet<Expense> Expense { get; set; }
        public DbSet<Balance> Balance { get; set; }
        public DbSet<Goal> Goal { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Integrated Security=true;Database=ExpenseTracker");
        }
    }

    public class Registration
    {
        [Key]
        public int PhoneNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }       
        public string UserId { get; set; }
        public string Password { get; set; }
    }

    public class Login
    {
        [Key]
        public string UserId { get; set; }
        public string Password { get; set; }
    }

    public class Expense
    {
        [Key]
        public int CategoryId { get; set; }
        public int Date { get; set; }
        public int ExpenseTotal { get; set; }
        public string UserId { get; set; }
        
    }

    public class Balance
    {
        [Key]
        public int Income { get; set; }
        public string UserId { get; set; }
        public int BankBalance { get; set; }        
        public int ExpenseTotal { get; set; }
    }

    public class Goal
    {
        [Key]
        public int TargetAmount { get; set; }
        public string UserId { get; set; }        
        public int ExpenseTotal { get; set; }
        public int RemainingExpense { get; set; }
    }

    
}
