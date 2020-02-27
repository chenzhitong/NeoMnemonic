using Microsoft.VisualStudio.TestTools.UnitTesting;
using Neo;

namespace NeoMnemonic.Test
{
    [TestClass]
    public class MnemonicToSeed
    {
        [TestMethod]
        public void MnemonicToSeed1()
        {
            var seed = Mnemonic.MnemonicToSeed("federal raccoon indoor family hello garage amazing small middle gospel thrive main");
            Assert.AreEqual(seed.ToHexString(), "a453dda6729cf652bf469e2a88cf2cf69404d0ef718282fd5808256842a3ae7e4cc92d8d7ac26ca0050097f8105f127397dc4c77e8da9cfad198510717e3f106");
        }
        [TestMethod]
        public void MnemonicToSeed2()
        {
            var seed = Mnemonic.MnemonicToSeed("test cruise rely brand crazy spoon soda flee congress spawn lady curious");
            Assert.AreEqual(seed.ToHexString(), "c7a91f4aa3ace1425881cf36abb74304361e4a22c8ea43af93898d635e3af71f938834279085d7227842af39de613bbc20a34ab5d6bc077de051c53cf909a1ae");
        }
        [TestMethod]
        public void MnemonicToSeed3()
        {
            var seed = Mnemonic.MnemonicToSeed("mother cube profit raise flower boost nest caught grid grit west car predict best local");
            Assert.AreEqual(seed.ToHexString(), "78ba97e24e9dded92d774f950bf7e16f1dfbab14ccd21ce1e16a168ecfd120b3891e443a44c1aad6e9cfad98534adb9e06a5ff93a32d5fbb6c3211ba0bc4ef3e");
        }
        [TestMethod]
        public void MnemonicToSeed4()
        {
            var seed = Mnemonic.MnemonicToSeed("´¢ ÌÝ °ü Ã¿ Àý ¼ü Ä¿ ¶® ·ñ ²Á ÁÑ Ö­ ³¦ ´Î ²Ý");
            Assert.AreEqual(seed.ToHexString(), "b4968e1c72c167616eca51c153a8efbd69c17121f20aa025e2655ed05f91ea0d9072983edf91e24f9444e5fe9b6038f1793f647890c69adfd969ad8723e80271");
        }
        [TestMethod]
        public void MnemonicToSeed5()
        {
            var seed = Mnemonic.MnemonicToSeed("¹· ñT Ùe ˆF Áï û| ·´ Ê³ ºé ŠA ¼{ À@ žI ½ª •³");
            Assert.AreEqual(seed.ToHexString(), "d54cf5f67cb5afcaa6eb272bcc4472c83cf77d11777205f4628abfe63dfb5b6e587a1740f22aa685e59e76e30e7f914acad2c6896305cb0d6810929339e37ecf");
        }
        [TestMethod]
        public void MnemonicToSeed6()
        {
            var seed = Mnemonic.MnemonicToSeed("inform sound same powder prepare either hurry marriage soldier cable tackle unlock nerve manage custom monitor decade range");
            Assert.AreEqual(seed.ToHexString(), "a497456235972d1be5db9d16ce756b23328ac510b88ae75c4bf8c950cee2c6a8388ca8d2f134e53cf02ce1a5dcca8394763df0de9284167eef0ae7c00f4b2b21");
        }
        [TestMethod]
        public void MnemonicToSeed7()
        {
            var seed = Mnemonic.MnemonicToSeed("minimum object enforce trim kid umbrella theory urge axis dawn bitter host copy shine remain lyrics valid fee");
            Assert.AreEqual(seed.ToHexString(), "fa959e6aa4ea3bdc309b7bad3c4bfa3755bc9cf572a774fd4a997f367f68795b4b502d36979e9eef442fc30d64ff8b05cdee8e0077d90336496e66e4667a9e2d");
        }
    }
}
