using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace NeoMnemonic.Test
{
    [TestClass]
    public class Validation
    {
        [TestMethod]
        public void Validation1()
        {
            for (int i = 0; i < 10; i++)
            {
                Assert.IsTrue(Mnemonic.Verification(Mnemonic.GenerateMnemonic()));
            }
        }
    }
}
