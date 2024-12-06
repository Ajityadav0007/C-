using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class pro123

    {
        public static void Main()
        {
            DictnaoryCollection d = new DictnaoryCollection();
        }

        internal class DictnaoryCollection
        {
            public DictnaoryCollection()
            {
                Console.WriteLine("****Dictonary Implimentation******");
                Dictionary<string, int> n = new Dictionary<string, int>();

                n.Add("Ajit", 101);
                n.Add("Amit", 102);
                n.Add("Adi", 103);

                Console.WriteLine("All Element In Dictonary");

                foreach (KeyValuePair<string, int> item in n)
                {

                    Console.WriteLine($"{item.Key}:{item.Value}");

                }



                object k = n.Remove("Ajit");

                Console.WriteLine();

                Console.WriteLine("Updated Dictonary After Remove Operation Perform:=");
                foreach (KeyValuePair<string, int> item1 in n)
                {
                    Console.WriteLine(item1);

                }



                Console.WriteLine();


                var Filter = n.Where(x => x.Key.Contains("Ajit")).ToDictionary(x => x.Key, x => x.Value);

                Console.WriteLine("Filter Dictonary=");

                foreach (var pair in n)
                {

                    Console.WriteLine($"key={pair.Key},value={pair.Value}");



                }

                n.Clear();

                Console.WriteLine();


                if (n.Count == 0)
                {

                    Console.WriteLine("Dictory IsEmpty=True");

                }
                else { Console.WriteLine("Dictory IsEmpty=False"); }







            }

        }
    }
}
