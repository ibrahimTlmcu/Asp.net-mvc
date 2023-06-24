namespace BtkAkademi.Models
{
    public static class Repository
    {
        private static  List <Candidate> applications = new();
        // kullanici listeyi geri dondurmek isterse 

        public static IEnumerable<Candidate> Aplications => applications ;

        public static void Add(Candidate candidate)
        {
            applications.Add(candidate);
        }
    }
}