using Core.Entities;
using Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete;

public class Color: Entity <int>
{
    public int ColorId { get; set; }
    public ColorName ColorName { get; set; } //ColorName tipi;
    public Color(int colorId, ColorName colorName)
    {
        ColorId = colorId;
        ColorName = colorName;
    }

    
}
