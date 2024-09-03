using HelsinkiCLI;

List<Eredmeny> eredmenyek = [];

using StreamReader sr = new(@"..\..\..\src\helsinki.txt");

while (!sr.EndOfStream) eredmenyek.Add(new(sr.ReadLine()));

Console.WriteLine($"ennyi sor van: {eredmenyek.Count}");