using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.İnterceptors;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ProductManager>().As<IProductService>().SingleInstance(); // IProductService istenirse ProductManager ver
            builder.RegisterType<EfProductDal>().As<IProductDal>().SingleInstance(); // productmanager içerisinde ki ıproductdalın instance 'ını ver, tek bir instance oluştur

            var assembly = System.Reflection.Assembly.GetExecutingAssembly(); // çalışan uygulama içerisinde

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces() // implemente edilmiş interfaceleri bul
                .EnableInterfaceInterceptors(new ProxyGenerationOptions() // onları intercept et
                {
                    Selector = new AspectInterceptorSelector() // AspectInterceptorSelector: hangi methodun hangi attribute'ü kullanacağını seç
                }).SingleInstance(); // tek bir instance oluştur
        }
    }
}
