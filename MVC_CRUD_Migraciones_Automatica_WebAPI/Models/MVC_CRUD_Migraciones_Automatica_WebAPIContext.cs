using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace MVC_CRUD_Migraciones_Automatica_WebAPI.Models
{
    public class MVC_CRUD_Migraciones_Automatica_WebAPIContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public MVC_CRUD_Migraciones_Automatica_WebAPIContext() : base("name=MVC_CRUD_Migraciones_Automatica_WebAPIContext")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // desabilita el borrado en cascada
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();            
        }

        public System.Data.Entity.DbSet<MVC_CRUD_Migraciones_Automatica_WebAPI.Models.Product> Products { get; set; }

        public System.Data.Entity.DbSet<MVC_CRUD_Migraciones_Automatica_WebAPI.Models.DocumentType> DocumentTypes { get; set; }

        public System.Data.Entity.DbSet<MVC_CRUD_Migraciones_Automatica_WebAPI.Models.Employee> Employees { get; set; }

        public System.Data.Entity.DbSet<MVC_CRUD_Migraciones_Automatica_WebAPI.Models.Supplier> Suppliers { get; set; }

        public System.Data.Entity.DbSet<MVC_CRUD_Migraciones_Automatica_WebAPI.Models.Customer> Customers { get; set; }

        public System.Data.Entity.DbSet<MVC_CRUD_Migraciones_Automatica_WebAPI.Models.Order> Orders { get; set; }

        public System.Data.Entity.DbSet<MVC_CRUD_Migraciones_Automatica_WebAPI.Models.OrderDetail> OrderDetails { get; set; }

        public System.Data.Entity.DbSet<MVC_CRUD_Migraciones_Automatica_WebAPI.Models.Category> Categories { get; set; }
    }
}
