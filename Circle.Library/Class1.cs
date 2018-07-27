using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle.Library
{
    public class Circle
    {
        public Circle(double radius)
        {
            Radius = radius;
        }

        public double CalculateCircumference()
        {
            double x = 2 * Math.PI * Radius;
            return x;
        }

        public string CalculateFormattedCircumference()
        {
            string formattedCircumference = FormatNumber(CalculateCircumference());
            return formattedCircumference;
        }

        public double CalculateArea()
        {
            double x = Math.PI * Math.Pow(Radius, 2);
            return x;
        }
        
        public string CalculateFormattedArea()
        {
            string formattedArea = FormatNumber(CalculateArea());
            return formattedArea;
        }

        private string FormatNumber(double x)
        {
            string x1 = ($"{x:N2}");
            return x1;
        }
        
        private double Radius { get; set; }
      

    }
}
