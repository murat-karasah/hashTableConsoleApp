using System;
using System.Collections;

namespace hashTableConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //////ders hashtable
            ////Hashtable h1 = new Hashtable();
            ////h1.Add("car", "araba");
            ////h1.Add("house", "ev");


            ////bool kontrol = h1.Contains("house");
            ////bool kontrol2 = h1.Contains("door");
            ////bool kontrol3 = h1.ContainsValue("araba");
            ////bool kontrol4 = h1.ContainsKey("cars");

            ////Console.WriteLine(kontrol+"..."+ kontrol2 + "..." + kontrol3 + "..." + kontrol4);

            //Uygulama
            string secim=null;
            Hashtable sozluk = new Hashtable();
            Console.WriteLine("Eklemek istediğiniz sözlük değerini yazınız");
           
            do
            {
                Console.Write("EN:");
                string enter = Console.ReadLine();
                bool kontrol = sozluk.Contains(enter);
                if (kontrol == true)
                {
                    Console.WriteLine("Eklemek istediğiniz sözlük değeri zaten var!");
                }
                else
                {
                    Console.Write("TR:");
                    string giris = Console.ReadLine();
                    sozluk.Add(enter, giris);
                    Console.WriteLine("Değer Ekleme Başarılı!");
                    Console.WriteLine("Yeni Değer Girmek istiyor musunuz? E\\h");
                     secim = Console.ReadLine();
                }
            } while (secim=="E" || secim=="e");

            foreach (DictionaryEntry de in sozluk)
                Console.WriteLine("En: {0}, Tr: {1}", de.Key, de.Value);


        }
    }
}
