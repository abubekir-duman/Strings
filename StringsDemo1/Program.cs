using System.Globalization;

namespace StringsDemo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string tamAd = "Çağıl Alsaç";
            //Console.WriteLine("\"" + tamAd + "\"");
            //Console.WriteLine(tamAd.Trim());
            //Console.WriteLine(tamAd.TrimStart());
            //Console.WriteLine(tamAd.TrimEnd());

            //string diller = "c#,java,python";
            //string trimlenmisDiller = diller.Trim(',' ,',');
            //trimlenmisDiller = diller.Trim(new char());
            //Console.WriteLine(trimlenmisDiller);


            //int ogrenciNo= 123456;
            //string ogrencilerNoYazı = ogrenciNo.ToString();
            //Console.WriteLine(ogrencilerNoYazı);

            //bool dogruMu = true;
            //Console.WriteLine(dogruMu.ToString());

            //int[] sayilar = { 1, 2, 3 };
            //Console.WriteLine(sayilar.ToString());

            int gun = 5;
            int ay = 11;
            int yil = 2023;
            //Console.WriteLine("Tarih:" + gun + "." + ay + "." + yil);

            //Console.WriteLine($"Formatlanmış Tarih:{TarihGetir(gun, ay, yil)}");

            Console.WriteLine($"Formatlanmış Tarih:{gun.ToString().PadLeft(2, '0')}." + $"{ay.ToString().PadLeft(2, '0')}." + $"{yil}");

            string message = "To be continued";
            Console.WriteLine(message.PadRight(18, '.'));

            double sayi1 = 12.34;
            string forSayi1;

            forSayi1=sayi1.ToString();
            forSayi1=sayi1.ToString("N0",new CultureInfo("tr-TR"));
            forSayi1 = sayi1.ToString("C1", new CultureInfo("tr-TR"));

            double sayi2 = 123.456;
            string forSayi2 = string.Format(new CultureInfo("tr-TR"), "{0,7:N1}",sayi2);
            //string forSayi2 = string.Format(new CultureInfo("en-US"), "{0:C2}", sayi2);
            Console.WriteLine(forSayi2);




        }

        static string TarihGetir(int gun,int ay,int yil)
        {
            string tarih;
            string gunString = gun.ToString();
            string ayString=ay.ToString();
            if (gunString.Length == 1)
                gunString = "0" + gunString;
            if(ayString.Length == 1)
                ayString = "0" + ayString;
            return gunString+"."+ayString+"."+yil;
        }
    }
    
}
