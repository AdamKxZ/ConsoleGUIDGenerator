using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GUIDGenerator
{
    class Generator
    {
        public List<string> GUIDS = new List<string>();
        public void GenerateGuid()
        {
            var guid = Guid.NewGuid().ToString().ToUpper();
            GUIDS.Add(guid);
            Clipboard.SetText(guid);
            Console.WriteLine(guid);
            Console.Write("[GUID COPIED TO CLIPBOARD]");
            Console.WriteLine();
            Console.WriteLine();
        }
        public void StartProgram()
        {
            Console.WriteLine("Basic Console GUID Generator");
            Console.WriteLine();
        }

        public void PrintList()
        {
            Console.Clear();
            for (int i = 0; i < GUIDS.Count; i++)
            {
                Console.WriteLine(GUIDS[i]);
            }
            Console.ReadLine();
        }

        public void GenerateMultipleGuid()
        {
            Console.Clear();
            Console.Write("How many GUIDs would you like to generate?: ");
            int amount = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < amount; i++)
            {
                string guids = Guid.NewGuid().ToString().ToUpper();
                GUIDS.Add(guids);
                Console.WriteLine(guids);
            }
            Console.ReadLine();

        }
    }
}
