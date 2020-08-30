using System;

namespace GUIDGenerator
{
    class Generator
    {
        public void GenerateGuid()
        {
            var guid = Guid.NewGuid().ToString().ToUpper();
            Console.WriteLine(guid);
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
