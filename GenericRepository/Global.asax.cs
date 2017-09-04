using Autofac;
using Autofac.Core;
using GenericRepository.Interface;
using GenericRepository.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace GenericRepository
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);


            Database.SetInitializer<TechnologicalDataObjectContext>(new DropCreateDatabaseIfModelChanges<TechnologicalDataObjectContext>());
            var builder = new ContainerBuilder();

           
            builder.RegisterType<GenericRepository<TechnologicalDataModel>>().As<IRepository<TechnologicalDataModel>>()
                .InstancePerLifetimeScope();

            var container = builder.Build();

            TechnologicalDataModel tt = new TechnologicalDataModel();
            tt.ID = 2;
            tt.LowestPrice = 24.3;
            tt.OpenPrice = 20.3;
            tt.HighestPrice = 123.3;
            tt.ClosePrice = 325.23;
            tt.Company = 2330;
            tt.Date = DateTime.Now;
            tt.Volume = 9000;
            container.ResolveOptional<IRepository<TechnologicalDataModel>>(new TypedParameter(typeof(DbContext), new TechnologicalDataObjectContext())).Create(tt);
            //List<TechnologicalDataModel> aa=container.Resolve<IRepository<TechnologicalDataModel>>(new TypedParameter(typeof(DbContext), new TechnologicalDataObjectContext())).GetAll().ToList();

        }
    }
}
