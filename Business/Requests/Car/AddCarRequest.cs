using Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Requests.Car;

public class AddCarRequest
{
        public int ColorId { get; set; }
        public int ModelId { get; set; }
        public CarState CarState { get; set; } // CarState tipi; --- ?? string or  bool
        public int Kilometer { get; set; }
        public int ModelYear { get; set; }
        public string Plate { get; set; }


        public AddCarRequest(int colorId, int modelId, CarState carState, int kilometer, int modelYear, string plate)
        {
            ColorId = colorId;
            ModelId = modelId;
            CarState = carState;
            Kilometer = kilometer;
            ModelYear = modelYear;
            Plate = plate;
        }
    }

