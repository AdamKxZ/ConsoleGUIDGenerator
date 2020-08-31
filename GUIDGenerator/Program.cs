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
        [STAThread]
        static void Main(string[] args)
        {
            // Program name and version
            string programName = "Simple Console GUID Generator";
            string programVersion = "v0.2";

            // Set Console Window Name to program name
            Console.Title = programName + " " + programVersion;

            // Create generator object from Generator class
            Generator gen = new Generator();

            // Initiliaze main loop variable
            bool isValid = true;

            // Begin program with useless title
            gen.StartProgram();

            Console.WriteLine("Press any key to generate a GUID.");
            Console.ReadLine();


            // Initial loop
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
                    gen.Menu();

                    if (gen.answer == "1")
                    {
                        Console.Clear();
                        isValid = true;
                        askToContinue = false;
                    }
                    else if (gen.answer == "2")
                    {
                        gen.GenerateMultipleGuid();
                        isValid = false;
                        askToContinue = false;
                        AskToContinue();
                    }
                    else if (gen.answer == "3")
                    {
                        gen.PrintList();
                        isValid = false;
                        askToContinue = false;
                        AskToContinue();
                    }
                    else if (gen.answer == "4")
                    {
                        gen.SaveGUIDs();
                        isValid = false;
                        askToContinue = false;
                        AskToContinue();
                    }
                    else if (gen.answer == "5")
                    {
                        isValid = false;
                        askToContinue = false;
                    }
                    else
                    {
                        MessageBox.Show("ERROR: Invalid Input. You must enter the number of the option you wish to choose.");
                        Console.Clear();
                        Console.WriteLine();
                    }
                } while (askToContinue);
            }
        }
    }
}
