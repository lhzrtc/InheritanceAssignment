using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignment
{
    internal class Box : Rectangle // Box class inherits Regtangle class
    {
        // private field. This is new and not inherit from base class
        private double _height;

        // constructors
        public Box (double length, double width, double height) : base(length,width)
        {
            _height = height;
        }

        // property
        public double Height 
        { get { return _height; } }

        // modify method GetPerimeter inherited from base class
        
        public override double GetPerimeter()
        {
            // no direct access to private fields _length and _width so use property
            return (4 * Length + 4 * Width + 4 * Height); 
        }

        // modify method GetArea inherited from base class
        public override double GetArea()
        {
            return (2 * Length * Width + 2 * (Length + Width) * Height);
        }

        // modify method GetVolume inherited from base class
        public override double GetVolume()
        {
            return Length * Width * Height;
        }
        public override string ToString()
        {
            return "Box" + "  L:" + Length + "  W:" + Width + "  H:" + Height;
        }

    }
}
