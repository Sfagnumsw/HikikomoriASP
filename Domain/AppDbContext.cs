using HikikomoriWEB.MVC.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HikikomoriWEB.Domain
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Content> Content { get; set; } // таблица
        public DbSet<Category> Category { get; set; } // таблица

        protected override void OnModelCreating(ModelBuilder modelBuilder) // заполнение таблицы при создании
        {
            modelBuilder.Entity<Category>().HasData(new Category
            {
                Id = 10000,
                Name = "Фильмы"
            });

            modelBuilder.Entity<Category>().HasData(new Category
            {
                Id = 10001,
                Name = "Книги"
            });

            modelBuilder.Entity<Category>().HasData(new Category
            {
                Id = 10002,
                Name = "Игры"
            });

            modelBuilder.Entity<Category>().HasData(new Category
            {
                Id = 10003,
                Name = "Сериалы"
            });

            modelBuilder.Entity<Category>().HasData(new Category
            {
                Id = 10004,
                Name = "Аниме"
            });

            modelBuilder.Entity<Category>().HasData(new Category
            {
                Id = 10005,
                Name = "Мультфильмы"
            });
        }
    }
}
