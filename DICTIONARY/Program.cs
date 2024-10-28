using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DICTIONARY
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,string> dic = new Dictionary<string,string>();
            dic.Add("BOOK", "kitap");
            dic.Add("glass", "bardak");

            Console.WriteLine(dic["BOOK"]); // KARŞILIĞI NE İSE SÖZLÜK ANLAMI NE İSE O DÖNER YANİ ÇIKTIDA KİTAP DÖNECEK.

            foreach (var key in dic)
            {
                Console.WriteLine(key.Key); //book,glass
                Console.WriteLine(key.Value); //KİTAP BARDAK
            }
            Console.ReadLine();
        }
    }
}
