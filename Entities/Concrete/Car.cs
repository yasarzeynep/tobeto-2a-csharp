using Core.Entities;
using Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Car:Entity<int>
    {
        public int ColorId { get; set; }
        public int ModelId { get; set; }
        public CarState CarState { get; set; } // CarState tipi; --- ?? string or  bool
        public int Kilometer {  get; set; }
        public int ModelYear {  get; set; }
        public string Plate { get; set; }
        public string Message { get; set; }

        //---
        public Model?  Model { get; set; } = null;
        public Color? Color {  get; set; } = null;//deneme


        public Car() {
        }

        public Car(int colorId, int modelId, CarState carState, int kilometer, int modelYear, string plate, string message)
        {
            ColorId = colorId;
            ModelId = modelId;
            CarState = carState;
            Kilometer = kilometer;
            ModelYear = modelYear;
            Plate = plate;
            Message = message;
        }
    }
}
