using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignment
{
    internal class RectangularPyramid : Box
    {
        public RectangularPyramid(double length, double width, double height) : base (length, width, height)
        {

        }

        public override double GetPerimeter()
        {
            // caculate total edge length of right rectangular pyramid.
            return 2 * (Length + Width) + 4 * Math.Sqrt(Math.Pow(Length / 2, 2) + Math.Pow(Width / 2, 2) + Math.Pow(Height, 2));     
        }

        public override double GetArea()
        {
            // calculate surface area for right rectangular pyramid
            return Length * Width + Length * Math.Sqrt(Math.Pow(Width / 2, 2) + Height * Height) + Width * Math.Sqrt(Math.Pow(Length /2, 2) + Height * Height) ;
        }
        
       

        public override double GetVolume()
        {
            return (Length * Width * Height) / 3;
        }

        public override string ToString()
        {
            return "Rectangular Pyramid" + "  L:" + Length + "  W:" + Width + "  H:" + Height;
        }
    }
        
            
        

    
}
