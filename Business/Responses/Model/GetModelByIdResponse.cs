using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Responses.Model;

public class GetModelByIdResponse
{
    public int Id { get; set; }
    public int BrandId { get; set; }
    public string BrandName { get; set; }
    public int FuelId { get; set; }
    public int TransmissionId { get; set; }
    public string TransmissionName { get; set; }
    public string Name { get; set; }
    public decimal DailyPrice { get; set; }
    public short Year { get; set; }

    public GetModelByIdResponse(int ıd, int brandId, string brandName, int fuelId, int transmissionId, string transmissionName, string name, decimal dailyPrice, short year)
    {
        Id = ıd;
        BrandId = brandId;
        BrandName = brandName;
        FuelId = fuelId;
        TransmissionId = transmissionId;
        TransmissionName = transmissionName;
        Name = name;
        DailyPrice = dailyPrice;
        Year = year;
    }
}
