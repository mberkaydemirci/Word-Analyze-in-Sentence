using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesneOdev3
{
    class Table<TKey,Tvalue>: Dictionary<string,int> //dictionary sınıfından oluşturulmuş table 
    {
        public static void TableAdd(TextList<string> list1,Hs<string> hs1,string[] hs2,Table<string,int> mytable) //,Table<string,int> mytable
        {
            string[] word = list1.WordSeparation(list1);
            int[] frequency = list1.WordFrequency(word);
            string[] h3 = new string[hs1.Count];
            for (int i = 0; i < hs1.Count; i++)
            {              
                for (int j = 0; j < word.Length; j++)
                {
                    if (h3[i] == word[j]) break;
                    if (hs2[i] == word[j])
                    {
                        h3[i] = hs2[i];
                        mytable.Add(hs2[i], frequency[j]);
                        try { Console.WriteLine(hs2[i] + ":\t" + mytable[hs2[i]]); }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                    }
                        
                }
                
                
            }
            int maxValue = frequency.Max();
            int maxIndex = frequency.ToList().IndexOf(maxValue);
            try { Console.WriteLine("En sık kullanılan sözcük : " + hs2[maxIndex] + "\n" + 
                "En sık kullanılan sözcüğün frekansı: " + maxValue); }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        
    }
}
