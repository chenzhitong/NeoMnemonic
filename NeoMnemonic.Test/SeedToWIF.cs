using Microsoft.VisualStudio.TestTools.UnitTesting;
using Neo;
using System;
using System.Collections.Generic;
using System.Text;

namespace NeoMnemonic.Test
{
    [TestClass]
    public class SeedToWIF
    {
        [TestMethod]
        public void Validation3()
        {
            var seed = "a497456235972d1be5db9d16ce756b23328ac510b88ae75c4bf8c950cee2c6a8388ca8d2f134e53cf02ce1a5dcca8394763df0de9284167eef0ae7c00f4b2b21".HexToBytes();
            var wif = Mnemonic.SeedToWIF(seed);
            Assert.AreEqual(wif, "KxrD3F41z8qK6HY1abXvog7mnLTNjusU2nEYwe1xyG6rhHwiSZwd");
        }
        [TestMethod]
        public void Validation5()
        {
            var seed = "d37e5c6a4bd7db4c381d7411f8d2cc453f7b3cb773d18db011227618f7d7845fa4ba7f0977ac3c7e05b7dfc8ab27723a1a674053a689d759ec1e1a9846f0ad67".HexToBytes();
            var wif = Mnemonic.SeedToWIF(seed);
            Assert.AreEqual(wif, "L1W8cyRdUS3BykE2M5bR2wcB9uCC3KJEQSmXkTqEyKTSZL7TMAPW");
        }
        [TestMethod]
        public void Validation6()
        {
            var seed = "1ca645391a13c4c7c55c555f65a2b227bae9fd39e9a15e857bacd6689491cb9e2ac63cc865570673f123d8ea8a77bbbab14e4bbf413da0b23ab2259f200c12c2".HexToBytes();
            var wif = Mnemonic.SeedToWIF(seed);
            Assert.AreEqual(wif, "Ky86DjDupmfH7yHpAQBWgJgqHCxqAqhZJjDtCDXHj28UtMFDCVQ1");
        }
    }
}
