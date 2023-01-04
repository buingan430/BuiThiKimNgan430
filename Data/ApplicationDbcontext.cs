using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BuiThiKimNgan430.Models;

    public class ApplicationDbcontext : DbContext
    {
        public ApplicationDbcontext (DbContextOptions<ApplicationDbcontext> options)
            : base(options)
        {
        }

        public DbSet<BuiThiKimNgan430.Models.CompanytBTKN430> CompanyBTKN430 { get; set; } = default!;

        public DbSet<BuiThiKimNgan430.Models.BTKN430> BTKN430s { get; set; } = default!;
    }