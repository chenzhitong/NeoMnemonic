using NBitcoin;
using Neo;
using Neo.Cryptography;
using Neo.IO;
using Neo.SmartContract;
using Neo.Wallets;
using Org.BouncyCastle.Utilities.Encoders;
using System;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;

namespace NeoMnemonic
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = "decrease horror keen muffin certain peace lemon mind click nuclear father apart will rebel media frost wire clay key width repeat random duty cube";
            Console.WriteLine($"Mnemonic: {words}");
            var seed = Mnemonic.MnemonicToSeed(words);
            Console.WriteLine($"Seed: {seed.ToHexString()}");

            Console.WriteLine();

            Console.WriteLine($"兼容onegate:");
            var wif1 = Mnemonic.SeedToWIF_1(seed);
            Console.WriteLine($"WIF: {wif1}");
            var addr1 = Mnemonic.PrivateKeyToAddress(wif1);
            Console.WriteLine($"Address: {addr1}");

            Console.WriteLine();

            Console.WriteLine($"兼容neon, neoline:");
            var wif = Mnemonic.SeedToWIF_2(seed);
            Console.WriteLine($"WIF: {wif}");
            var addr = Mnemonic.PrivateKeyToAddress(wif);
            Console.WriteLine($"Address: {addr}");
        }
    }
}
