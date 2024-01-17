using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Requests.Transmission;

public class GetByIdTransmissionRequest
{
    public int Id { get; set; }

    public GetByIdTransmissionRequest(int id)
    {
        Id = id;
    }
}
