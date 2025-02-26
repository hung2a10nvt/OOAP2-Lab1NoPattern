using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1NoPattern
{
    public class Car
    {
        public string Name { get; set; }
        public string Specification { get; set; }
        public string ImagePath { get; set; }

        public Car(string name, string spec, string path)
        {
            Name = name;
            Specification = spec;
            ImagePath = path;
        }
    }

}
