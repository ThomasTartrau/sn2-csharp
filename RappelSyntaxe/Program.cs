/*//commentaire
*//* commentaire
 * commentaire
 * commentaire
 *//*

//déclaration de variable

using RappelSyntaxe;

int a;
a = 5;
int b = 3;


//Inférence de type
var c = 5;
var d = new InvalidCastException();
InvalidCastException e = new();

//type anonyme
var voiture = new { Marque = "Renault", Modele = "Clio" };
Console.WriteLine(voiture.Marque);

//type nullable
//sur les types par valeur c'est obligatoire
//si on veut que la variable soit null
int? f = null;
bool? g = null;
//sur les types par référence c'est optionnel
//si on veut que la variable soit null
//ça enlève des warning et c'est une bonne indication
string? s = null;

//type dynamique
//on peut changer le type de la variable
//a utiliser que si on ne peut pas faire autrement
dynamic h = 5;
h = "5";
h = new InvalidCastException();

//tableau
int[] tab = new int[5];
tab[0] = 5;
//syntaxe rapide d'affectation
int[] tab2 = { 1, 2, 3, 4, 5 };
//tableau multidimensionnel
int[,] tab3 = new int[2, 3];
//tableau de tableau
int[][] tab4 = new int[2][];
tab4[0] = new int[3];
tab4[1] = new int[2];
tab4[2] = new int[3];

//Liste
List<int> liste = new List<int>();
liste.Add(5);
//syntaxe rapide d'affectation
List<int> liste2 = new List<int> { 1, 2, 3, 4, 5 };*/

//Méthode d'extension
//on ajoute une méthode à une classe sans la modifier
using RappelSyntaxe;

var chaine = "une chaine de caractères";
Console.WriteLine(chaine.MajusculeAuDebutDesMots());

//LINQ
//Language Integrated Query
//C'est un ensemble de méthodes d'extension sur IEnumerable<T>
//Ca permet de manipuler les listes, tableaux etc...
//de manière plus simple et plus lisible
var listeDEntiers = new List<int>() { 1, 6, 9, 3, -5, -4, 8 };
var lesPositifs = listeDEntiers.Where(i => i > 0).ToList();

var uneAutreListe = new List<int>() { 6, 8, 3, -2, 9, 7 };

//je cherche les éléments communs
var entierCommuns = listeDEntiers.Intersect(uneAutreListe).ToList();