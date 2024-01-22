using Business.Dtos.Brand;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Responses.Brand;

public class GetBrandListResponse
{
    public ICollection<BrandListItemDto> Items { get; set; }

    public GetBrandListResponse() 
    { 
     Items=Array.Empty<BrandListItemDto>();
    }
    public GetBrandListResponse(ICollection<BrandListItemDto> items)
    {
        Items = items;
    }


}

