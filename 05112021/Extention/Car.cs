using System;
using System.Collections.Generic;
using System.Text;

namespace Extention
{
    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }

        public override string ToString()
        {
            return $"Brand: {Brand} - Model: {Model}";
        }

    }
}
