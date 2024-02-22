using Business.Dtos.Brand;
using Business.Dtos.Car;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Responses.Car;

public class GetCarListResponse
{
    public ICollection<CarListItemDto> Items { get; set; }

}