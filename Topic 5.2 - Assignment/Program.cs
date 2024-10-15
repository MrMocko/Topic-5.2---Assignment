using System.Reflection.Metadata;

namespace Topic_5._2___Assignment
{
    internal class Program
    {
        static void Main(string[] args)
            // Andre
            
        {
            int grade, age, bet;
            string multChoice;
            
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
                Console.WriteLine("You are the reason why people die on the road :)");
            }
            else
            {
                Console.WriteLine("oh sweet man you can drive :)");
            }
            Console.WriteLine("How much would you like to bet? ");
            if (int.TryParse(Console.ReadLine(), out bet))
            {
                Console.WriteLine("You bet " + bet.ToString("C"));
            }
            else
            {
                Console.WriteLine("That is not a valid number ");
                Console.WriteLine("Your bet will be set to a minimum of $1.00 ");
                bet = 1;
            }
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("What is your grade? ");
            int.TryParse (Console.ReadLine(), out grade);
            if (grade < 50)
            {
                Console.WriteLine("YOUR HORRIBLE THAT IS A F");
            }
            else if (grade <= 65)
            {
                Console.WriteLine("Thats pretty bad man that a D");
            }
            else if (grade <= 75)
            {
                Console.WriteLine("Your really meh man you got a C");
            }
            else if (grade <= 85)
            {
                Console.WriteLine("Thats pretty good broski thats a B");
            }
            else if (grade > 85)
            {
                Console.WriteLine("THATS PRETTY COOL MAN YOU GOT AN A! WOOOOOOOOOOOOOOOHOOOOOOOO");
            }
            if (grade > 100)
            {
                Thread.Sleep(2000);
                Console.WriteLine("Wait you must be Mr.Cornies.");
            }
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Good luck guessing the right answer, these questions are pretty hard.");
            Thread.Sleep(1000);
            Console.WriteLine("How many Circles O O O");
            multChoice = Console.ReadLine();
            Console.WriteLine("A: 5");
            Console.WriteLine("B: 3");
            Console.WriteLine("C: 1");
            Console.WriteLine("D: 0");
            if (multChoice.ToUpper() == "B" )
            {
                Console.WriteLine("OMG CONGRATS MAN YOU GOT IT RIGHT, IM SHOCKED!!!");
            }
            else if (multChoice.ToUpper() == "C" )
            {
                Console.WriteLine("Bro your dumb...");
            }
            else if (multChoice.ToUpper() == "D" )
            {
                Console.WriteLine("Man you are not very smart man...");
            }

                
            




        }
    }
}
