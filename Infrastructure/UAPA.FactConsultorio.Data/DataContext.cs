using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UAPA.FactConsultorio.Domain.Entities;
using UAPA.FactConsultorio.Domain.Enums;

namespace UAPA.FactConsultorio.Data
{
    public class DataContext : DbContext
    {
        const string cnString = "Data Source=JULIANSEGURA-PC; Initial Catalog= Consultorio; Integrated Security=SSPI";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //ToDo: Como encriptar el Connection String
            //var cnString = ConfigurationManager.ConnectionStrings["CellShopContext"].ConnectionString;
            optionsBuilder.UseSqlServer(cnString);
        }

        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            #region Cascade_Delete
            var cascadeFKs = builder.Model.GetEntityTypes()
                            .SelectMany(t => t.GetForeignKeys())
                            .Where(fk => !fk.IsOwnership && fk.DeleteBehavior == DeleteBehavior.Cascade);

            foreach (var fk in cascadeFKs) fk.DeleteBehavior = DeleteBehavior.Restrict;
            #endregion

            base.OnModelCreating(builder);

            #region Keys
            builder.Entity<User>().HasIndex(u => u.UserName).IsUnique();
            builder.Entity<User>().HasIndex(u => u.Name).IsUnique();

            #endregion

            SeedDefaultData(builder);
        }

        private void SeedDefaultData(ModelBuilder builder)
        {
            builder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    Name = "SYSADMIN",
                    UserName = "sysadmin".ToUpper(),
                    Password = Encoding.ASCII.GetString(new System.Security.Cryptography.SHA256Managed().ComputeHash(Encoding.ASCII.GetBytes("123456"))),
                    Enabled = true,
                    UserRole = (int)UserRoles.Administrator,
                    Locked = false
                }); ;
        }
    }
}
