using System;
using System.Collections.Generic;
using System.Text;

namespace Atribute_Reflection
{
    
    class Photo
    {
        [Geo(10, 20)]
        public string Name { get; set; }
        public string Path { get; set; }

        public Photo(string name)
        {
            // Проверка
            Name = name;
        }
    }
}
