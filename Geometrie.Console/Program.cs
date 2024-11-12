using Geometrie.BLL;
using Geometrie.BLL.Exceptions;

var p1 = new Point(1, 2);
var p2 = new Point(3, 4);
/*Console.WriteLine(p1.CalculerDistance(p2));*/

var poly = new Triangle(p1, p2, new Point(5, 6));
/*Console.WriteLine(poly.Count);

for (int i = 0; i < poly.Count; i++)
{
    Console.WriteLine(poly[i].X+ " " + poly[i].Y);
}

foreach(var p in poly)
{
    Console.WriteLine(p);
}*/

var cercle1 = new Cercle(p1, 5);
/*Console.WriteLine(poly.CalculerPerimetre());
Console.WriteLine(c.CalculerPerimetre());*/

var t = new Quadrilatère(new Point(4, 8), new Point(3, 5), new Point(1, 2), new Point(3, 4));

var listeDeFormes = new List<IForme>();
listeDeFormes.Add(poly);
listeDeFormes.Add(cercle1);
listeDeFormes.Add(t);

foreach (var f in listeDeFormes)
{
    Console.WriteLine($"Périmètre : {f.CalculerPerimetre()}");
    Console.WriteLine($"Aire : {f.CalculerAire()}");
}

try
{
    var a = new Point(1, 1);
    var b = new Point(2, 2);
    var c = new Point(3, 3);

    var triangleQuiPlante = new Triangle(a, b, c);
} 
catch (PolygoneException ex)
{
    Console.WriteLine(ex.Message);
    foreach (var p in ex.Points)
    {
        Console.WriteLine(p);
    }
} 
catch (ArgumentException e)
{
    Console.WriteLine(e.Message);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}