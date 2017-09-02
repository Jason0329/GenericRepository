using GenericRepository.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Data.Objects;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;

namespace GenericRepository.Models
{
    public class TechnologicalDataObjectContext : DbContext
    {
        public TechnologicalDataObjectContext(): base("name=SchoolDBConnectionString") 
        {
            
            this.CreateDatabaseInstallationScript();
        }

        public string CreateDatabaseInstallationScript()
        {
            string command = ((IObjectContextAdapter)this).ObjectContext.CreateDatabaseScript();

            return command;
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Configure domain classes using Fluent API here
            modelBuilder.Entity<TechnologicalDataModel>().HasKey<int>(s => s.ID);
            //modelBuilder.Configurations.Add(new TechnologicalDataModelMapping());


            base.OnModelCreating(modelBuilder);
        }
    }
}