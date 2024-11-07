namespace Geometrie.BLL
{
    /// <summary>
    /// Représente un point dans un espace à deux dimensions.
    /// avec des coordonnées x et y.
    /// </summary>
    public class Point
    {
        /// <summary>
        /// Abscisse du point.
        /// </summary>
        public int X { get; private set; }
        /// <summary>
        /// Ordonnée du point.
        /// </summary>
        public int Y { get; private set; }

        /// <summary>
        /// Constructeur d'un point.
        /// </summary>
        /// <param name="x">abscisse du point</param>
        /// <param name="y">ordonnée du point</param>
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        /// <summary>
        /// Calcule la distance entre ce point et un autre point.
        /// </summary>
        /// <param name="other">Un autre <see cref="Point"/></param>
        /// <returns>la distance</returns>
        public double CalculerDistance(Point other)
        {
            return System.Math.Sqrt(System.Math.Pow(X - other.X, 2) + System.Math.Pow(Y - other.Y, 2));
        }

        //toString
        public override string ToString() => $"({X}, {Y})";

        //on implémente l'opérateur ==
        public static bool operator ==(Point p1, Point p2)
        {
            if (ReferenceEquals(p1, p2))
                return true;
            if (ReferenceEquals(p1, null) || ReferenceEquals(p2, null))
                return false;
            return p1.X == p2.X && p1.Y == p2.Y ;
        }

        //on implémente l'opérateur !=
        public static bool operator !=(Point p1, Point p2)
        {
            return !(p1 == p2);
        }
    }
}