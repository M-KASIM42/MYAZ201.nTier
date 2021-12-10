﻿using Microsoft.EntityFrameworkCore;
using MYAZ201.nTier.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYAZ201.nTier.DAL.Concrete.EF
{
    public class nTierBookDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<BookDetail> BooksDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = nTierBookDb;");
        }
    }
}
