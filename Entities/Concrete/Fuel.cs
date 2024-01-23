﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Fuel: Entity<int>
    {
        public string Name { get; set; }

        public Fuel(string name)
        {
            Name = name;
        }
        public Fuel()
        {
            
        }
    }
}
