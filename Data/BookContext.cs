using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Parcialherramientas.Models;

namespace Parcialherramientas.Data
{
    public class BookContext : DbContext
    {
        public BookContext (DbContextOptions<BookContext> options)
            : base(options)
        {
        }

        public DbSet<Parcialherramientas.Models.Book> Book { get; set; } = default!;
        public DbSet<Parcialherramientas.Models.Autor> Autor { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            modelBuilder.Entity<Autor>()
            .HasMany(p=> p.Books)
            .WithOne(p=> p.Autor)
            .HasForeignKey(p=> p.Id);
        }
    }
}
