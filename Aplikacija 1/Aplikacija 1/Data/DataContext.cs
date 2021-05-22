using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Aplikacija_1.Models;

namespace Aplikacija_1.Data
{
    public class DataContext : DbContext
    {
        public DataContext (DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        public DbSet<Aplikacija_1.Models.Film> Film { get; set; }

        public DbSet<Aplikacija_1.Models.RegistrovaniKorisnik> RegistrovaniKorisnik { get; set; }

        public DbSet<Aplikacija_1.Models.Rezervacija> Rezervacija { get; set; }
    }
}
