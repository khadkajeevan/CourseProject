using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExpenseTrack.Models
{
    public class ExpenseTrackDB : IdentityDbContext<IdentityUser>  //dbcontext previous
    {
       
        public DbSet<BankBalance> BankBalance { get; set; }
        public DbSet<TargetedExpenses> TargetedExpenses { get; set; }
        public DbSet<ExpensesCategory> ExpensesCategory { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Integrated Security=true;Database=ExpenseTracker");
        }
    }

    public class ExpensesCategory
    {
    
        public int ExpensesCategoryId { get; set; }
        public DateTime Date { get; set; }
        public decimal TotalExpenses { get; set; }
        public string Description { get; set; }

    }

    public class BankBalance
    {
        [Key]
        public int  { get; set; }
        public int Income { get; set; }
        public string UserId { get; set; }
        public int Balance { get; set; }
        public int ExpenseTotal { get; set; }
    }

    public class TargetedExpenses
    {
       
        public int TargetAmount { get; set; }
        public string UserId { get; set; }
        public int ExpenseTotal { get; set; }
        public int RemainingExpense { get; set; }
    }

}
