using System;

namespace odevClass
{
    class Program
    {
        static void Main(string[] args)
        {

            Shop shop1 = new Shop();
            shop1.urunMarka = "Samsung";
            shop1.urunAD = "Tab A7 SM-T500 Wi-Fi 3 GB 32 GB";
            shop1.urunFiyat = 1419.99;
            shop1.urunTur = "Elektronik";
            shop1.kargoAd = "Sürat Kargo";
            shop1.urunKargoFiyat = "Ücretsiz Kargo";
            shop1.indirimOranı = 17;
            shop1.magazaAd = "BittiBitiyor";
            shop1.magazaPuan = 100;

            Shop shop2 = new Shop();
            shop2.urunMarka = "Samsung";
            shop2.urunAD = "Tab A7 SM-T500 Wi-Fi 3 GB 32 GB";
            shop2.urunFiyat = 1419.99;
            shop2.urunTur = "Elektronik";
            shop2.kargoAd = "Sürat Kargo";
            shop2.urunKargoFiyat = "Ücretsiz Kargo";
            shop2.indirimOranı = 17;
            shop2.magazaAd = "BittiBitiyor";
            shop2.magazaPuan = 100;

            Shop shop3 = new Shop();
            shop3.urunMarka = "Lenova";
            shop3.urunAD = "Tab A7 SM-T500 Wi-Fi 3 GB 32 GB";
            shop3.urunFiyat = 1419.99;
            shop3.urunTur = "Elektronik";
            shop3.kargoAd = "Sürat Kargo";
            shop3.urunKargoFiyat = "Ücretsiz Kargo";
            shop3.indirimOranı = 17;
            shop3.magazaAd = "BittiBitiyor";
            shop3.magazaPuan = 100;



            Shop[] magazalar = new Shop[] { shop1, shop2, shop3};

            

            foreach (Shop magaza in magazalar)
            {
                Console.WriteLine(magaza.urunMarka + " " + magaza.urunAD);
                Console.WriteLine(magaza.urunFiyat + " " + "İnd. Oran: " + magaza.indirimOranı);
                Console.WriteLine(magaza.magazaAd + " " + "Puan:  " + magaza.magazaPuan + "\n\n");

            }




        }

        
    }
    class Shop
    {
        public string urunAD { get; set; }
        public string urunMarka { get; set; }
        public double urunFiyat { get; set; }
        public string urunTur { get; set; }
        public string kargoAd { get; set; }
        public string urunKargoFiyat { get; set; }
        public int indirimOranı { get; set; }
        public string magazaAd { get; set; }
        public int magazaPuan { get; set; }

    }
}

