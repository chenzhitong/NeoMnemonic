using Neo;
using System;
using System.Collections.Generic;

namespace NeoMnemonic
{
    class Program
    {
        static void Main(string[] args)
        {
            //while (true)
            //{
            //    try
            //    {
            //        var words = Mnemonic.GenerateMnemonic();
            //        Console.WriteLine($"Mnemonic: {words}");

            //        var seed = Mnemonic.MnemonicToSeed(words);
            //        Console.WriteLine($"Seed: {seed.ToHexString()}");

            //        var btc = Mnemonic.SeedToWIF(seed, 0);
            //        var neo = Mnemonic.SeedToWIF(seed, 888);
            //        var ont = Mnemonic.SeedToWIF(seed, 1024);
            //        Console.WriteLine($"BTC WIF: {btc}");
            //        Console.WriteLine($"NEO WIF: {neo}");
            //        Console.WriteLine($"ONT WIF: {ont}");
            //    }
            //    catch (Exception e)
            //    {
            //        Console.WriteLine($"Error: {e.Message}");
            //    }

            //    Console.ReadLine();
            //}

            var words = "decrease horror keen muffin certain peace lemon mind click nuclear father apart will rebel media frost wire clay key width repeat random duty cube";
            var seed = Mnemonic.MnemonicToSeed(words);
            Console.WriteLine($"Seed: {seed.ToHexString()}");

            var addr = Mnemonic.SeedToNeoAddress(seed);
            Console.WriteLine($"Address: {addr}");

            var addr2 = Mnemonic.SeedToNeoAddress2(seed);
            Console.WriteLine($"Address: {addr2}");

            if (addr == "NWHpGSgogdm8EWyhasV7DKJnsW6CvrSEnd" || addr2 == "NWHpGSgogdm8EWyhasV7DKJnsW6CvrSEnd")
            {
            }
            //WIF Kypb4z3uevxYhE4M2gLByc2cmjq14d3jbkFMXkMH6CzNgUtwTTN1
            //Address NWHpGSgogdm8EWyhasV7DKJnsW6CvrSEnd
        }
    }
}
