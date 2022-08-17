namespace DataInventryManagement
{
    class Program
    {
        public static void Main(string[]Args)
        {

            String path = "C:\\Users\\palla\\source\\repos\\dailySessionProblem\\DataInventryManagement\\DataInventryManagement\\Inventory.json";
            FetchJsonForRice fetchJsonOfRice = new FetchJsonForRice();

            Rice data = fetchJsonOfRice.Read(path);

            for (int i = 0; i < data.typesOfRice.Count; i++)
            {

                Console.WriteLine(data.typesOfRice[i].name);
                Console.WriteLine(data.typesOfRice[i].weight);
                Console.WriteLine(data.typesOfRice[i].price);
                Console.WriteLine("--------------------------");
            }
            for (int i = 0; i < data.typesOfPulse.Count; i++)
            {

                Console.WriteLine(data.typesOfPulse[i].name);
                Console.WriteLine(data.typesOfPulse[i].weight);
                Console.WriteLine(data.typesOfPulse[i].price);
                Console.WriteLine("--------------------------");
            }
            for (int i = 0; i < data.typesOfWheat.Count; i++)
            {

                Console.WriteLine(data.typesOfWheat[i].name);
                Console.WriteLine(data.typesOfWheat[i].weight);
                Console.WriteLine(data.typesOfWheat[i].price);
                Console.WriteLine("--------------------------");
            }
        }
    }
}