using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Server_Calculator.Models;



namespace Server_Calculator.Data
{
    public class CalculatorContext:DbContext
    {
        public CalculatorContext(DbContextOptions<CalculatorContext> options) : base(options) { }

        public DbSet<Calculatrice> Calculatrice_Saved {  get; set; } 
    }
}
