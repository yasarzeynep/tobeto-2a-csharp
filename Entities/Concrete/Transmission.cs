﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete;

public class Transmission : Entity<int>
{
    //public int Id { get; set; }
    public string Name { get; set; }
    //public Transmission(string name)
    //{
    //    Name = name;
    //}
    public Transmission(string name)
    {
        Name = name;
         
    }
    public Transmission()
    {
        
    }
}