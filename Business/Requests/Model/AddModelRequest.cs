using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Requests.Model
{
    public class AddModelRequest
    {

        public int BrandId { get; set; }
        public string Name { get; set; }
        //public short Year { get; set; }
        public int FuelId { get; set; }
        public int TransmissionId { get; set; }
        public decimal DailyPrice { get; set; }

        public AddModelRequest( int brandId, string name, int fuelId, int transmissionId, decimal dailyPrice)
        {
        
            BrandId = brandId;
            Name = name;
            FuelId = fuelId;
            TransmissionId = transmissionId;
            DailyPrice = dailyPrice;


        }
    }
}
