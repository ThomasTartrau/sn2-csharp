using System;
using System.Collections;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometrie.BLL
{
    public abstract class Polygone : IEnumerable<Point>, IForme
    {
        private ArrayList lesPoints;

        //indexeur
        public Point this[int index]
        {
            get
            {
                return (Point)lesPoints[index];
            }
            set
            {
                lesPoints[index] = value;
            }
        }

        /*public int Count
        {
            get
            {
                return lesPoints.Count;
            }
        }*/
        public int Count => lesPoints.Count;

        /// <summary>
        /// Constructeur d'un polygone.
        /// </summary>
        /// <param name="a">1er point</param>
        /// <param name="b">2eme point</param>
        /// <param name="c">3eme point</param>
        /// <param name="autresPoints">Autres points</param>
        /// <exception cref="ArgumentNullException">si un des 3 points obligatoires est null</exception>
        public Polygone(Point a, Point b, Point c, params Point[]? autresPoints)
        {
            if (a == null || b == null || c == null)
                throw new ArgumentNullException("Les points a, b et c doivent être définis.");

            if (autresPoints != null && autresPoints.Any(p => p == null))
                throw new ArgumentException("Les points ne doivent pas être null.");

            lesPoints = new ArrayList();
            lesPoints.Add(a);
            lesPoints.Add(b);
            lesPoints.Add(c);

            if (autresPoints != null)
                lesPoints.AddRange(autresPoints);

            for (int i = 0; i < Count - 1; i++)
                for (int j = i + 1; j < Count; j++)
                    if (this[i] == this[j])
                        throw new ArgumentException("Les points ne doivent pas être égaux.");
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerator<Point> GetEnumerator()
        {
            foreach (Point p in lesPoints)
            {
                //yield c'est un mot clé qui permet de retourner un élément à la fois
                yield return p;
            }
        }

        public override string ToString() => string.Join(", ", lesPoints.Cast<Point>());

        public double CalculerPerimetre()
        {
            double perimetre = 0;
            for (int i = 0; i < Count - 1; i++)
            {
                Point p1 = this[i];
                Point p2 = this[i + 1];
                perimetre += p1.CalculerDistance(p2);
            }
            perimetre += (this[Count - 1]).CalculerDistance(this[0]);
            return perimetre;
        }

        public abstract double CalculerAire();
    }
}
