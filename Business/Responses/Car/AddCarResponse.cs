﻿using Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Responses.Car;

public class AddCarResponse
{
    public int ColorId { get; set; }
    public int ModelId { get; set; }
    public CarState CarState { get; set; } // CarState tipi; --- ?? string or  bool
    public int Kilometer { get; set; }
    public int ModelYear { get; set; }
    public string Plate { get; set; }
    public DateTime CreatedAt { get; set; }
    public AddCarResponse(int colorId, int modelId, CarState carState, int kilometer, int modelYear, string plate, DateTime createdAt)
    {
        ColorId = colorId;
        ModelId = modelId;
        CarState = carState;
        Kilometer = kilometer;
        ModelYear = modelYear;
        Plate = plate;
        CreatedAt = createdAt;
    }
}
