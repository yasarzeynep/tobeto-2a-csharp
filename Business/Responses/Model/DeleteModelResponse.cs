using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Responses.Model;

public class DeleteModelResponse
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime DeletedAt { get; set; }

    public DeleteModelResponse(int ıd, string name, DateTime deletedAt)
    {
        Id = ıd;
        Name = name;
        DeletedAt = deletedAt;
    }
}
