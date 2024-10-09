namespace Topic_5._2___Assignment
{
    internal class Program
    {
        static void Main(string[] args)
            // Andre
            
        {
            int grade, age;
            Console.WriteLine("What is your grade");
            int.TryParse(Console.ReadLine(), out grade);
            if (grade >= 50)
            {
                Console.WriteLine("You passed! your stupid");
            } 
            else
                {
                    Console.WriteLine("Better luck next time.");
                }
            Console.WriteLine("Hey man how old are you?");
            Int32.TryParse(Console.ReadLine(), out age);
            Console.WriteLine("Oh so your " + age);
            if (age <= 16 )
            {
                Console.WriteLine("You are the reason why people die :)");
            }
            else
            {
                Console.WriteLine("oh sweet man you can drive :(");
            }
        }
    }
}
