using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Requests.Fuel
{
    public class GetListFuelRequest
    {public string Name {  get; set; }  
        public GetListFuelRequest(string name) 
        {
            Name = name;
        }
    }
}
