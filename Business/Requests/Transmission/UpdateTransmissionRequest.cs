using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Requests.Transmission;

public class UpdateTransmissionRequest
{
    public int Id { get; set; }
    public string Name { get; set; }

    public UpdateTransmissionRequest(int id, string name)
    {
        Id = id;
        Name = name;
    }
}
