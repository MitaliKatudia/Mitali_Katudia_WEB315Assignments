using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TheUnoBooks.Models;

    public class TheUnoBooksContext : DbContext
    {
        public TheUnoBooksContext (DbContextOptions<TheUnoBooksContext> options)
            : base(options)
        {
        }

        public DbSet<TheUnoBooks.Models.Book> Book { get; set; }
    }
