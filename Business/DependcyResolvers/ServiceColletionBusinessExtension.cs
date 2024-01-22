using Business.Abstract;
using Business.BusinessRules;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependcyResolvers;

public static class ServiceColletionBusinessExtension

{
    public static IServiceCollection AddBusinessServices(this IServiceCollection services)
    {
        services
            .AddSingleton<IBrandService, BrandManager>()
            .AddSingleton<IBrandDal, InMemoryBrandDal>()
            .AddSingleton<BrandBusinessRules>(); // Fluent
        // Singleton: Tek bir nesne oluşturur ve herkese onu verir.
        // Ek ödev diğer yöntemleri araştırınız.

        services.AddAutoMapper(Assembly.GetExecutingAssembly()); // AutoMapper.Extensions.Microsoft.DependencyInjection NuGet Paketi
        // Reflection yöntemiyle Profile class'ını kalıtım alan tüm class'ları bulur ve AutoMapper'a ekler.

        return services;
    }
}
