using System;

namespace Deliverable1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Oh no! A millennial hipster went back in time and changed all the units of measurement, giving the system a silly name, MilHip.");
            Console.WriteLine("With this Millenial Hipster converter, we'll convert MilHip's to imperial units.");
            Console.WriteLine("The two measurements that the Millenial Hipster's have created are 'fidget spinners' and 'memes'." + Environment.NewLine);

            Boolean keepPlaying;
            const double FIDGETSPINNERS = 3.5;
            const int MEMES = 5;
            do
            {
                Console.Write("Please give a measurement type" + Environment.NewLine + "(inches, feet, fidget spinners, or memes): ");
                string measurementType = Console.ReadLine().ToLower();

                Console.Write("Please give an amount to convert: ");
                double amount = double.Parse(Console.ReadLine());

                const string message = "You have ";

                // convert from inches to fidget spinners
                if (measurementType == "inches" || measurementType == "inch")
                {
                    amount *= FIDGETSPINNERS;
                    if (amount == 1)
                    {
                        Console.WriteLine(message + amount + " fidget spinner." + Environment.NewLine);
                    }
                    else
                    {
                        Console.WriteLine(message + amount + " fidget spinners." + Environment.NewLine);
                    }
                }
                // convert from feet to memes
                else if (measurementType == "feet" || measurementType == "foot")
                {
                    amount *= MEMES;
                    if (amount == 1)
                    {
                        Console.WriteLine(message + amount + " meme." + Environment.NewLine);
                    }
                    else
                    {
                        Console.WriteLine(message + amount + " memes." + Environment.NewLine);
                    }
                }
                // convert from fidget spinners to inches
                else if (measurementType == "fidget spinners" || measurementType == "fidget spinner")
                {
                    amount /= FIDGETSPINNERS;
                    if (amount == 1)
                    {
                        Console.WriteLine(message + amount + " inch." + Environment.NewLine);
                    }
                    else
                    {
                        Console.WriteLine(message + amount + " inches." + Environment.NewLine);
                    }

                }
                // convert from memes to feet
                else if (measurementType == "memes" || measurementType == "meme")
                {
                    amount /= MEMES;
                    if (amount == 1)
                    {
                        Console.WriteLine(message + amount + " foot." + Environment.NewLine);
                    }
                    else
                    {
                        Console.WriteLine(message + amount + " feet." + Environment.NewLine);
                    }

                }
                Console.Write("Would you like to make another conversion? ");
                string convertAgain = Console.ReadLine().ToLower();

                if (convertAgain == "y" || convertAgain == "yes")
                {
                    keepPlaying = true;
                }
                else
                {
                    keepPlaying = false;
                }
            } while (keepPlaying);


        }
    }
}
