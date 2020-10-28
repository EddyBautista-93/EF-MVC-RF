using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EF_MVC_RF.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace EF_MVC_RF.DAL
{
    // inherits methods from dbDBcontext
    public class SchoolContext : DbContext
    {
        // connection string passed through here
        public SchoolContext() : base("SchoolContext")
        {
            //
        }
        // represents the entities in the context that can be queried in the db
        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}