using GeneriquesEtDelegues;

var liste = new Liste<int>();
liste.Ajouter(5);
liste.Ajouter(8);
liste.Ajouter(3);

foreach (var element in liste)
{
    Console.WriteLine(element);
}

//tri
liste.Trier((a, b) => a > b);

for (int i = 0; i < liste.Count; i++)
{
    Console.WriteLine(liste[i]);
}