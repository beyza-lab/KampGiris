using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //ctrl+k+c komple comment yapar ctrl+k+u uncomment yapar
            ////eşitliğin sol tarafı stackte olur isimler
            //string[] isimler = new string[] {"engin", "murat","kerem", "halil" };
            //// sağ tarafında heapte 4 elamanlı bir dizi oluşturdu
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);
            ////isimlerin adresi yeni bir adrese geçti
            //isimler = new string[5];
            //isimler[4] = "ilker";
            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[0]);//bos kalacak cunku 5 elemanlı yeni bir dizi tanımlamıs olduk
            ////dizileri genişletemeyiz böylece


            //list secili iken usingi ekledim
            List<string> isimler2 = new List<string>() { "engin", "murat", "kerem", "halil" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            //yeni bir eleman ekleyelim //değerleri kaybetmememizi engeller list
            isimler2.Add("ilker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);


            




        }
    }
}
