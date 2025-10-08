namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            FavSubject();
        }

        public static void FavSubject()
        {
            Console.WriteLine("What is your favorite school subject?");
            string subject = Console.ReadLine();

            switch (subject.ToLower())
            {
                case "math":
                    Console.WriteLine("I don't prefer math");
                        break;
                case "science":
                    Console.WriteLine("Science Rules!");
                    break;
                case "pe":
                case "physical education":
                    Console.WriteLine("Gym is awesome");
                    break;
                case "history":
                    Console.WriteLine("History is awesome");
                    break;
                case "geography":
                    Console.WriteLine("Geography is awesome");
                    break;
                default:
                    Console.WriteLine("I LOVE THAT TOO!");
                    break;
            }
        }
    }
}
