﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Responses.Fuel;

public class GetListFuelResponse
{
    public IList<GetFuelByIdResponse> Feuls { get; set; } //= new List<GetByIdFuelResponse>();

}
