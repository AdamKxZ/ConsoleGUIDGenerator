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
