﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Responses.Fuel;

public class GetFuelByIdResponse
{
    public int Id { get; set; }
    public string Name { get; set; }  
    public DateTime CreatedAt{ get; set; }

}
