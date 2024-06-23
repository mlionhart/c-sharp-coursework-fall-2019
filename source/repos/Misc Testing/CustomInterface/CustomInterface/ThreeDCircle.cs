using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterface
{
    // Circle supports IDraw3D
    class ThreeDCircle : Circle, IDraw3D
    {
        public void Draw3D()
        {
            Console.WriteLine("Drawing circle in 3D!");
        }            
    }
}
