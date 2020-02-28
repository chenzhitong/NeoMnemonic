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

        [TestMethod]
        public void Validation2()
        {
            Assert.IsTrue(Mnemonic.Verification("spawn tomorrow nurse ring thank hen ritual bracket purity junk coyote all wait pig near know issue finish cream give electric wide tag range"));
        }
        [TestMethod]
        public void Validation3()
        {
            Assert.IsTrue(Mnemonic.Verification("tortoise security screen orange trust system fatal relief party warfare universe drastic siren night budget mercy able where found mention clock collect isolate sea"));
        }
        [TestMethod]
        public void Validation4()
        {
            Assert.IsTrue(Mnemonic.Verification("rigid double snake push unveil panic frown monitor possible stem tourist enact paper sun derive addict auto attend coconut panel humor mad echo yard"));
        }
        [TestMethod]
        public void Validation5()
        {
            Assert.IsTrue(Mnemonic.Verification("dynamic balance visa embody camera pear segment inhale local genius else pill happy skirt vocal garbage lab decline acquire accuse foster exercise because april"));
        }
        [TestMethod]
        public void Validation6()
        {
            Assert.IsTrue(Mnemonic.Verification("guilt middle great glass sauce devote laundry marble wonder soap life awful cave clever define lottery carpet way pig caught artefact east breeze kitchen"));
        }
        [TestMethod]
        public void Validation7()
        {
            Assert.IsTrue(Mnemonic.Verification("flee glove dose type file glance inherit weird guilt rib spend pottery lion depth fiction"));
        }
        [TestMethod]
        public void Validation8()
        {
            Assert.IsTrue(Mnemonic.Verification("push alarm hole monkey year thought angry slot safe spare rough trophy music amazing spare borrow boy quiz"));
        }
        [TestMethod]
        public void Validation9()
        {
            Assert.IsTrue(Mnemonic.Verification("jelly join dismiss attitude pond alien rigid whale giant shock sniff organ reunion onion cause isolate color raise estate vicious intact"));
        }
        [TestMethod]
        public void Validation10()
        {
            Assert.IsTrue(Mnemonic.Verification("jelly join dismiss attitude pond alien rigid whale giant shock sniff organ reunion onion cause isolate color raise estate vicious intact"));
        }
    }
}
