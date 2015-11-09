using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;


/** PROBLEM STATEMENT
* https://community.topcoder.com/stat?c=problem_statement&pm=2242
*/


namespace TopCoderChallenges.Categories.StringManipulation
{
    [TestClass]
    public class CodeRed
    {
        private string redRegex = @"red";
        public string Count(string input)
        {
            if (String.IsNullOrEmpty(input)) return "0";
            return Regex.Matches(input, redRegex, RegexOptions.IgnoreCase).Count.ToString();
        }

        [TestMethod]
        public void Test()
        {
            Assert.AreEqual(Count("the detective questioned his credibility"), 1);
            Assert.AreEqual(Count("Server ERRED in Redirecting Spam"), 2);
            Assert.AreEqual(Count("  read the RED sign   said fReD"), 2);
            Assert.AreEqual(Count("pure delight"), 0);
            Assert.AreEqual(Count("re"), 0);
        }

        
    }
}
