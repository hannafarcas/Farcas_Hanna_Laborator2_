using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Farcas_Hanna_Laborator2.Models;

namespace Farcas_Hanna_Laborator2.Data
{
    public class Farcas_Hanna_Laborator2Context : DbContext
    {
        public Farcas_Hanna_Laborator2Context (DbContextOptions<Farcas_Hanna_Laborator2Context> options)
            : base(options)
        {
        }

        public DbSet<Farcas_Hanna_Laborator2.Models.Book> Book { get; set; } = default!;

        public DbSet<Farcas_Hanna_Laborator2.Models.Publisher>? Publisher { get; set; }

        public DbSet<Farcas_Hanna_Laborator2.Models.Author>? Author { get; set; }

        public DbSet<Farcas_Hanna_Laborator2.Models.Category>? Category { get; set; }

        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>()
                .HasOne(b => b.Borrowing)
                .WithOne(bw => bw.Book)
                .HasForeignKey<Borrowing>(bw => bw.BookID);
        }
        */

        public DbSet<Farcas_Hanna_Laborator2.Models.Member>? Member { get; set; }

        public DbSet<Farcas_Hanna_Laborator2.Models.Borrowing>? Borrowing { get; set; }

    }

}


