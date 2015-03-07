using ContactManager.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace ContactManager.Repositories.RepositoriesImplEF
{
    // The Context needs declare on WebConfig, EF section
    public class SchoolContext : DbContext
    {
        // SchoolContext is the name of ConnectionString in Web.config nas is the defaul class name (can exclude from base command)
        public SchoolContext() : base("SchoolContext")
        {
        }
        
        public DbSet<Student> Students { get; set; }
        
        // Enrollments and Courses can excluded from here because Students have relationships with him and EF makes auto
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}