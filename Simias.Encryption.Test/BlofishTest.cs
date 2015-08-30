using NUnit.Framework;

namespace Simias.Encryption.Test
{
    [TestFixture]
    public class BlofishTest
    {
        private string salt = "{C42B9D23-F6F8-4AAA-8D1E-00F3A488A507}";
        private string value = "Test";
        private string encrypted = "J5APsWH6FOs=";

        [TestCase]
        public void EncryptString()
        {
            Blowfish blowfish = new Blowfish(salt);
            Assert.AreEqual(blowfish.Encipher(value), encrypted);
        }
        [TestCase]
        public void DecryptString()
        {
            Blowfish blowfish = new Blowfish(salt);
            Assert.AreEqual(blowfish.Decipher(encrypted), value);
        }
    }
}
