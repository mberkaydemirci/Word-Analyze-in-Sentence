using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesneOdev3
{
    public class TextList<T> : List<T>
    {
        public static void Display(TextList<T> list1)
        {
            for (int i = 0; i < list1.Count; i++)
            {
                try { Console.WriteLine(list1[i]); }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
        public string[] WordSeparation(TextList<T> list1)
        {
            string sentence = "";
            for (int i = 0; i <list1.Count; i++)
            {
                sentence += Convert.ToString(list1[i]);
                if (i < list1.Count - 1)
                {
                   sentence += " "; //elemanların sonuna boşluk koydum çünkü sözcük sayisini düzgün bulmak için
                }                
            }
            char[] ayrac = { ' ' };
            sentence = sentence.Replace("!","");
            sentence = sentence.Replace("?","");
            sentence = sentence.Replace(".","");
            string[] word=sentence.Split(' ');
            return word;
         }
         
        public void WordDisplay(string[] word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                try { Console.WriteLine(word[i]); }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
        public int[] WordFrequency(string[] word)
        {           
            string[] word2 = new string[word.Length];
            ArrayList tempfrequency = new ArrayList();
            int count = 0;
            for (int i = 0; i < word.Length; i++)
            {
                 word2[i]= word[i];
            }
            for (int i = 0; i < word.Length; i++)
            {
                count = 0;
                for (int j = 0; i < word2.Length; j++)
                {
                    if (word2[i] == word[j])
                  {
                        count++;                       
                  }
                    if (j == (word2.Length-1)) break;
                }
                tempfrequency.Add(count);
            }
            int[] frequency = new int[tempfrequency.Count];
            for (int i = 0; i < frequency.Length; i++)
            {
                frequency[i] = (int)tempfrequency[i];
            }
            return frequency;
        }


    }
}
