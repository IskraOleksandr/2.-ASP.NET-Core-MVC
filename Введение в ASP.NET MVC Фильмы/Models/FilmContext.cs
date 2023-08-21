﻿
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Films_MVC
{
    public class FilmContext : DbContext
    {
        public DbSet<Film> Films { get; set; }
        public FilmContext(DbContextOptions<FilmContext> options)
           : base(options)
        {
            if (Database.EnsureCreated())
            {
                
                SaveChanges();
            }
        }
    }
}