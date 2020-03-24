using System;

namespace Atribute_Reflection
{
    class GeoAttribute : Attribute
    {

        public int X { get; set; }
        public int Y { get; set; }

        public GeoAttribute(){}

        public GeoAttribute(int x, int y)
        {
            //Проверять входные данные

            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"[{X}]; [{Y}];";
        }

    }
}
