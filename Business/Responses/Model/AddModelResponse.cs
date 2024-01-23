using Microsoft.AspNetCore.Routing.Constraints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Responses.Model;

public class AddModelResponse
{
    public int Id { get; set; }
    public int BrandId { get; set; }
    public int FuelId { get; set; }
    public int TransmissionId { get; set; }
    public string Name { get; set; }
    public decimal DailyPrice { get; set; }
    public short Year { get; set; }
    public DateTime CreatedAt { get; set; }

    public AddModelResponse(int ıd, int brandId, int fuelId, int transmissionId, string name, decimal dailyPrice, short year, DateTime createdAt)
    {
        Id = ıd;
        BrandId = brandId;
        FuelId = fuelId;
        TransmissionId = transmissionId;
        Name = name;
        DailyPrice = dailyPrice;
        Year = year;
        CreatedAt = createdAt;
    }



}
