namespace HelsinkiCLI
{
    internal class Eredmeny
    {
        public int Helyzes { get; set; }
        public int Sportolok { get; set; }
        public string Sportag { get; set; }
        public string Versenyszam { get; set; }

        public Eredmeny(string sor)
        {
            string[] v = sor.Split(' ');
            Helyzes = int.Parse(v[0]);
            Sportolok = int.Parse(v[1]);
            Sportag = v[2];
            Versenyszam = v[3];
        }
    }
}
