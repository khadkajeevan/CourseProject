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

        public ExpenseTrackDB(DbContextOptions<ExpenseTrackDB> options)
            : base(options)
        {
        }
    }

    public class BankBalance
    {
        [Key]
        
        public int UserID { get; set; }
        public decimal BankAccountBalance { get; set; }
        public decimal Income { get; set; }       
        public decimal TotalExpenses { get; set; }
        public decimal AccountBalance { get; set; }
    }

    public class TargetedExpenses
    {
        [Key]
        public int ExpenseID { get; set; }
        public decimal ExpenseAmount { get; set; }        
        public decimal TotalExpenses { get; set; }
        public decimal RemainingExpenseAmount { get; set; }
    }

    public class ExpensesCategory
    {
       [Key]
        public int ExpensesCategoryId { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public decimal TotalExpenses { get; set; }
       

    }

}
