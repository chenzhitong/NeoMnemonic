using System;
using System.Linq;

namespace NeoMnemonic
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var words = Mnemonic.GenerateMnemonic();
                Console.WriteLine("Mnemonic: " + words);
                var seed = Mnemonic.MnemonicToSeed(words);
                var account = new Neo.Wallets.KeyPair(seed.ToList().Take(32).ToArray());
                Console.WriteLine("WIF: " + account.Export());
                Console.ReadLine();
            }
        }
    }
}
