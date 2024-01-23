using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Responses.Model;

public class UpdateModelResponse
{
   
    public int Id { get; set; }
    public int BrandId { get; set; }
    public int FuelId { get; set; }
    public int TransmissionId { get; set; } 
    public string Name { get; set; }
    public short Year { get; set; } 
    public decimal DailyPrice {  get; set; }
    public DateTime UpdateAt {  get; set; }
   
    public UpdateModelResponse(int ıd, int brandId, int fuelId, int transmissionId, string name, short year, decimal dailyPrice, DateTime updateAt)
    {
        Id = ıd;
        BrandId = brandId;
        FuelId = fuelId;
        TransmissionId = transmissionId;
        Name = name;
        Year = year;
        DailyPrice = dailyPrice;
        UpdateAt = updateAt;
       
    }

}
