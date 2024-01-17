using AutoMapper;
using Business.Abstract;
using Business.BusinessRules;
using Business.Concrete;
using Business.Requests.Brand;
using Business.Responses.Brand;
using Business.Requests.Fuel;
using Business.Responses.Fuel;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Business.Requests.Transmission;
using Business.Responses.Transmission;

namespace WebAPI;

public static class ServiceRegistration
{
    // Brand Servisi ve Mapper
    public static readonly IBrandDal BrandDal = new InMemoryBrandDal();
    public static readonly BrandBusinessRules BrandBusinessRules = new BrandBusinessRules(BrandDal);

    public static readonly IMapper BrandMapper = new MapperConfiguration(cfg =>
    {
        cfg.CreateMap<AddBrandRequest, Brand>();
        cfg.CreateMap<Brand, AddBrandResponse>();
    }).CreateMapper();

    public static readonly IBrandService BrandService = new BrandManager(
        BrandDal,
        BrandBusinessRules,
        BrandMapper
    );

    // Fuel Servisi ve Mapper
    public static readonly IFuelDal FuelDal = new InMemoryFuelDal();
    public static readonly FuelBusinessRules FuelBusinessRules = new FuelBusinessRules(FuelDal);

    public static readonly IMapper FuelMapper = new MapperConfiguration(cfg =>
    {
        cfg.CreateMap<AddFuelRequest, Fuel>();
        cfg.CreateMap<Fuel, AddFuelResponse>();

        cfg.CreateMap<UpdateFuelRequest, Fuel>();
        cfg.CreateMap<Fuel, UpdateFuelResponse>();

        cfg.CreateMap<GetByIdFuelRequest, Fuel>();
        cfg.CreateMap<Fuel, GetByIdFuelResponse>();

        cfg.CreateMap<DeleteFuelRequest, Fuel>();
        cfg.CreateMap<Fuel, DeleteFuelResponse>();
    }).CreateMapper();

    public static readonly IFuelService FuelService = new FuelManager(
        FuelDal,
        FuelMapper,
        FuelBusinessRules
    );

    public static readonly ITransmissionDal TransmissionDal = new InMemoryTransmissionDal();

    public static readonly TransmissionBusinessRules TransmissionBusinessRules = new TransmissionBusinessRules(TransmissionDal);

    public static readonly IMapper TransmissionMapper = new MapperConfiguration(cfg =>
    {
        cfg.CreateMap<AddTransmissionRequest, Transmission>();
        cfg.CreateMap<Transmission, AddTransmissionResponse>();

        cfg.CreateMap<UpdateTransmissionRequest, Transmission>();
        cfg.CreateMap<Transmission, UpdateTransmissionResponse>();

        cfg.CreateMap<GetByIdTransmissionRequest, Transmission>();
        cfg.CreateMap<Transmission, GetByIdTransmissionResponse>();

        cfg.CreateMap<DeleteTransmissionRequest, Transmission>();
        cfg.CreateMap<Transmission, DeleteTransmissionResponse>();
    }).CreateMapper();

    public static readonly ITransmissionService TransmissionService = new TransmissionManager(
        TransmissionDal,
        TransmissionBusinessRules,
        TransmissionMapper
    );
}
