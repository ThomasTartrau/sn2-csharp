using Geometrie.BLL.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometrie.BLL
{
    public class Triangle : Polygone
    {
        public Triangle(Point a, Point b, Point c) 
            : base(a, b, c)
        {

            var listeCote = new List<double>()
            {
                a.CalculerDistance(b),
                b.CalculerDistance(c),
                c.CalculerDistance(a)
            };

            listeCote.Sort();

            if (listeCote[2] <= listeCote[0] + listeCote[1])
                throw new PolygoneException("Les points sont alignés", this);
        }

        public override double CalculerAire()
        {
            double a = this[0].CalculerDistance(this[1]);
            double b = this[1].CalculerDistance(this[2]);
            double c = this[2].CalculerDistance(this[0]);

            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}
