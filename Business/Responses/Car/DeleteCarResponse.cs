using Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Responses.Car;

public class DeleteCarResponse
{
    public DeleteCarResponse(int ıd, string name, DateTime deletedAt, string message)
    {
        Id = ıd;
        Name = name;
        DeletedAt = deletedAt;
        Message = message;
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime DeletedAt { get; set; }
    public string Message { get; set; }

}

