using System;
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
                var words = Mnemonic.GenerateMnemonic();
                Console.WriteLine("Mnemonic: " + words);
                var seed = Mnemonic.MnemonicToSeed(words);
                Console.WriteLine("SEED: " + seed.ToHexString());
                var masterkey = Mnemonic.SeedToPrivateKey(seed);
                var account = new Neo.Wallets.KeyPair(masterkey);
                var address = Neo.SmartContract.Contract.CreateSignatureContract(account.PublicKey).Address;
                Console.WriteLine("WIF: " + account.Export());
                Console.WriteLine("Addr.: " + address);
                Console.ReadLine();
            }
        }
    }
}
