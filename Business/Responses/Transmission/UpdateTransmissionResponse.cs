﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Responses.Transmission;
public class UpdateTransmissionResponse
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime UpdatedAt { get; set; }

    public UpdateTransmissionResponse(int id, string name, DateTime updatedAt)
    {
        Id = id;
        Name = name;
        UpdatedAt = updatedAt;
    }
}
