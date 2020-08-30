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
    }
}
