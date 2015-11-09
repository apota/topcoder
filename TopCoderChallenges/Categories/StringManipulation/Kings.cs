using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;


/** PROBLEM STATEMENT
* https://community.topcoder.com/stat?c=problem_statement&pm=7607
*/

namespace TopCoderChallenges.Categories.StringManipulation
{
    [TestClass]
    public class Kings
    {
        public string[] DoIt(string[] inputs)
        {
            string[] outputs = new string[inputs.Length];
            Array.Copy(inputs, outputs, inputs.Length);

            Dictionary<string, List<int>> map = new Dictionary<string, List<int>>();
            for (int i = 0; i < inputs.Length; ++i)
            {
                List<int> indices;
                if (!map.TryGetValue(inputs[i], out indices))
                {
                    indices = new List<int>();
                }
                indices.Add(i);
                map[inputs[i]] = indices;
            }

            foreach (KeyValuePair<string, List<int>> pair in map)
            {
                List<int> indices = pair.Value;
                if (indices.Count < 2) continue;
                for (int k = 0; k < indices.Count; ++k)
                {
                    int j = k + 1;
                    outputs[indices[k]] = String.Format("{0} {1}", outputs[indices[k]], j);
                }
            }

            return outputs;
        }




        [TestMethod]
        public void Test()
        {

            Assert.IsTrue(DoIt(new string[] {"WILLIAM", "GEORGE", "PAUL", "GEORGE", "GEORGE", "WILLIAM"}).SequenceEqual(new string[] {"WILLIAM 1", "GEORGE 1", "PAUL", "GEORGE 2", "GEORGE 3", "WILLIAM 2"}));


            Assert.IsTrue(DoIt(new string[]
            {
                "OLE", "BJORN", "OLE", "GUNNAR", "LUDVIG", "CHRISTIAN", "LUDWIG",
                "KARL", "CHRISTIAN", "LUDWIG"
            }).SequenceEqual(
                new string[]
                {
                    "OLE 1",
                    "BJORN",
                    "OLE 2",
                    "GUNNAR",
                    "LUDVIG",
                    "CHRISTIAN 1",
                    "LUDWIG 1",
                    "KARL",
                    "CHRISTIAN 2",
                    "LUDWIG 2"
                }));


            Assert.IsTrue(DoIt(new string[]

            {
                "BOB", "BOB", "BOB", "BOB", "BOB", "BOB", "BOB", "BOB", "BOB",
                "BOB", "BOB", "BOB", "BOB", "BOB", "BOB", "BOB", "BOB", "BOB",
                "BOB", "BOB", "BOB", "BOB", "BOB", "BOB", "BOB", "BOB", "BOB",
                "BOB", "BOB", "BOB", "BOB", "BOB", "BOB", "BOB", "BOB", "BOB",
                "BOB", "BOB", "BOB", "BOB", "BOB", "BOB", "BOB", "BOB", "BOB",
                "BOB", "BOB", "BOB", "BOB", "BOB"
            }
                ).SequenceEqual(
                new string[]
                {
                    "BOB 1",
                    "BOB 2",
                    "BOB 3",
                    "BOB 4",
                    "BOB 5",
                    "BOB 6",
                    "BOB 7",
                    "BOB 8",
                    "BOB 9",
                    "BOB 10",
                    "BOB 11",
                    "BOB 12",
                    "BOB 13",
                    "BOB 14",
                    "BOB 15",
                    "BOB 16",
                    "BOB 17",
                    "BOB 18",
                    "BOB 19",
                    "BOB 20",
                    "BOB 21",
                    "BOB 22",
                    "BOB 23",
                    "BOB 24",
                    "BOB 25",
                    "BOB 26",
                    "BOB 27",
                    "BOB 28",
                    "BOB 29",
                    "BOB 30",
                    "BOB 31",
                    "BOB 32",
                    "BOB 33",
                    "BOB 34",
                    "BOB 35",
                    "BOB 36",
                    "BOB 37",
                    "BOB 38",
                    "BOB 39",
                    "BOB 40",
                    "BOB 41",
                    "BOB 42",
                    "BOB 43",
                    "BOB 44",
                    "BOB 45",
                    "BOB 46",
                    "BOB 47",
                    "BOB 48",
                    "BOB 49",
                    "BOB 50"
                }
                ))
                ;
        }
    }
}