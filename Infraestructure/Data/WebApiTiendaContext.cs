using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Core.Entities;
using Core.Entities.person;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Data
{
    public class WebApiTiendaContext : DbContext
    {
        public WebApiTiendaContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<ProductBrand> ProductBrands { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<PresentationType> PresentationTypes { get; set; }
        public DbSet<DocumentType> DocumentTypes { get; set; }
        public DbSet<RolePerson> RolePersons { get; set; }
        public DbSet<TypePerson> TypePersons { get; set; }
        public DbSet<Person> Persons { get; set; }

        /* public DbSet<> */



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}