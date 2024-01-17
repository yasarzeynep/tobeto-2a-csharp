using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Responses.Fuel;

public class UpdateFuelResponse
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime UpdateAt { get; set; }

    public UpdateFuelResponse(int id, string name, DateTime updateAt)
    {
        Id = id;
        Name = name;
        UpdateAt = updateAt;
    }

}
