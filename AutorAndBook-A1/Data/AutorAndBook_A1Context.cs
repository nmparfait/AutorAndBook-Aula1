using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AutorAndBook_A1.Models;

namespace AutorAndBook_A1.Data
{
    public class AutorAndBook_A1Context : DbContext
    {
        public AutorAndBook_A1Context (DbContextOptions<AutorAndBook_A1Context> options)
            : base(options)
        {
        }

        public DbSet<AutorAndBook_A1.Models.Autor> Autor { get; set; }
    }
}
