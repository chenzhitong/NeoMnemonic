using Neo;
using System;
using System.Collections.Generic;

namespace NeoMnemonic
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = "machine kingdom into guitar term ensure armed trap language smooth crouch pen";
            var seed = Mnemonic.MnemonicToSeed(words);
            Console.WriteLine($"Seed: {seed.ToHexString()}");

            var addr = Mnemonic.SeedToNeoAddress(seed);
            Console.WriteLine($"Address: {addr}");

            //machine kingdom into guitar term ensure armed trap language smooth crouch pen
            //NYbmuR4S2qbVxjQBkSNEJba54Xgui7HS7r

            //decrease horror keen muffin certain peace lemon mind click nuclear father apart will rebel media frost wire clay key width repeat random duty cube
            //WIF Kypb4z3uevxYhE4M2gLByc2cmjq14d3jbkFMXkMH6CzNgUtwTTN1
            //Address NWHpGSgogdm8EWyhasV7DKJnsW6CvrSEnd
        }
    }
}
