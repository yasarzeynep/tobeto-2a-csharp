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
    public string Name { get; set; }
    //public short Year { get; set; }
    public int FuelId { get; set; }
    public int TransmissionId { get; set; }
    public decimal DailyPrice { get; set; }

    public AddModelResponse(int id, int brandId, string name, int fuelId, int transmissionId, decimal dailyPrice)
    {
        Id = id;
        BrandId = brandId;
        Name = name;
        FuelId = fuelId;
        TransmissionId = transmissionId;
        DailyPrice = dailyPrice;
            
    
    }   
}
