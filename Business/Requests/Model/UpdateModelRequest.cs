﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Requests.Model;

public class UpdateModelRequest
{
    public int Id { get; set; }
    public int BrandId { get; set; }
    public int FuelId { get; set; }
    public int TransmissionId { get; set; }
    public string Name { get; set; }
    public decimal DailyPrice { get; set; }
    public short Year { get; set; }

    public UpdateModelRequest(int ıd, int brandId, int fuelId, int transmissionId, string name, decimal dailyPrice, short year)
    {
        Id = ıd;
        BrandId = brandId;
        FuelId = fuelId;
        TransmissionId = transmissionId;
        Name = name;
        DailyPrice = dailyPrice;
        Year = year;
       
    }
}
