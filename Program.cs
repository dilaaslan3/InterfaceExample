using System;

namespace InterfaceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            BilgisayarMuh bilgisayarMuh = new BilgisayarMuh("k", true, true);
            bilgisayarMuh.askerlikDurumu();
            bilgisayarMuh.ortalama("3,06");
            bilgisayarMuh.sicilKaydi();
            string[] sirketler = { "Reengen", "Teknovasyon Arge", "Turkcell" };
            bilgisayarMuh.tecrube(sirketler);


            IMuhendisIseAlim muhendisIseAlim = new EndustriMuh("kadın",false,false);
            muhendisIseAlim.sicilKaydi();


            EndustriMuh endustriMuh = new EndustriMuh("kadın", false, true);
            // string[] referanslar = new string[0];
            string[] referanslar = { "Ali Veli","Ahmet Mehmet","Dila Aslan" };
            endustriMuh.referanslar(referanslar);
            endustriMuh.calis();
        }
    }
    abstract class Aday
    {
        public string Cinsiyet { get; set; }
        public bool Askerlik { get; set; }
        public bool Sicil { get; set; }
    }
    interface IMuhendisIseAlim
    {
        void tecrube(string[] sirketler);
        void ortalama(string ort);
        void sicilKaydi();
        void askerlikDurumu();
    }
    interface ICalis
    {
        void calis();
    }


    class BilgisayarMuh : Aday, IMuhendisIseAlim
    {
        public BilgisayarMuh(string cinsiyet, bool askerlik, bool sicil)
        {
            Cinsiyet = cinsiyet;
            Askerlik = askerlik;
            Sicil = sicil;
        }

        public void askerlikDurumu()
        {
            if (Cinsiyet == "k" || Cinsiyet == "kadın")
            {
                Console.WriteLine("Kadın Aday");
                
            }
            else if(Cinsiyet== "e" || Cinsiyet=="erkek")
            {
                Console.WriteLine("Erkek Aday askerlik durumu: ");
                if (Askerlik)
                {
                    Console.WriteLine("Askerlik yapmış.");
                }
                else
                {
                    Console.WriteLine("Askerlik yapmamış.");
                }
            }
            else
            {
                Console.WriteLine("Kadın adaylar için k veya kadın , Erkek adaylar için e veya erkek olacak şekilde cinsiyet bilgilerinizi giriniz.");
                Environment.Exit(0);
            }
           
        }

        public void ortalama(string ort)
        {
            Console.WriteLine("Adayın mezuniyet ortalaması: {0}", ort);
        }

        public void sicilKaydi()
        {
            if (Sicil)
            {
                Console.WriteLine("Sicil kaydı bulunmamaktadır.");
            }
            else
            {
                Console.WriteLine("Sicil kaydı bulunmaktadır.");
            }
        }

        public void tecrube(string[] sirketler)
        {
            Console.WriteLine("Adayın daha önce çalıştığı şirketler:");
            for (int i = 0; i < sirketler.Length; i++)
            {
                Console.WriteLine(sirketler[i]);
            }
        }
    }
    
    class EndustriMuh : Aday, IMuhendisIseAlim, ICalis
    {
        public EndustriMuh(string cinsiyet, bool askerlik, bool sicil)
        {
            Cinsiyet = cinsiyet;
            Askerlik = askerlik;
            Sicil = sicil;
        }

        public void askerlikDurumu()
        {
            if (Cinsiyet == "k" || Cinsiyet == "kadın")
            {
                Console.WriteLine("Kadın Aday");

            }
            else if (Cinsiyet == "e" || Cinsiyet == "erkek")
            {
                Console.WriteLine("Erkek Aday askerlik durumu: ");
                if (Askerlik)
                {
                    Console.WriteLine("Askerlik yapmış.");
                }
                else
                {
                    Console.WriteLine("Askerlik yapmamış.");
                }
            }
            else
            {
                Console.WriteLine("Kadın adaylar için k veya kadın , Erkek adaylar için e veya erkek olacak şekilde cinsiyet bilgilerinizi giriniz.");
                Environment.Exit(0);
            }

        }

        public void ortalama(string ort)
        {
            Console.WriteLine("Adayın mezuniyet ortalaması: {0}", ort);
        }

        public void sicilKaydi()
        {
            if (Sicil)
            {
                Console.WriteLine("Sicil kaydı bulunmamaktadır.");
            }
            else
            {
                Console.WriteLine("Sicil kaydı bulunmaktadır.");
            }
        }

        public void tecrube(string[] sirketler)
        {
            if (sirketler.Length == 0)
            {
                Console.WriteLine("Adayın tecrübesi bulunmamaktadır.");
            }
            else
            {
                Console.WriteLine("Adayın daha önce çalıştığı şirketler:");
                for (int i = 0; i < sirketler.Length; i++)
                {
                    Console.WriteLine(sirketler[i]);
                }
            }        
        }

        public void referanslar(string[] referanslar)
        {
            Console.WriteLine("Referanslarım:");
            if (referanslar.Length == 0)
            {
                Console.WriteLine("Adayın referansı bulunmamaktadır.");
            }
            else
            {
                Console.WriteLine("Adayın Referansları:");
                for (int i = 0; i < referanslar.Length; i++)
                {
                    Console.WriteLine(referanslar[i]);
                }
            }
        }

        public void calis()
        {
            Console.WriteLine("Bir classa birden fazla interface implemet edilebilir..");
        }
    }
    
}
