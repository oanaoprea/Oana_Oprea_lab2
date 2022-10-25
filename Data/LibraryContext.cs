﻿using Microsoft.EntityFrameworkCore;
using Oana_Oprea_lab2.Models;

namespace Oana_Oprea_lab2.Data
{
    public class LibraryContext: DbContext
    {
        public LibraryContext(DbContextOptions<LibraryContext> options) : base(options) { }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<Customer>().ToTable("Customer"); 
            modelBuilder.Entity<Order>().ToTable("Order"); 
            modelBuilder.Entity<Book>().ToTable("Book");
            modelBuilder.Entity<Author>().ToTable("Author");
        }
    }
}
