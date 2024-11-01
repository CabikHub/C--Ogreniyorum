using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace x3_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region If Else

            //Console.WriteLine("Lütfen şifreyi giriniz: ");
            //string password;
            //password = Console.ReadLine();

            //if (password == "abcd")
            //{

            //    Console.WriteLine("Şifre Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre Yanlış");
            //}

            //string capital, country;

            //Console.WriteLine("Ülke Adını Giriniz: ");
            //country = Console.ReadLine();


            //Console.WriteLine("Başkent Adını Giriniz: ");
            //capital = Console.ReadLine();

            //if (country == "Türkiye" & capital == "Ankara")
            //{
            //    Console.WriteLine("Doğru Veri Girişi ");
            //}
            //else
            //{

            //    Console.WriteLine("Yanlış Veri Girişi ");
            //}

            //int number;

            //Console.WriteLine("Sayıyı Giriniz: ");
            //number = int.Parse(Console.ReadLine());

            //if (number == 5)
            //{

            //    Console.WriteLine("Doğru Sayı Girişi");

            //}
            //else
            //{
            //    Console.WriteLine("Yanlış Sayı Girişi");

            //}

            //int exam1, exam2, exam3, avarage;

            //string result = "Hata!";



            //Console.Write("Sınav1: ");
            //exam1 = int.Parse(Console.ReadLine());

            //Console.Write("Sınav2: ");
            //exam2 = int.Parse(Console.ReadLine());

            //Console.Write("Sınav3: ");
            //exam3 = int.Parse(Console.ReadLine());

            //avarage = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine("Sınav Not Ortalamanız: " + avarage);

            //if (avarage > 0 & avarage <= 50)
            //{

            //    result = "Sonuç Vasat";
            //}

            //if (avarage > 50 & avarage <= 70)
            //{

            //    result = "Sonuç Orta";
            //}

            //if (avarage > 70 & avarage <= 84)
            //{

            //    result = "Sonuç İyi";
            //}

            //if (avarage >85)
            //{

            //    result = "Sonuç Çok iyi";
            //}

            //Console.WriteLine(result);

            //string city;
            //Console.WriteLine("Lütfen Şehir Girişi Yapınız: ");
            //city = Console.ReadLine();

            //if (city=="adana" | city == "istanbul" | city == "ankara" | city == "bursa")
            //{
            //    Console.WriteLine("Şehir Mevcut");

            //}
            //else
            //{
            //    Console.WriteLine("Şehir Mevcut Değil");

            //}

            //Console.Write("Lütfen Kullanıcı adını giriniz: ");
            //string username = Console.ReadLine();
            //if (username != "admin")
            //{
            //    Console.Write("Bu Kullanıcı Adı Kabul Edilemez");

            //}
            //else { Console.Write("Hoşgeldiniz");



            #endregion

            #region Mod İşlemleri

            //int number;
            //number = 26;
            //int result = number % 5;

            //Console.WriteLine(result);

            //Console.WriteLine("Lütfen 1. Sayıyı Giriniz: ");
            //int number1 =int.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen 2. Sayayı Giriniz: ");
            //int number2=int.Parse(Console.ReadLine());

            //int result = number1 % number2;

            //Console.WriteLine("1. Sayının 2. Sayıya Bölümünden Kalan:" + result);

            //Console.Write("Lütfen Sayıyı Giriniz: ");
            //int number = int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{

            //    Console.Write("Bu Sayı Çifttir");

            //}
            //else 
            //{
            //    Console.Write("Bu Sayı Tektir");
            //}



            #endregion

            #region Char Değişkenler İle Karar Yapıları

            // char team;

            // Console.WriteLine("Lütfen Hangi Takımı Tuttuğunuzu Giriniz: ");
            // team = char.Parse(Console.ReadLine());

            // if (team == 'G' || team =='g' )
            // {
            //     Console.WriteLine("Tuttuğunuz Takım Galatasaray");

            // }

            //else if (team == 'F' || team == 'f')
            // {
            //     Console.WriteLine("Tuttuğunuz Takım Fenerbahçe");

            // }

            //else if (team == 'B' || team == 'b')
            // {
            //     Console.WriteLine("Tuttuğunuz Takım Beşiktaş");

            // }
            // else
            // {
            //     Console.WriteLine("Tuttuğunuz takım verilerimizde yok ! ");
            // }





            #endregion

            #region Örnek Proje Uygulaması

            //Console.WriteLine("***** C# Eğitim Kampı Restoran *****");
            //Console.WriteLine();
            //Console.WriteLine("----------------------------------------------");
            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-Tatlılar");
            //Console.WriteLine("5-İçecekler");
            //Console.WriteLine("----------------------------------------------");
            //Console.WriteLine();

            //string menuItem;
            //menuItem = Console.ReadLine();

            //Console.WriteLine("Detayını Görmek İstediğiniz Menüyü Seçiniz");
            //if (menuItem == "1")
            //{
            //    Console.WriteLine("----------Ana Yemekler----------");
            //    Console.WriteLine("1-Köri Soslu Tavuk");
            //    Console.WriteLine("2-Barbunya Pilaki");
            //    Console.WriteLine("3-Patlıcan Musakka");
            //    Console.WriteLine("4-Barbekü Soslu Beef");
            //    Console.WriteLine("5-Domates Soslu Makarna");
            //    Console.WriteLine("----------------------------------------------");
            //}
            //if (menuItem == "2")
            //{
            //    Console.WriteLine("----------Çorbalar----------");
            //    Console.WriteLine("1-Mercimek");
            //    Console.WriteLine("2-Kelle Paça");
            //    Console.WriteLine("3-Ezogelin Çorbası");
            //    Console.WriteLine("4-Domates Çorbası");
            //    Console.WriteLine("5-Tavuk Suyu Çorbası");
            //    Console.WriteLine("----------------------------------------------");
            //}
            //if (menuItem == "3")
            //{
            //    Console.WriteLine("----------Pizzalar----------");
            //    Console.WriteLine("1-Margaritha");
            //    Console.WriteLine("2-Akdeniz Pizza");
            //    Console.WriteLine("3-Bol Malzemos");
            //    Console.WriteLine("----------------------------------------------");


            //}
            //if (menuItem == "4")
            //{
            //    Console.WriteLine("----------Tatlı----------");
            //    Console.WriteLine("1-Trileçe");
            //    Console.WriteLine("2-Tiramisu");
            //    Console.WriteLine("3-Sansebastian");
            //    Console.WriteLine("4-Dubai Chocolate");
            //    Console.WriteLine("----------------------------------------------");

            //}
            //if (menuItem == "5")
            //{
            //    Console.WriteLine("----------İçecekler----------");
            //    Console.WriteLine("1-Kola");
            //    Console.WriteLine("2-Ayran");
            //    Console.WriteLine("3-Su");
            //    Console.WriteLine("----------------------------------------------");
            //}


            #endregion

            #region Switch Case

            //Console.WriteLine("Lütfen Bir Ay Giriniz");
            //int monthNumber = int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1:
            //        Console.Write("Ocak");
            //        break;
            //    case 2:
            //        Console.Write("Şubat");
            //        break;
            //    case 3:
            //        Console.Write("Mart");
            //        break;
            //    case 4:
            //        Console.Write("Nisan");
            //        break;
            //    case 5:
            //        Console.Write("Mayıs");
            //        break;
            //    case 6:
            //        Console.Write("Haziran");
            //        break;
            //    case 7:
            //        Console.Write("Temmuz");
            //        break;
            //    case 8:
            //        Console.Write("Ağustos");
            //        break;
            //    case 9:
            //        Console.Write("Eylül");
            //        break;
            //    case 10:
            //        Console.Write("Ekim");
            //        break;
            //    case 11:
            //        Console.Write("Kasım");
            //        break;
            //    case 12:
            //        Console.Write("Aralık");
            //        break;
            //    default: Console.WriteLine("Hatalı Veri Girişi Yaptınız !");
            ////        break;
            //}




            #endregion

            #region Switch Case Hesap Makinesi

            //int number1, number2, result;
            //char symbol;


            //Console.WriteLine("1. Sayıyı Giriniz: ");
            //number1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("2. Sayıyı Giriniz");
            //number2 = int.Parse(Console.ReadLine());

            //Console.Write("Yapmak İstediğiniz İşlemi Seçiniz: ");
            //symbol = char.Parse(Console.ReadLine());



            //switch (symbol)
            //{
            //    case '+':
            //        result = number1 + number2;
            //        Console.WriteLine("Toplam: " + result);
            //        break;

            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("Fark: " + result);
            //        break;

            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("Çarpım: " + result);
            //        break;

            //    case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("Bölüm: " + result);
            //        break;



            #endregion

        }

        

    }


}


       
   
