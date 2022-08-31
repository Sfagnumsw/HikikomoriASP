using HikikomoriWEB.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace HikikomoriWEB.Domain
{
    public class AppDbContext : DbContext // контекст базы данных , нужен чтобы связать БД через миграции (еще есть IdentityDbContext для установления границ пользователей и индентификации)
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<RateContent> RateContent { get; set; } // таблица
        public DbSet<Categories> Category { get; set; } // таблица
        public DbSet<RememberContent> RememberContent { get; set; } // таблица
        public DbSet<Roles> Roles { get; set; } // таблица
        public DbSet<UsersDataAutorisation> UsersData {get;set; } // таблица

        protected override void OnModelCreating(ModelBuilder modelBuilder) // заполнение таблицы при создании
        {
            modelBuilder.Entity<Categories>().HasData(new Categories
            {
                Id = 10000,
                Name = "Фильмы"
            });

            modelBuilder.Entity<Categories>().HasData(new Categories
            {
                Id = 10001,
                Name = "Книги"
            });

            modelBuilder.Entity<Categories>().HasData(new Categories
            {
                Id = 10002,
                Name = "Игры"
            });

            modelBuilder.Entity<Categories>().HasData(new Categories
            {
                Id = 10003,
                Name = "Сериалы"
            });

            modelBuilder.Entity<Categories>().HasData(new Categories
            {
                Id = 10004,
                Name = "Мультфильмы"
            });

            modelBuilder.Entity<Roles>().HasData(new Roles
            {
                Id = 1,
                Role = "Администратор"
            });

            modelBuilder.Entity<Roles>().HasData(new Roles
            {
                Id = 2,
                Role = "Пользователь"
            });
        }
    }
}
