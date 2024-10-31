using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace x2_Variables__Degiskenler_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Double Değişkenler
            //double number;

            //number = 4.258;

            //Console.WriteLine(number);

            //Console.WriteLine( "***** Fiyat Listesi *****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice,tomatoPrice, potatoPrice;

            //applePrice = 14.55;
            //orangePrice = 20.95;
            //strawberryPrice = 68;
            //tomatoPrice = 7;
            //potatoPrice = 12;

            //Console.WriteLine("----- Elma Birim Fiyatı: " + applePrice +  " TL");
            //Console.WriteLine("----- Portakal Birim Fiyatı: " + orangePrice +  " TL");
            //Console.WriteLine("----- Çilek Birim Fiyatı: " + strawberryPrice+  " TL");
            //Console.WriteLine("----- Patates Birim Fiyatı: " + potatoPrice +  " TL");
            //Console.WriteLine("----- Domates Birim Fiyatı: " + tomatoPrice + " TL");

            //Console.WriteLine("-----------------------------------------------------------");

            //double appleGram, orangeGram, strawberryGram, tomatoGram, potatoGram;

            //appleGram = 1.245;
            //orangeGram = 1.840;
            //strawberryGram = 0.750;
            //potatoGram = 4.850;
            //tomatoGram = 7.000;

            //double appleTotalPrice = appleGram * applePrice;
            //Console.WriteLine("Alınan Ürün Elma - " + " Birim Fiyat: " + applePrice + " - Gramaj: " + appleGram + " -Toplam Tutar: " + appleTotalPrice);
            //double orangeTotalPrice = orangeGram * orangePrice;
            //Console.WriteLine("Alınan Ürün Portakal - " + " Birim Fiyat: " + orangePrice + " - Gramaj: " + orangeGram + " -Toplam Tutar: " + orangeTotalPrice);
            //double strawberryTotalPrice = strawberryGram * strawberryPrice;
            //Console.WriteLine("Alınan Ürün Çilek - " + " Birim Fiyat: " + strawberryPrice + " - Gramaj: " + strawberryGram + " -Toplam Tutar: " + strawberryTotalPrice);
            //double potatoTotalPrice = potatoGram * potatoPrice;
            //Console.WriteLine("Alınan Ürün Patates - " + " Birim Fiyat: " + potatoPrice + " - Gramaj: " + potatoGram + " -Toplam Tutar: " + potatoTotalPrice);
            //double tomatoTotalPrice = tomatoPrice * tomatoPrice;
            //Console.WriteLine("Alınan Ürün Domates - " + " Birim Fiyat: " + tomatoPrice + " - Gramaj: " + tomatoGram + "  -Toplam Tutar: " + tomatoTotalPrice);

            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + tomatoTotalPrice + potatoTotalPrice + strawberryTotalPrice ;

            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("Alışveriş Toplam Tutar: " + shoppingTotalPrice + " TL");

            //Console.Read();

            #endregion

            #region Char Değişkenler

            //ABCDEFGH
            //DEF...
            //TOPLANTI SAAT 20:00'DE
            //" '

            //char symbol;
            //symbol = 'a';

            //Console.WriteLine(symbol);


            #endregion

            #region Klavyeden Veri Girişleri String Değişkenler

            //Console.WriteLine("**** CSharp Hava Yolları Yolcu Bilgisi ****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("Şehir Adı: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("İlçe Adı: ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Yaş Bilgisi: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("Kimlik Numarası: ");
            //passengerIdentityNumber = Console.ReadLine();




            //Console.WriteLine();

            //Console.WriteLine("-------------------------");

            //Console.WriteLine("Yolcu Ad: " + passengerName + " Yolcu Soyad: " + passengerSurname + "Yolcu İlçe: " + passengerDistrict + " Yolcu  " + passengerCity + " Yolcu Yaş:  " + passengerAge + " Kimlik Numarası: " + passengerIdentityNumber );



            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümleri

            //int shoesPrice, computerPrice, chairPrice, tvPrice;

            //shoesPrice = 1850;
            //computerPrice = 37000;
            //chairPrice = 120;
            //tvPrice = 50000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz: ");
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız sandalye sayısını giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız televizyon sayısını giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());


            //int totalPrice =  shoesPrice * shoesCount + computerPrice * computerCount + chairPrice * chairCount + tvPrice * tvCount;

            //Console.WriteLine();
            //Console.WriteLine("Toplam Ödemeniz Gereken Tutar = " + totalPrice + " TL");


            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3, result;

            //Console.Write("Lütfen 1. Sınav notunu giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. Sınav notunu giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3. Sınav notunu giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine("Sınav Ortalamanız: " + result);


            #endregion

            #region Klavyeden Karakter Girişleri

            //char gender;
            //Console.Write("Lütfen Cinsiyet Seçiniz:");
            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine("Seçtiğiniz Cinsiyet: " + gender);



            #endregion

            Console.Read();
        }
    }
}
