using System;

namespace ternaryOperator
{
    class Program
    {
        static void Main(string[] args)
        {


            //int sayi = int.Parse(Console.ReadLine());
            //string cevap = "";
            //cevap += sayi == 7 ? "Doğru bildiniz":"Yanlış cevap";

            //Console.WriteLine(cevap);







            /*
             Ternary Operator'ü ne işe yarar yada nedir?
             Misal bir kullanıcıdan değer alıcaksınız ve bu değer istediğiniz değere eşit 
            ise kullanıcıya doğru cevap diye mesaj vericeksiniz.
            Eğerki yanlı ise kullanıcıya ona göre bir mesaj vericeksiniz.
            Yani aslında bir if else mantığı ile çalışır. ŞArt sağlanıyosa 
            şartın içinde bulunan değeri , eğerki şart sağlanmıyosa sağlanmayan şartın değerini
            döndürür.
            Peki Ternory Operator'ü nedir yada bunu kullanım şekli şu şekildedir:
            ****************************
            koşul? doğru ise: yanlış ise
            ****************************
            şeklinde kullanılır.

            Birde Coalescing Nedir nasıl kullanılır?

            Kullanıcıdan bir değer istediğimzde istenilen değer boş geçilmiş ise 
            bizim tanımladığımız varsayılan değeri döndürür.
            Yani örnekliyecek olursak.
            Kullanıdan yaşını istediğimizi varsaylım,
            kullanıcı bu kısmı boş geçerse eğer biz varsayılan yaşı 18 tanımladıysak 
            burda değer 18 kabul edilir. Tabi ki siz burda farklı bir değer kullanabilsiniz.
            Örnek olarak:
            ***********************
            *string sayi = Console.ReadLine();
             string cevap = (sayi == "" ? null : sayi) ?? "Boş geçildi";
            Console.WriteLine(cevap);
            ******************************
            *Şu tarz bir örnek verebilirim.

             */




            /*
             Bilgisayar gününü çekmek için alttaki kod kullanılır.
             DateTime.Now.DayOfWeek;
             
               Switc Case Yapısı nedir , nasıl kullanılır, ne için kullanılır?
             
            Sizlere bu konu hakkında kendi çapımda anladığım kadarıyla açıklama yapıcam.
            Şimdik switch case yapımız nedir bundan bahsedelim
            Bu yapı bizim if else kullanılır gibi şart mantığı ile çalışır. Ama tabiki bu 
            tam olarak bir if else sayılmaz.

            Birden fazla şartı yerine geticeksek swich case kullanırız. if else ile de 
            olabilir fakat switch case daha az kod yazmamızı sağlar.
            Örnek olarak 
            Diyelimki kullanıcının girdiği ay sayısına göre kullanıcıya o ay değeriniz gösteririz.
            Yani ben 12. Ayı istedğimde ekranda Aralık yazar.
            İşte burda bunu if else ile yapmış olsak çok daha fazla kod satırı harcamış olucaz ve 
            biraz daha zahmetli ve karmaşık olabilir.
            Şöyle bir örnek ile karşılaştıralım
            
            int ay = int.Parse(Console.ReadLine()); //diyerek kullanıcadan ay sayısını istedim.
            
            switch(ay) // burda Switch yani benim anahtarım parantez içine yazdığım ay değeri bu illa int olmak zorunda değil. Diğer veri tipleride kullanılabilir.
            {
                case 1:Console.WritLine("Ocak");
                        break;
                case 2:Console.WritLine("Şubat");
                        break;
                case 3:Console.WritLine("Mart");
                        break;
                case 4:Console.WritLine("Nisan");
                        break;
                case 5:Console.WritLine("Mayıs");
                        break;
                case 6:Console.WritLine("Haziran");
                        break;
                case 7:Console.WritLine("Temmuz");
                        break;
                case 8:Console.WritLine("Ağustos");
                        break;
                case 9:Console.WritLine("Eylül");
                        break;
                case 10:Console.WritLine("Ekim");
                        break;
                case 11:Console.WritLine("Kasım");
                        break;
                case 12:Console.WritLine("Aralık");
                        break;
            }
             
             Üst kısımda gördüğünüz (break;) deyimini yazma sebebimiz ise , diyelim kullanıcı
            3. Ayı istedi, break deyimi olmaz ise kullanıcıya 3. Ayı gösterdikten sonra program alta doğru diğer case'lerede girip
            o kısımdaki kodlarıda çalıştırır. Ta ki tüm şartlar bitene kadar.
            peki case'in yanındaki sayılar ne ? O sayılar kullanıcının girdiği ay değeri için bir şarttır.
            Yani kullanıcı 10 sayısını vermiş ise kullanıcıya orda bulunan 10 değerindeki kodları döndürür.
            Peki illa sayımı olmalıdır? Hayır illa sayı olmak zorunda değil, kullanıcıdan aldığınız değere
            göre bu kısımlar değişebilir.
            Yani if(şart) girdiğimiz yere switch case de case şart: kod;break; olarak kullanırız.
            Yukardaki kodu if else ile yazmış olsaydık daha uzun bir kod olurdu ama şuan kod dahada kısalmış oldu.
            Elbette daha farklı şekillerde bu kod kat kat daha kısalır ama şimdilik switch case yapısını anlamak için bu şekilde açıkladım.
             
             
             */

            /*
             While Döngüsü nedir nasıl kullanılır, sıklıkla nerelerde kullanılır?
            While döngüsü birden fazla tekrar gerektiren işlerde for döngüsü gibi kullanılır.
            Birde database gibi yerlerden veri çekmek içinde kullanılır. FOr döngüsünden farkı while 
            döngüsü bir değişken içermez. sadece şartı yazarsınız ve şart true ise döngü çalışır false
            ise döngü çalışmayı durdurur.
            while döngüsünde eğerki bir saydırma işlemi yapacaksanız ve değeri artırmayı unuttuysanız
            sonsuz döngüye girer. Bunun için bu tarz olaylara dikkat edilmelidir.
            Örnek bir saydırma işlemi yapalım:
            
            int i = 0;

            while(i<10)
            {
                Console.WriteLine(i);
            }
            Eğerki yukardaki tarzda bir döngü yazmış iseniz bu döngü sonsuz döngüye girer, çünkü
            siz i değişkenini artırmadınız. Döngünün her sonunda i değişkenini yada değişken her ne ise artırmalısınız.

            int i = 0;
            while(i<10)
            {
                Console.WriteLine(i);
                i++;
            }

                while döngüsünün birde do while olanı vardır. Yani bu döngü ise ilk işlemi yap ikinci işlemi ise şart gerçekleşiyosa 
            yap demektir. Yani başta şart false olsa bile bu işlem yapılır.
            En basit örnek ile kullanıcıdan 0 değerini alana kadar toplama işlemi yapan program 

            int sayi;
            int toplam = 0;

            do
            {
                sayi = Console.ReadLine();
                toplam +=sayi;
            }while(sayi!=0);

            Üste görünen örnekte eğerki ben değeri sıfır versem dahi program her türlü bir sefer çalışır.
            Ama 0 dan farklı bir değer girersem program tekrardan çalışır. 


             */

            

        }
    }
}
