using System;
using Microsoft.EntityFrameworkCore;
using Server.Classes;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Text;

namespace Server
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            using (ApplicationContext db = new ApplicationContext())
            {
                BinaryFormatter formatter = new BinaryFormatter();
                // создаем два объекта User
                //User user1 = new User { Email = "Tom@pup.com", Password = "333" };
                //User user2 = new User { Email = "Alice@lol", Password = "3334" };

                Character chart = new Character { Id = 1 };

                CharacterProperty prop = new CharacterProperty { Date = DateTime.Now, Status = "Active", Name = "Nationality", Value = Encoding.ASCII.GetBytes("Armanin"), Type = "string", Character = chart };

                // добавляем их в бд
                db.Characters.Add(chart);
                db.CharacterProperties.Add(prop);
                //db.Users.Add(user1);
                //db.Users.Add(user2);
                db.SaveChanges();
                Console.WriteLine("Объекты успешно сохранены");

                // получаем объекты из бд и выводим на консоль
                var users = db.Users.ToList();
                Console.WriteLine("Список объектов:");
                foreach (User u in users)
                {
                    Console.WriteLine($"{u.Id}.{u.Email} - {u.Password}");
                }
                Console.WriteLine("Список чаров:");
                Console.WriteLine();
                Console.WriteLine();
                var characters = db.Characters.ToList();
                foreach (Character u in characters)
                {
                    Console.WriteLine($"{u.Id}.{u.Id}");
                }
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Список свойств:");
                var properties = db.CharacterProperties.ToList();
                foreach (CharacterProperty u in properties)
                {
                    Console.WriteLine($"{u.Date}.{u.Status}.{u.Name}.{Encoding.ASCII.GetString(u.Value)} - {u.Type}.{u.Character}");
                }

            }
            Console.Read();
        }
    }

    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Character> Characters { get; set; }
        public DbSet<CharacterProperty> CharacterProperties { get; set; }

        public ApplicationContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=TestDB;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
