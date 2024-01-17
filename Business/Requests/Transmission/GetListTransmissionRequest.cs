using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Requests.Transmission;

public class GetListTransmissionRequest
{
    public string Name { get; set; }

    public GetListTransmissionRequest(string name)
    {
        Name = name;
    }
    public GetListTransmissionRequest()
    {
        
    }
}
