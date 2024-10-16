namespace Topic___8___Lists_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int max;
            int min;
            int numbs;
            bool done = false;
            string choice;
            List<int> numbers = new List<int>();
            Random generator = new Random();

            //Assignment 1

            List<string> colors = new List<string> { "red", "green", "blue", "orange", "yellow" };

            for (int i = 0; i < colors.Count; i++)
            {
                Console.Write(colors[i] + ", ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press Enter to get a random color");
            Console.ReadLine();
            Console.WriteLine(colors[generator.Next(colors.Count)]);
            Console.ReadLine();
            Console.Clear();

            //Asignment 2



            Console.WriteLine("how many numbers do you need");
            int.TryParse(Console.ReadLine(), out numbs);
            Console.WriteLine("Max number");
            int.TryParse((string)Console.ReadLine(), out max);

            
            Console.WriteLine("minimum number");
            int.TryParse(Console.ReadLine(), out min);

            while (!done)
            {
                Console.Clear();
                for (int i = 0; i < numbs; i++)
                    numbers.Add(generator.Next(min, max + 1));


                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] == 0)
                        Console.Write("zero, ");
                    else
                    {
                        Console.Write(numbers[i] + ", ");
                    }
                }
                    Console.WriteLine("Press Enter to get more numbers");
                    Console.WriteLine("Press Q to leave");
                    choice = Console.ReadLine().ToLower();
                    if (choice == "q")
                        done = true;
                    else
                    { done = false; }
                
            }

        }
    }
}
