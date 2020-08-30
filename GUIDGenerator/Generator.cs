using System;

namespace GUIDGenerator
{
    class Generator
    {
        public void GenerateGuid()
        {
            Console.WriteLine(Guid.NewGuid());
            Console.WriteLine();
            Console.ReadKey();
        }
        public void StartProgram()
        {
            Console.WriteLine("Basic Console GUID Generator");
            Console.WriteLine();
        }
    }
}
