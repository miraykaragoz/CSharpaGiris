namespace VeriTipleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //En çok kullanılan veri tiplerinden biri olan INTeger, yani tam sayılarınalabileceği
            //maximum değer 2.147.483.647'dir. Bu maximum değeri int.MaxValue ile görebiliriz.
            //aynı şekilde alableceği en düşük değeri de int.MinValue ile  görebiliriz.

            //=operatörü ile değişkenlere değer ataması yapabiliriz. Örneğin;
            //int sayi1 = 5;
            //int sayi2 = 6;
            //sayi1 = sayi1 + 5;
            //sayi1 += 5;
            //= operatörü sağ tarafındaki değeri sol tarafındaki değişkene atar.
            //string metin = "Merhaba Dünya";
            //string veri tipi ile birlikte + operatörünü kullanarak metinsel ifadeleri birleştirebiliriz.
            //Örneğin;
            //string ad = "Mehmet";
            //string soyad = "Kaya";
            //string bosluk = " ";
            //string adSoyad = ad + " " + soyad;
            //CONCAT-ENATION

            //Console.WriteLine("Merhaba : " + ad + " " + soyad);

            //bu kullanımın adı interpolation olarak geçmektedir. Bu kullnım ile değişkenleri
            //süslü paratez içerisinde kullanabiliriz. Örneğin;
            //Console.WriteLine($"Merhaba : {ad} {soyad}");

            //Kullanıcıya adını ve soyadını ayrı ayrı soralım ve ardından ekrana "Hoşgeldin ad soyad"
            //formatınfa yazdıralım.
            //Console.WriteLine("Adınızı giriniz : ");
            //string ad = Console.ReadLine();
            //Console.WriteLine("Soyadınızı giriniz : ");
            //string soyad = Console.ReadLine();
            //Console.WriteLine($"Hoşgeldin {ad} {soyad}");

            //Console.WriteLine($"Adınız soyadınız toplam {ad.Length + soyad.Length} karakter uzunluğundadır");

            //char karakter = (char)255;
            //stringler aslında characterlerden oluşan bir dizidir. Örneğin;
            //string ad = "Emre";
            //4 tane karakterden oluşan bir dizi oluşturmuş gibioluyoruz. Bu dizinin elemanlarına
            //erişmekiçin dizi elemanlarına erişir gibi erişebiliriz. Örneğin;

            //Console.WriteLine(ad[0]);
            //maximum 255 değeri alabilen yapısal int'den farkı olmayan bir veri tipidir.
            //bool x = 1 == 1;

            //Console.WriteLine(x);
            //Console.WriteLine("Doğum yılınızı giriniz : ");
            //int yil = int.Parse(Console.ReadLine());

            //int bugununYili = DateTime.Now.Year;
            //Console.WriteLine($"Yaşınız {bugununYili-yil}");
        }

    }
}
