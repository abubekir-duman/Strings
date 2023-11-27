
using System.Security.Cryptography;

namespace TcNoKontrol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lütfen 11 haneli kimlik numaranızı giriniz:");
            string TcNo = Console.ReadLine();



            //if (TcNo.Length != 11)
            //{
            //    Console.WriteLine("lütfen 11 haneli kimlik numaranızı giriniz:");
            //}
            //else 
            //{
            //    Console.WriteLine("girilen kimlik numarası 11 hanelidir.");
            //}


            //if (Convert.ToInt64(TcNo[0]) == 0)
            //{
            //    Console.WriteLine("kimlik numarasının ilk değeri sıfırdır");
            //}
            //else
            //{
            //    Console.WriteLine("kimlik numarasının ilk değeri sıfır değildir.");
            //}

            //foreach (char c in TcNo)
            //{
            //    if (!Char.IsNumber(c))
            //    {
            //        Console.WriteLine("girilen kimlik numarası sayısal değil");
            //    }
            //    else
            //    {
            //        Console.WriteLine("girilen kimlik numarası sayısal değerdir");
            //    }
            //}
            //long yeniTcNo;
            //yeniTcNo=Convert.ToInt32(TcNo);

            //for (int i = 0; i < yeniTcNo; i++)  //43462514234
            //{
            //    if (yeniTcNo[9] = ((yeniTcNo[0] + yeniTcNo[2] + yeniTcNo[4] + yeniTcNo[6] + yeniTcNo[8]) * 7 - (yeniTcNo[1] + yeniTcNo[3] + yeniTcNo[5] + yeniTcNo[7])) % 10)
            //    {
            //        Console.WriteLine("Kimlik numarasındaki 10.hanede doğrudur.");
            //    }
            //}


            //if (Convert.ToInt64(TcNo[9]) == ((Convert.ToInt64(TcNo[0]) + Convert.ToInt64(TcNo[2]) + Convert.ToInt64(TcNo[4]) + Convert.ToInt64(TcNo[6]) + Convert.ToInt64(TcNo[8])) * 7 - (Convert.ToInt64(TcNo[1]) + Convert.ToInt64(TcNo[3]) + Convert.ToInt64(TcNo[5]) + Convert.ToInt64(TcNo[7]))) % 10)
            //{
            //    Console.WriteLine("Kimlik numarasındaki 10.hane doğrudur.");
            //}
            //else
            //{
            //    Console.WriteLine("Kimlik numarasındaki 10.hane doğru değildir");
            //}

            while (TcNo[0] != 0)
            {
                if (TcNo.Length == 11)
                {
                    long yeniTcNo, C1, C2, C3, C4, C5, C6, C7, C8, C9, C10, C11;
                    yeniTcNo = Convert.ToInt64(TcNo);

                    C1 = yeniTcNo / 10000000000; C1 = C1 % 10;
                    C2 = yeniTcNo / 1000000000; C2 = C2 % 10;
                    C3 = yeniTcNo / 100000000; C3 = C3 % 10;
                    C4 = yeniTcNo / 10000000; C4 = C4 % 10;
                    C5 = yeniTcNo / 1000000; C5 = C5 % 10;
                    C6 = yeniTcNo / 100000; C6 = C6 % 10;
                    C7 = yeniTcNo / 10000; C7 = C7 % 10;
                    C8 = yeniTcNo / 1000; C8 = C8 % 10;
                    C9 = yeniTcNo / 100; C9 = C9 % 10;
                    C10 = yeniTcNo / 10; C10 = C10 % 10;
                    C11 = yeniTcNo % 10;





                    if ((C10 == (((C1 + C3 + C5 + C7 + C9) * 7) - (C2 + C4 + C6 + C8)) % 10) && (C11 == (C1 + C2 + C3 + C4 + C5 + C6 + C7 + C8 + C9 + C10) % 10))
                    {
                        Console.WriteLine("Kimlik numarası doğrudur.");
                    }
                    else
                    {
                        Console.WriteLine("Kimlik numarası yanlıştır.");
                    }
                }
                else
                {
                    Console.WriteLine("lütfen kimlik numaranızı 11 haneli olarak giriniz:");
                }

                Console.Write("Lütfen 11 haneli kimlik numaranızı giriniz:");
                 TcNo = Console.ReadLine();

            }









        }


    }
}
