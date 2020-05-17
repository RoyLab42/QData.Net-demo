using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RoyLab.QData.Demo.Enums;
using RoyLab.QData.Demo.Model;

namespace RoyLab.QData.Demo.Data
{
    public class UserDbContext : DbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var userModelBuilder = modelBuilder.Entity<UserModel>();
            userModelBuilder.ToTable(nameof(UserModel));
        }

        /// <summary>
        /// populate sample users for demo purpose
        /// </summary>
        /// <returns></returns>
        public async ValueTask TryPopulateSamplesAsync()
        {
            var userSet = Set<UserModel>();
            if (userSet.Any())
            {
                return;
            }

            await userSet.AddRangeAsync(new UserModel("alice")
            {
                Age = 20,
                Gender = Gender.Female,
                Id = Guid.NewGuid()
            }, new UserModel("bob")
            {
                Age = 30,
                Gender = Gender.Male,
                Id = Guid.NewGuid()
            }, new UserModel("lily")
            {
                Age = 35,
                Gender = Gender.Female,
                Id = Guid.NewGuid()
            }, new UserModel("tony")
            {
                Age = 29,
                Gender = Gender.Male,
                Id = Guid.NewGuid()
            }, new UserModel("boss")
            {
                Age = 40,
                Gender = Gender.Male,
                Id = Guid.NewGuid()
            });
            await SaveChangesAsync();
        }
    }
}