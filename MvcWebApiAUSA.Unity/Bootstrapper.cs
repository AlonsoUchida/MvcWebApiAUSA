using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc3;
using MvcWebApiAUSA.DAL.IDALs;
using MvcWebApiAUSA.DAL.DALs;
using MvcWebApiAUSA.Repository.IRepositories;
using MvcWebApiAUSA.Repository.Repositories;

namespace MvcWebApiAUSA.Unity
{
    public static class Bootstrapper
    {
        public static IUnityContainer Container { get; set; }

        public static void Initialise()
        {
            var container = BuildUnityContainer();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));

            Container = container;
        }

        private static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>(); 
            container.RegisterType<INotasDAL, NotasDAL>();
            container.RegisterType<INotasRepository, NotasRepository>();
            return container;
        }
    }
}