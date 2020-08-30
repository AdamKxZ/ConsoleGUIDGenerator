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
            Console.Title = "Basic Console GUID Generator v0.1";
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
                    Console.WriteLine("2. Generate Multiple GUIDs");
                    Console.WriteLine("3. List GUIDs Generated");
                    Console.WriteLine("4. QUIT");
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
                        gen.GenerateMultipleGuid();
                        isValid = false;
                        askToContinue = false;
                        AskToContinue();
                    }
                    else if (answer == "3")
                    {
                        gen.PrintList();
                        isValid = false;
                        askToContinue = false;
                        AskToContinue();
                    }
                    else if (answer == "4")
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
