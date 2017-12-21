using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MexicanWaveKata
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void String_a_Return_A()
        {
            var expected = new List<string>{"A"};
            var actual = MexicanWave.WaveString("a");
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void String_aa_Return_Aa_aA()
        {
            var expected = new List<string> { "Aa", "aA" };
            var actual = MexicanWave.WaveString("aa");
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void String_ab_Return_Ab_aB()
        {
            var expected = new List<string> { "Ab", "aB" };
            var actual = MexicanWave.WaveString("ab");
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void String_abcd_Return_Abcd_aBcd_abCd_abcD()
        {
            var expected = new List<string> { "Abcd", "aBcd", "abCd", "abcD" };
            var actual = MexicanWave.WaveString("abcd");
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void String_hi_world()
        {
            var expected = new List<string> { "Hi word", "hI word" ,"hi Word", "hi wOrd", "hi woRd", "hi worD" };
            var actual = MexicanWave.WaveString("hi word");
            CollectionAssert.AreEqual(expected, actual);
        }
    }
    public class MexicanWave
    {
        //1.  The input string will always be lower case but maybe empty.

        //2.  If the character in the string is whitespace then pass over it as if it was an empty seat.
        public static List<string> WaveString(string input)
        {
            var outputString = new List<string>();

            foreach (var character in input.Select((value, index) => new { value, index }))
            {
                if (character.value != ' ')
                {
                    StringBuilder sb = new StringBuilder(input);
                    sb[character.index] = (Char.ToUpper(sb[character.index]));
                    outputString.Add(sb.ToString());
                }
  
            }
           
            return outputString;
        }
    }
}
