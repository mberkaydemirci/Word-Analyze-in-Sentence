using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace NesneOdev3
{
    class Program
    {
        static void Main(string[] args)
        {
            TextList<string> list1 = new TextList<string>();
            try
            {
                Console.WriteLine("1.Metini Giriniz:");
                string temp = Console.ReadLine();
                temp = temp.ToLower();
                list1.Add(temp);
                Console.WriteLine("2.Metini Giriniz:");
                temp = Console.ReadLine();
                temp = temp.ToLower();
                list1.Add(temp);
                Console.WriteLine("3.Metini Giriniz:");
                temp = Console.ReadLine();
                temp = temp.ToLower();
                list1.Add(temp);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            TextList<string>.Display(list1);
            string[] word = list1.WordSeparation(list1);
            try { Console.WriteLine("Toplam Sozcuk Sayisi:" + word.Length + "\n"); }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Hs<string> hs1 = new Hs<string>();
            hs1.HsAdd(word,hs1);
            string[] hs2 = hs1.HsDisplay(hs1); // istenirse hashsetteki elemanlar bu fonksiyon ile yazdırılabilir
            try { Console.WriteLine("Farklı Kelime Sayisi: " + hs1.Count); }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            int[] frekans = list1.WordFrequency(word);
            Table<string, int> mytable = new Table<string, int>();
            Table<string, int>.TableAdd(list1,hs1,hs2,mytable); //
            Console.ReadLine(); //konsolun açık kalması
        }
    }
}
