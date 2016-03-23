﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Code.Strings;

namespace UnitTests
{
    [TestClass]
    public class StringTest
    {
        [TestMethod]
        public void IsPalindrome()
        {
            Assert.IsTrue(Palindrome.IsPalindrome("1234321".ToCharArray()));
        }

        [TestMethod]
        public void IsBinaryPalindrome()
        {
            Assert.IsTrue(Palindrome.IsPalindrome(9));
            Assert.IsFalse(Palindrome.IsPalindrome(10));
        }


        [TestMethod]
        public void RemoveDupsTest()
        {
          char[] input = "abbefeg".ToCharArray();   
          StringDuplicates.RemoveDuplicates(input);
          var resultString = new string(input);
          resultString = resultString.Substring(0, resultString.IndexOf('0'));
          Assert.AreEqual("abefg", resultString); 
        }

        [TestMethod]
        public void RemoveDupsTest2()
        {
            char[] input = "ttt".ToCharArray();
            StringDuplicates.RemoveDuplicates(input);
            var resultString = new string(input);
            resultString = resultString.Substring(0, resultString.IndexOf('0'));
            Assert.AreEqual("t", resultString);
        }
    }
}
