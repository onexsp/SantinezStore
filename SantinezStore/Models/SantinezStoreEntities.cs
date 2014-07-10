using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SantinezStore.Models
{
        /// <summary>
        /// Representa a la base de datos. 
        /// Define los mappings a las tablas
        /// </summary>
        public class SantinezStoreEntities : DbContext
        {
            public SantinezStoreEntities()
                : base("SantinezStoreEntities")
            { }

            //Tablas
            public DbSet<User> Users { get; set; }

            protected override void OnModelCreating(DbModelBuilder modelBuilder)
            {
                modelBuilder.Entity<User>().Property(p => p.Password).HasMaxLength(200);
            }

        }
    
}