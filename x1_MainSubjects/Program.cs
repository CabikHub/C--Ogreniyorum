using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace x1_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region YazdırmaKomutları

            //Console.Write("Merhaba Dünya");
            //Console.WriteLine("Selam");

            //Console.WriteLine(" ****** Yemek Kategorileri ***** ");
            //Console.WriteLine();
            //Console.WriteLine("*1-Çorbalar*");
            //Console.WriteLine("*2-Ana Yemekler*");
            //Console.WriteLine("*3-Soğuk Başlangıçlar*");
            //Console.WriteLine("*4- Salatalar*");
            //Console.WriteLine("*5- Tatlılar*");
            //Console.WriteLine("*6- İçecekler*");
            //Console.WriteLine();
            //Console.WriteLine(" ****** Yemek Kategorileri ***** ");
            //Console.Read();

            #endregion


            #region String Değişkenler

            // string
            // Değişkenin_türü değişken_adı;

            //string name;
            //name = "Emirhan";
            //Console.Write(name);

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;

            //customerName = "Emirhan";
            //customerSurname = "Çabık";
            //customerPhone = "+90 544 247 52 65";
            //customerEmail = "deneme@gmail.com";
            //district = "Kadıköy";
            //city = "İstanbul";

            //Console.WriteLine("***** Rezervasyon Kartı *****");
            //Console.WriteLine();
            //Console.WriteLine("--------------------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email Adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("--------------------------------------------------");

            //customerName = "Ayşegül";
            //customerSurname = "Kaya";
            //customerEmail = "aysegul31@gmail.com";
            //customerPhone = "+90 400 300 20 70";
            //district = "Sapanca";
            //city = "Sakarya";
            
            //Console.WriteLine("--------------------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email Adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("--------------------------------------------------");

            //Console.WriteLine();

            #endregion

            #region Int Değişkenler


            // int
            // int number = 24;
            // Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("**** Restoran Menü Fiyatı ****");
            Console.WriteLine();
            Console.WriteLine("------Kola: " + cokePrice +"TL");
            Console.WriteLine("------Hamburger: " + hamburgerPrice + "TL");
            Console.WriteLine("------Su: " + waterPrice + "TL");
            Console.WriteLine("------Patates Kızartması: " + friesPrice + "TL");
            Console.WriteLine("------Pizza: " + pizzaPrice + "TL" );
            Console.WriteLine("------Limonata: " + lemonadePrice + "TL");
            Console.WriteLine();
            Console.WriteLine("**** Restoran Menü Fiyatı ****");


            Console.WriteLine();
            int hamburgerCount;
            int cokeCount; 
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            int totalHamburgerPrice;
            int totalCokePrice;
            int totalWaterPrice;
            int totalFriesPrice;
            int totalPizzaPrice;
            int totalLemonadePrice;

            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            friesCount = 1;
            pizzaCount = 0;
            lemonadeCount = 0;



            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            totalFriesPrice = friesCount * friesPrice;
            totalCokePrice = cokeCount * cokePrice;
            totalWaterPrice = waterCount * waterPrice;  
            totalPizzaPrice = pizzaCount * pizzaPrice;
            totalLemonadePrice = lemonadePrice * lemonadePrice;
           
            

            Console.WriteLine( "------------------------------------");
            Console.WriteLine("Hamburger Tutarı: " + totalHamburgerPrice + "TL") ;
            Console.WriteLine("Pizza Tutarı: " + totalPizzaPrice + "TL") ;
            Console.WriteLine("Patates Kızartması: " + totalFriesPrice+ "TL") ;
            Console.WriteLine("Limonata Tutarı: " + totalLemonadePrice + "TL") ;
            Console.WriteLine("Su Tutarı: " + totalWaterPrice + "TL") ;
            Console.WriteLine("Kola Tutarı: " + totalCokePrice + "TL") ;

            Console.WriteLine();

            int totalPrice = totalCokePrice + totalWaterPrice + totalFriesPrice+ totalHamburgerPrice + totalPizzaPrice + totalLemonadePrice;
            Console.WriteLine("Toplam Ödenecek Tutar: " + totalPrice + "TL");
            #endregion

            Console.Read();


        } 

    }
}

 


// Yazdırma Komutları