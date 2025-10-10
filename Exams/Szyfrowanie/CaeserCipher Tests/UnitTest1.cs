using Microsoft.VisualStudio.TestPlatform.TestHost;
using Cezary;

namespace CaeserCipher_Tests
{
    public class UnitTest1
    {
        [Fact]
        public void kluczDodatniWartoscMniejszaOdDlugosciAlfabetu()
        {
            string toCode = "abc";
            int key = 3;
            string expected = "def";

            string result = Cezary.Program.Cezar(toCode, key);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void gdyliterywtekœcieikluczwychodz¹pozaalfabet()
        {
            string toCode = "xyz";
            int key = 3;
            string expected = "abc";

            string result = Cezary.Program.Cezar(toCode, key);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void zNegatywnymKluczem()
        {
            string toCode = "def";
            int key = -3;
            string expected = "abc";

            string result = Cezary.Program.Cezar(toCode, key);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void kluczWiekszyNizDlugoscAlfabetu()
        {
            string toCode = "abc";
            int key = 29;
            string expected = "def";

            string result = Cezary.Program.Cezar(toCode, key);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void zeSpacjaWTekscie()
        {
            string toCode = "ab cd";
            int key = 2;
            string expected = "cd ef";

            string result = Cezary.Program.Cezar(toCode, key);

            Assert.Equal(expected, result);
        }
    }
}