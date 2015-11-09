using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

/** PROBLEM STATEMENT
* https://community.topcoder.com/stat?c=problem_statement&pm=3520
*/

namespace TopCoderChallenges.Categories.StringManipulation
{
    [TestClass]
    public class ClientsList
    {

        public string[] DataCleanUp(string[] arr)
        {
            
            IList<Client> inputs = new List<Client>();
            foreach (string arrs in arr)
            {
                inputs.Add(new Client(arrs));
            }

            List<Client> l = inputs.ToList();
            l.Sort();

            return l.Select(x => x.ToString()).ToArray();
        }


        [TestMethod]
        public void TestMethod()
        {
            Assert.IsTrue(DataCleanUp(new string[] { "Joe Smith", "Brown, Sam", "Miller, Judi" }).SequenceEqual(new string[] { "Sam Brown", "Judi Miller", "Joe Smith" }));
            Assert.IsTrue(DataCleanUp(new string[] { "Campbell, Phil", "John Campbell", "Young, Warren" }).SequenceEqual(new string[] { "John Campbell", "Phil Campbell", "Warren Young" }));
        }


    }


    class Client : IComparable
    {
        private string lastName;
        private string firstName;

        public Client(string raw)
        {
            if (raw.IndexOf(",") >= 0)
            {
                string[] parts = raw.Split(',');
                firstName = parts[parts.Length - 1].Trim();
                lastName = parts[0].Trim();
            }
            else
            {
                string[] parts = new Regex(@"\s+").Split(raw);
                lastName = parts[parts.Length - 1].Trim();
                firstName = parts[0].Trim();
            }
        }

        public override string ToString()
        {
            return firstName + " " + lastName;
        }

        public int CompareTo(object obj)
        {
            int i = this.lastName.CompareTo(((Client)obj).lastName);
            return i == 0 ? this.firstName.CompareTo(((Client) obj).firstName) : i;
        }
    }

}
