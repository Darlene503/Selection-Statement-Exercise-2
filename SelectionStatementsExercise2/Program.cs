namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What is your favorite subject?");
            string subject = Console.ReadLine();

            switch (subject.ToLower())
            {
                case "science":
                    Console.WriteLine("science is cool!");
                    break;
                case "art":
                    Console.WriteLine("art is the best!");
                    break;
                case "math":
                    Console.WriteLine("math sucks!");
                    break;
                case "pe":
                    Console.WriteLine("pe is fun!");
                    break;
                case "home economics":
                    Console.WriteLine("home economics is boring");
                    break;
                default:
                    Console.WriteLine("I wasn't expecting that.");
                    break;



            }

        }
    }
}