﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Responses.Transmission;
public class GetListTransmissionResponse
{
    public IList<GetByIdTransmissionResponse> Transmissions { get; set; }
}
