using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace GUIDGenerator
{
    class Generator
    {
        // Declare GUID string list
        public List<string> GUIDS = new List<string>();
        // Declare variable to store menu choice
        public string answer { get; set; }
        public void GenerateGuid()
        {
            // Generates a single GUID and copies it to the users clipboard.

            // Generate GUID to guid variable
            var guid = Guid.NewGuid().ToString().ToUpper();

            // Add it to GUID list
            GUIDS.Add(guid);

            //Copy to user clipboard
            Clipboard.SetText(guid);

            // Output to the console
            Console.WriteLine(guid);
            Console.Write("[GUID COPIED TO CLIPBOARD]");
            Console.WriteLine();
            Console.WriteLine();
        }
        public void StartProgram()
        {
            // Useless starting function to clean up main function
            Console.WriteLine("Basic Console GUID Generator");
            Console.WriteLine();
        }

        public void SaveGUIDs()
        {
            // Ask user for file destination
            Console.Write("Please enter file path: ");
            var filePath = Console.ReadLine();

            // Ask use for file name 
            Console.Write("Please enter file name: ");
            var fileName = Console.ReadLine();

            var fileExtension = ".txt";

            // Combine file name, destination and extension into one path
            var completeFilePath = Path.Combine(filePath, fileName + fileExtension);

            // Write GUID list to .txt file
            System.IO.File.WriteAllLines(completeFilePath, GUIDS);
            Console.Clear();
        }

        public void Menu()
        {
            // Ask user input
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Generate GUID");
            Console.WriteLine("2. Generate Multiple GUIDs");
            Console.WriteLine("3. List GUIDs Generated");
            Console.WriteLine("4. Save GUIDs to file");
            Console.WriteLine("5. QUIT");
            Console.Write("OPTION: ");
            answer = Console.ReadLine();
            Console.WriteLine();
        }

        public void PrintList()
        {
            Console.Clear();

            // For loop to print currently generated GUIDs
            for (int i = 0; i < GUIDS.Count; i++)
            {
                Console.WriteLine(GUIDS[i]);
            }
            Console.ReadLine();
        }

        public void GenerateMultipleGuid()
        {
            Console.Clear();

            // Ask user how many GUIDs they want to generate
            var success = false;
            var result = 0;
            
            do
            {
                Console.Write("How many GUIDs would you like to generate?: ");
                var amount = Console.ReadLine();
                success = Int32.TryParse(amount, out result);

                if (!success)
                {
                    Console.WriteLine("You must enter a number!");
                    Console.ReadLine();
                }

            } while (!success);

            Console.Clear();
            

            // For loop generates GUIDs, stores in list and outputs to console
            for (int i = 0; i < result; i++)
            {
                string guids = Guid.NewGuid().ToString().ToUpper();
                GUIDS.Add(guids);
                Console.WriteLine(guids);
            }
            Console.ReadLine();

        }
    }
}
