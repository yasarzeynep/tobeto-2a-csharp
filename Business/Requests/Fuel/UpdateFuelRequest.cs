using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Requests.Fuel
{
    public class UpdateFuelRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public UpdateFuelRequest(int ıd, string name)
        {
            Id = ıd;
            Name = name;
        }
    }
}
