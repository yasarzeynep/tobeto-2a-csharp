﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Requests.Model
{
    public class DeleteModelRequest
    {
        public int Id { get; set; }

        public DeleteModelRequest(int ıd)
        {
            Id = ıd;
        }
    }
}
