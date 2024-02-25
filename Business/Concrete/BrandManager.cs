﻿using AutoMapper;
using Business.Abstract;
using Business.BusinessRules;
using Business.Requests.Brand;
using Business.Responses.Brand;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;

namespace Business.Concrete;

public class BrandManager : IBrandService
{
    private readonly IBrandDal _brandDal;
    private readonly BrandBusinessRules _brandBusinessRules;
    private readonly IMapper _mapper;
    private readonly IHttpContextAccessor _httpContextAccessor;

    public BrandManager(IBrandDal brandDal, BrandBusinessRules brandBusinessRules, IMapper mapper, IHttpContextAccessor httpContextAccessor)
    {
        _brandDal = brandDal; //new InMemoryBrandDal(); // Başka katmanların class'ları new'lenmez. Bu yüzden dependency injection kullanıyoruz.
        _brandBusinessRules = brandBusinessRules;
        _mapper = mapper;
        _httpContextAccessor = httpContextAccessor;
    }

       // TODO:Homework ;
      // mediatR, pipeline, cqrs: Homework
     // Auth&Authorization
    // Role implementasyonu => Claim'lere kullanıcı rollerini db'den ekleyip gelen isteklerde
   // rol bazlı kontrol yapılması. : Homework


    public AddBrandResponse Add(AddBrandRequest request)
    {
        if (!_httpContextAccessor.HttpContext.User.Identity.IsAuthenticated)
        {
            throw new Exception("Bu endpointi çalıştırmak için giriş yapmak zorundasınız!");
        }

        // İş Kuralları
        _brandBusinessRules.CheckIfBrandNameNotExists(request.Name);

        // Validation
        // Yetki kontrolü
        // Cache
        // Transaction

        //Brand brandToAdd = new(request.Name)
        Brand brandToAdd = _mapper.Map<Brand>(request); // Mapping

        _brandDal.Add(brandToAdd);

        AddBrandResponse response = _mapper.Map<AddBrandResponse>(brandToAdd);
        return response;
    }

    public DeleteBrandResponse Delete(DeleteBrandRequest request)
    {
        throw new NotImplementedException();
    }

    public Brand? GetById(int id)
    {
        return _brandDal.Get(i => i.Id == id);
    }

    public GetBrandByIdResponse GetById(GetBrandByIdRequest request)
    {
        throw new NotImplementedException();
    }

    public UpdateBrandResponse Update(UpdateBrandRequest request)
    {
        throw new NotImplementedException();
    }

    GetBrandListResponse IBrandService.GetList(GetBrandListRequest request)
    {
        // İş Kuralları
        // Validation
        // Yetki kontrolü
        // Cache
        // Transaction

        IList<Brand> brandList = _brandDal.GetList();
        // brandList.Items diye bir alan yok; bu yüzden mapping konfigurasyonu yapmamız gerekiyor.
        // Brand --> BrandListItemDto
        // IList<Brand> -> GetBrandListResponse
        GetBrandListResponse response = _mapper.Map<GetBrandListResponse>(brandList); // Mapping
        return response;
    }
}
