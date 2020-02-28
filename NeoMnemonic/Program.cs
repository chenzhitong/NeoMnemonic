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
                    var words = "spawn tomorrow nurse ring thank hen ritual bracket purity junk coyote all wait pig near know issue finish cream give electric wide tag range";
                    Console.WriteLine($"Mnemonic: {words}");

                    var seed = Mnemonic.MnemonicToSeed(words);
                    Console.WriteLine($"Seed: {seed.ToHexString()}");

                    var btc = Mnemonic.SeedToWPF(seed, 0);
                    var neo = Mnemonic.SeedToWPF(seed, 888);
                    var ont = Mnemonic.SeedToWPF(seed, 1024);
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
