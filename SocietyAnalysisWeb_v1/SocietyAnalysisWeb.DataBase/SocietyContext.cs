using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using SocietyAnalysisWeb.DataModel;

namespace SocietyAnalysisWeb.DataBase
{
    public class SocietyContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }

        public DbSet<Country> Countries { get; set; }

        public DbSet<City> Cities { get; set; }

        public DbSet<Company> Companies { get; set; }

        public DbSet<Education> Educations { get; set; }

        public DbSet<Job> Jobs { get; set; }

        public DbSet<Language> Languages { get; set; }

        public DbSet<EducationalEstablishment> EducationalEstablishments { get; set; }

        public DbSet<Ownership> Ownerships { get; set; }

        public DbSet<Visit> Visits { get; set; }

        public DbSet<LivingPlace> LivingPlaces { get; set; }

        public SocietyContext(string connectionString)
            : base(connectionString)
        {
            
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Type[] types = GetType().
                Assembly.GetTypes().Where(x => x.BaseType != null && x.BaseType.IsGenericType && x.BaseType.GetGenericTypeDefinition() == typeof(EntityTypeConfiguration<>)).ToArray();//.
            // Where(x => x.BaseType != null && x.BaseType.GetGenericTypeDefinition() == typeof(EntityTypeConfiguration<>)).ToArray();
            foreach (var type in types)
            {
                dynamic obj = Activator.CreateInstance(type);
                modelBuilder.Configurations.Add(obj);
            }
            base.OnModelCreating(modelBuilder);
        }
    }
}
