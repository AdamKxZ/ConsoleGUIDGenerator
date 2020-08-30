using System;
using System.Windows.Forms;

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

        [STAThread]
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
                    Console.WriteLine("What would you like to do?");
                    Console.WriteLine("1. Generate GUID");
                    Console.WriteLine("2. List Generated GUIDs");
                    Console.WriteLine("3. QUIT");
                    Console.Write("OPTION: ");
                    var answer = Console.ReadLine();
                    Console.WriteLine();

                    if (answer == "1")
                    {
                        Console.Clear();
                        isValid = true;
                        askToContinue = false;
                    }
                    else if (answer == "2")
                    {
                        gen.PrintList();
                        isValid = false;
                        askToContinue = false;
                        AskToContinue();
                    }
                    else if (answer == "3")
                    {
                        isValid = false;
                        askToContinue = false;
                    }
                    else
                    {
                        MessageBox.Show("ERROR: Invalid Input. Must only enter 1, 2 or 3");
                        Console.Clear();
                        Console.WriteLine();
                    }
                } while (askToContinue);
            }
        }
    }
}
