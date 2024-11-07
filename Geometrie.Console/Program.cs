using Geometrie.BLL;

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

var c = new Cercle(p1, 5);
/*Console.WriteLine(poly.CalculerPerimetre());
Console.WriteLine(c.CalculerPerimetre());*/

var t = new Quadrilatère(new Point(4, 8), new Point(3, 5), new Point(1, 2), new Point(3, 4));

var listeDeFormes = new List<IForme>();
listeDeFormes.Add(poly);
listeDeFormes.Add(c);
listeDeFormes.Add(t);

foreach (var f in listeDeFormes)
{
    Console.WriteLine($"Périmètre : {f.CalculerPerimetre()}");
    Console.WriteLine($"Aire : {f.CalculerAire()}");
}