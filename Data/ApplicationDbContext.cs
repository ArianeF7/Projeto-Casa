using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CasaDeShow1.Models;

namespace CasaDeShow1.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {

        public DbSet<Local> Locais { get; set; }
        public DbSet<Evento> Eventos { get; set; }
        public DbSet<Comprar> Compras { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
