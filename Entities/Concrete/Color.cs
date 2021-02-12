using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Color:IEntity
    {
        public Color()
        {

        }
        public Color(int colorId, string colorName)
        {
            ColorId = colorId;
            ColorName = colorName;
        }

        public int ColorId { get; set; }
        public string ColorName { get; set; }
    }
}
