using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignment
{
    internal class Rectangle
    {   //private field
        private double _length;
        private double _width;

        //constructor
        public Rectangle(double length, double width)
        {
            _length = length;
            _width = width;
        }

        // property
        public double Length
        {
            get { return _length; }
            set { _length = value; }
        }

        public double Width
        {
            get { return _width; }
            set { _width = value; }
        }

        // methods to be overriden in child classes
        public virtual double GetPerimeter()
        {

            return 2 * (_length + _width);
        }

        public virtual double GetArea()
        {
            
            return _length * _width;
        }       

        public virtual double GetVolume()
        {
            // regtangular volume equals zero
            return 0;
        }
        public override string ToString()
        {
            return "Rectangle" + "  L:" + Length + "  W:" + Width;
        }
    }
}
