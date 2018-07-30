using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9
{
    class Program
    {
        static List<string> studentNames = new List<string>(new string[]
        {
                "Person1",
                "Person2",
                "Person3",
                "Person4"
        });

        static List<string> faveFood = new List<string>(new string[]
        {
                "Food1",
                "Food2",
                "Food3",
                "Food4"
        });

        static List<string> homeTown = new List<string>(new string[]
            {
                "City1",
                "City2",
                "City3",
                "City4"
            });

        static List<string> funFact = new List<string>(new string[]
            {
                "Fact1",
                "Fact2",
                "Fact3",
                "Fact4"
            });

        static void Main(string[] args)
        {


            string goAgain = "yes";
            string repeat = "yes";


            while (repeat == "yes")
            {
                Console.WriteLine("Hello! Would you like to learn about a student, or add a student? (learn/add)");
                string userInput = ValidateLearnAdd();

                if ((userInput == "learn") || (userInput == "l"))
                {
                    Console.WriteLine($"Please enter a number between 1 and {studentNames.Count}");
                    int userNum = GetNumWithinRange();
                    Console.WriteLine($"The student you chose is {studentNames[userNum - 1]}!");

                    Console.WriteLine("Would you like to learn about their favorite food, hometown, or a fun fact?");
                    string userChoice = ValidateUserLearnAdd();

                    if ((userChoice == "favorite food") || (userChoice == "food"))
                    {
                        Console.WriteLine($"{studentNames[userNum -1]}'s favorite food is {faveFood[userNum - 1]}!");
                    }
                    else if ((userChoice == "hometown") || (userChoice == "city"))
                    {
                        Console.WriteLine($"{studentNames[userNum - 1]}'s hometown is {homeTown[userNum - 1]}!");
                    }
                    else if ((userChoice == "fun fact") ||(userChoice == "fact"))
                    {
                        Console.WriteLine($"{studentNames[userNum - 1]}'s fun fact is {funFact[userNum - 1]}");
                    }
                }
                else if ((userInput == "add") || (userInput == "a"))
                {
                    AddNewInfo();
                }

                


                Console.WriteLine("Would you like to go again?");
                repeat = Console.ReadLine();
                Console.Clear();
            }
            Console.WriteLine("Ok, Goodbye!");
        }

        public static int ValidateStudentNum()
        {

            bool valid = false;
            int num = 0;
            while (!valid)
            {
                try
                {

                    num = int.Parse(Console.ReadLine());
                    valid = true;
                }
                catch (FormatException f)
                {
                    Console.WriteLine("You did not enter a number.");

                }
                catch (Exception e)
                {
                    Console.WriteLine("Error");

                }
            }
            return num;
        }

        public static int GetNumWithinRange()
        {
            int min = 1;
            int max = 5;

            int num = ValidateStudentNum();
            while ((num > max) || (num < min))
            {
                Console.WriteLine($"Please pick a number between 1 and {studentNames.Count}.");
                num = ValidateStudentNum();
            }
            return num;
        }

        public static string ValidateUserLearnAdd()
        {
            bool valid = false;
            string input = "";
            while (!valid)
            {
                try
                {

                    input = Console.ReadLine();
                    valid = true;
                }
                catch (FormatException f)
                {
                    Console.WriteLine("You did not enter a valid response.");

                }
                catch (Exception e)
                {
                    Console.WriteLine("Error");

                }
            }
            return input;
        }// validates input for food/city w/ exception handling


        public static string ValidateLearnAdd()
        {
            string input = Console.ReadLine().ToLower();

            // input = ValidateUserString();
            while ((input != "learn") && (input != "l") && (input != "add") && (input != "a"))
            {
                Console.WriteLine("Please pick either 'learn' or 'add'.");
                input = ValidateUserLearnAdd();
            }

            return input;
        }

        static void AddNewInfo()
        {
            string newInfo = "";

            do
            {
                Console.WriteLine("Student's name:");
                newInfo = Console.ReadLine();
                Console.Clear();
                if (newInfo == "" || newInfo == " ")
                {
                    Console.WriteLine("Please enter a valid name.");
                }
                else
                {
                    studentNames.Add(newInfo);
                }
            }
            while (newInfo == "" || newInfo == " ");

            string newFood = "";
            do
            {
                Console.WriteLine("Student's favorite food:");
                newFood = Console.ReadLine();
                Console.Clear();
                if (newFood == "" || newFood == " ")
                {
                    Console.WriteLine("Please enter a valid input .");
                }
                else
                {
                    faveFood.Add(newFood);
                }
            }
            while (newFood == "" || newFood == " ");

            string newTown = "";
            do
            {
                Console.WriteLine("Please enter this student's hometown.");
                newTown = Console.ReadLine();
                Console.Clear();
                if (newTown == "" || newTown == " ")
                {
                    Console.WriteLine("Please enter a valid input.");
                }
                else
                {
                    homeTown.Add(newTown);
                }
            }
            while (newTown == "" || newTown == " ");

            string newFact = "";
            do
            {
                Console.WriteLine("Please enter a fun fact:");
                newFact = Console.ReadLine();
                Console.Clear();
                if (newFact == "" || newFact == " ")
                {
                    Console.WriteLine("Please enter a valid input.");
                }
                else
                {
                    funFact.Add(newFact);
                }
            }
            while (newFact == "" || newFact == " ");
        }



    }
}
