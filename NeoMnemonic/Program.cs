using System;

namespace NeoMnemonic
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Mnemonic.CreateMnemonic();
            Console.WriteLine(string.Join(',', words));
            Console.ReadLine();
        }
    }
}
