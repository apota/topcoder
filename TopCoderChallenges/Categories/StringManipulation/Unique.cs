using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;


/**  PROBLEM STATEMENT
* https://community.topcoder.com/stat?c=problem_statement&pm=13067
*/

namespace TopCoderChallenges.Categories.StringManipulation
{
    [TestClass]
    public class Unique 
    {
        public string DoIt(string input)
        {
            HashSet<char> charSet = new HashSet<char>();
            char[] arr = input.ToCharArray();
            StringBuilder sb = new StringBuilder();
            foreach (char inputc in arr)
            {
                if (!charSet.Contains(inputc))
                {
                    charSet.Add(inputc);
                    sb.Append(inputc);
                }
            }
            return sb.ToString();
        }


        [TestMethod]
        public void Test()
        {

            string[] inputs = new string[] {"banana", "aardvark", "xxxxx", "topcoder"};
            string[] outputs = new string[] { "ban", "ardvk", "x", "topcder" };

            for (int i = 0; i < inputs.Length; ++i)
            {
                Assert.AreEqual(DoIt(inputs[i]), outputs[i]);
            }
        }

    }
}
