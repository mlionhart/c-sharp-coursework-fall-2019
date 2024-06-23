using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterface
{
    abstract class Shape
    {
        public Shape(string name = "NoName")
        { PetName = name; }

        public string PetName { get; set; }

        // Every derived class must now support this method!
        //public abstract byte GetNumberOfPoints();

        // A single virtual method
        public abstract void Draw();       
    }
}
