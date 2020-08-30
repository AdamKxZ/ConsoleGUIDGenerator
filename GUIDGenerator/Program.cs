using System;

/* 
 *    BASIC GUID GENERATOR
 *    Written by AdamKxZ
 */

namespace GUIDGenerator
{
    class Program
    {
        string programName = "BASIC GUID GENERATOR";
        string programVerson = "0.1";

        static void Main(string[] args)
        {
            Generator gen = new Generator();
            bool isValid = true;

            gen.StartProgram();

            Console.WriteLine("Press any key to generate a GUID.");
            Console.ReadLine();

            do
            {
                gen.GenerateGuid();
                AskToContinue();
            } while (isValid);

            void AskToContinue()
            {
                bool askToContinue = true;
                do
                {
                    Console.Write("Would you like to generate another? (Y)es or (N)o: ");
                    var answer = Console.ReadLine();

                    if (answer == "Y" || answer == "y")
                    {
                        isValid = true;
                        askToContinue = false;
                    }
                    else if (answer == "N" || answer == "n")
                    {
                        isValid = false;
                        askToContinue = false;
                    }
                    else
                    {
                        Console.WriteLine("ERROR: Invalid Input. Must enter either 'Y' or 'N' only!");
                        Console.WriteLine();
                    }
                } while (askToContinue);
            }
        }
    }
}
