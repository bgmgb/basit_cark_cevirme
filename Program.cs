using System;
using System.Collections;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cark_cevirme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kullanıcı bitti yazana kadar yazdığı her şey secenekler listesine eklenecek sonra içinden random eleman atanacak
            ArrayList secenekler = new ArrayList();
            Console.WriteLine(" seçenek ekleme işlemini bitirmek isrediğinizde 'biiti' yazınız");
            string eklenen_secenek;
            do
            {
                Console.WriteLine("seçenek ekleyiniz");
                eklenen_secenek = Console.ReadLine();
                if (eklenen_secenek != "bitti")
                {
                    secenekler.Add(eklenen_secenek);
                }

            } while (eklenen_secenek != "bitti");
            Random rnd = new Random();

             string cıkan_secenek=(string)secenekler[rnd.Next(secenekler.Count)];//bunu oluşturduğum arraylistten rastgele eleman bulmak için yaptım
            Console.WriteLine("çıkan seçenek "+ cıkan_secenek);

                
            

            

            

        }
    }
}
