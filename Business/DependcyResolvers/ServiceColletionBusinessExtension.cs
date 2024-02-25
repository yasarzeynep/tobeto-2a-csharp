using Business.Abstract;
using Business.BusinessRules;
using Business.Concrete;
using Core.Utilities.Security.JWT;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.EntityFramework.Contexts;
using DataAccess.Concrete.InMemory;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
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
    public static IServiceCollection AddBusinessServices(this IServiceCollection services, IConfiguration configuration)
    {
        services
            .AddScoped<IBrandService, BrandManager>()
            .AddScoped<IBrandDal, EfBrandDal>()
            .AddScoped<BrandBusinessRules>(); // Fluent
        // Singleton: Tek bir nesne oluşturur ve herkese onu verir.
        // Ek ödev diğer yöntemleri araştırınız.

        services.AddScoped<ITokenHelper, JwtTokenHelper>();
        services
            .AddScoped<IModelService, ModelManager>()
            .AddScoped<IModelDal, EfModelDal>()
            .AddScoped<ModelBusinessRules>(); // Fluent

        services.AddAutoMapper(Assembly.GetExecutingAssembly()); // AutoMapper.Extensions.Microsoft.DependencyInjection NuGet Paketi
                                                                 // Reflection yöntemiyle Profile class'ını kalıtım alan tüm class'ları bulur ve AutoMapper'a ekler.

        services
                .AddScoped<ITransmissionService, TransmissionManager>()
                .AddScoped<ITransmissionDal, EfTransmissionDal>()
                .AddScoped<TransmissionBusinessRules>();

        services
            .AddScoped<IFuelService, FuelManager>()
            .AddScoped<IFuelDal, EfFuelDal>()
            .AddScoped<FuelBusinessRules>();

        services
            .AddScoped<ICarService, CarManager>()
            .AddScoped<ICarDal, EfCarDal>()
            .AddScoped<CarBusinessRules>();

        services
                .AddScoped<IUserService, UserManager>()
                .AddScoped<IUserDal, EfUserDal>()
                .AddScoped<UserBusinessRules>();

        services
            .AddScoped<ICustomerService, CustomerManager>()
            .AddScoped<ICustomerDal, EfCustomerDal>()
            .AddScoped<CustomerBusinessRules>();

        services
               .AddScoped<ICorporateCustomerService, CorporateCustomerManager>()
               .AddScoped<ICorporateCustomerDal, EfCorporateCustomerDal>()
               .AddScoped<CorporateCustomerBusinessRules>();

        services
              .AddScoped<IIndividualCustomerService, IndividualCustomerManager>()
              .AddScoped<IIndividualCustomerDal, EfIndividualCustomerDal>()
              .AddScoped<IndividualCustomerBusinessRules>();

        services
            .AddScoped<IUserService, UserManager>()
            .AddScoped<IUserDal, EfUserDal>();

        services.AddDbContext<RentACarContext>(
            options => options.UseSqlServer(configuration.GetConnectionString("RentACarMSSQL22")));
        return services;
    }
}
