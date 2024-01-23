using Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Requests.Car;

public class GetListCarRequest
{
    public short? FilterByYear { get; set; }
    public int? FilterByModelId { get; set; }
    public int? FilterById { get; set; }

}
