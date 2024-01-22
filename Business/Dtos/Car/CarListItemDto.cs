using Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Car
{
    public class CarListItemDto
    {
        public int Id { get; set; }
        public int ColorId { get; set; }
        public int ModelId { get; set; }
        public CarState CarState { get; set; } // CarState tipi; --- ?? string or  bool
        public int Kilometer { get; set; }
        public int ModelYear { get; set; }
        public string Plate { get; set; }
    }
}
