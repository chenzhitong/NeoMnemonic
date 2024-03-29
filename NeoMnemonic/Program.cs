﻿using System;
using Neo;
using System.Linq;

namespace NeoMnemonic
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    var words = Mnemonic.GenerateMnemonic();
                    Console.WriteLine($"Mnemonic: {words}");

                    var seed = Mnemonic.MnemonicToSeed(words);
                    Console.WriteLine($"Seed: {seed.ToHexString()}");

                    var btc = Mnemonic.SeedToWIF(seed, 0);
                    var neo = Mnemonic.SeedToWIF(seed, 888);
                    var ont = Mnemonic.SeedToWIF(seed, 1024);
                    Console.WriteLine($"BTC WIF: {btc}");
                    Console.WriteLine($"NEO WIF: {neo}");
                    Console.WriteLine($"ONT WIF: {ont}");
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Error: {e.Message}");
                }

                Console.ReadLine();
            }
        }
    }
}
