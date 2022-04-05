using Autofac;
using Autofac.Extras.DynamicProxy;
using Castle.DynamicProxy;
using ThosCafeMenu.Business.Abstract;
using ThosCafeMenu.Business.Concrete; 
using ThosCafeMenu.Data.Repository.Abstract;
using ThosCafeMenu.Data.Repository.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using emarDepo.Data.Repository.Concrete;
using ThosCafeMenu.Core.Utilities.Interceptors;

namespace ThosCafeMenu.Business.DependencyResolvers.Autofac
{
    public class AutoFacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ProductManager>().As<IProductService>().SingleInstance();
            builder.RegisterType<EfProductRepository>().As<IProductRepository>().SingleInstance();
           
            builder.RegisterType<CategoryManager>().As<ICategoryService>().SingleInstance();
            builder.RegisterType<EfCategoryRepository>().As<ICategoryRepository>().SingleInstance();

            builder.RegisterType<PropertyManager>().As<IPropertyService>();
            builder.RegisterType<EfPropertyRepository>().As<IPropertyRepository>();


            builder.RegisterType<ProductPropertyManager>().As<IProductPropertyService>();
            builder.RegisterType<EfProductPropertyRepository>().As<IProductPropertyRepository>();

            builder.RegisterType<UserManager>().As<IUserService>();
            builder.RegisterType<EfUserRepository>().As<IUserRepository>();
             
            builder.RegisterType<AuthManager>().As<IAuthService>(); 

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }

    }
}
