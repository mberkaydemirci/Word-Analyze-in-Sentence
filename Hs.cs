using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesneOdev3
{
    class Hs<T> : HashSet<string>
    {
        public void HsAdd(string[] word,Hs<string>hs1)
        {
            for (int i = 0; i < word.Length; i++)
            {
                hs1.Add(word[i]);
            }
        }
        public string[] HsDisplay(HashSet<string> hs1)
        {
            int i = 0;
            string[] hs2 = new string[hs1.Count];
            foreach (string item in hs1)
            {
                hs2[i] = item;
                try { Console.WriteLine(item); }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                i++;
            }
            return hs2;
        }
    }
}
