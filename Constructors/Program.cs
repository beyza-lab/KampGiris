using System;

namespace Constructors//bir class ilk kez olusturdugumuzda bır kere calısır ve bir daha çalışmaz dediğiğmiz blok
{//Yapıcı blok
    class Program
    {
        static void Main(string[] args)
        {
            Custormer custormer = new Custormer() { Id = 3, FirstName = "beyza", LastName="özlük", City="Ankara" };//classı newlwdim bir ornek oluşturduk
            //yukarıdaki yazım şekli sununla yanı demek
            //custormer.Id = 3;
            //aşağıdaki gibi bir kullanımda mevcut
            Custormer custormer1 = new Custormer(3, "engin", "demiroğ", "ankara");//sanki bir fonksiyonmuş gibi
                                                                                  //normal parantez görörsen metot mantığı var demektir.
                                                                                  //bu şekilde kullanmka istiyorsam o parametleri constructura geçmem gerek


            //iki türlüde kullanka itiyorsam overloading bir tane ctor constructor yapısı olacak

            Console.WriteLine(custormer1.FirstName); //okuyamadım cünkü construc da parametrelerde ctor olan bolum çalısır
        }
    }

    class Custormer
    {

        public Custormer()//parametresi olmayan constructura defult const denır
        {

        }
        //metot parametleri camel case kucukharf basşar
        public Custormer(int id ,string firstName, string lastName, string city) //ctor tab tab default constructur
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;




            Console.WriteLine("yapıcı blok calıstı");
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        //classlar pascal case metotlar camel case ilk harfi küçük
    }

    //  





}









