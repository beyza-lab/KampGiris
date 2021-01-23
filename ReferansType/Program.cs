using System;

namespace ReferansType
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 20;
            sayi1 = sayi2; //sayi1 ın değeri eşittir sayı 2 nın değeri
            sayi2 = 100;

            Console.WriteLine("sayı 1 :" + sayi1);

            //int, decimal, float,boolean,enum sayısal değişkenler değer tiptir.(value type)
            //değer tipler sadece stackte olusuyor.

            int[] sayilar1 = new int[] { 1, 2, 3 };
            int[] sayilar2 = new int[] { 10, 20, 30 };
            sayilar1 = sayilar2;//sayılar1 ın adresi eşittir sayılar 2 nın adresi
            sayilar2[0] = 1000;
            Console.WriteLine("sayilar1[0] :" + sayilar1[0]);

            //array,class,ınterface referans typetır.
            //referans tiplerde belleğin heap denen kısmı devreye giriyor.

            Person person1 = new Person();//Nesneler Yeni anahtar sözcüğü kullanılarak, ardından nesnenin temel aldığı sınıfın adı tarafından oluşturulabilir ve şöyle olur
            Person person2 = new Person();

            person1.FirstName = "engin";
            person2 = person1;
            person1.FirstName = "emre";
            Console.WriteLine(person2.FirstName);



            Customer customer = new Customer();
         
            
            Employee employee = new Employee();
           
        



        }

        class Person
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

           
        }
    }
         class Customer

            {
        public string CreditNumber { get; set; }
        public string FirstName { get; internal set; }
    }
    class Employee
    {
        public int EmployeeNumber { get; set; }
    }
}

