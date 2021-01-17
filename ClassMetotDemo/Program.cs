using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------ŞUBE-HESAP NO--HESAP SAHİBİ--BAKİYE---------");
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MudiEkle("000120", "100001", "Adnan", "Batmaz", 100000.50, "TL");
            musteriManager.MudiEkle("000120", "100101", "Kenan", "Batmaz", 1000.00, "TL");
            musteriManager.MudiEkle("000120", "100301", "Ayşen", "Şen   ", 300000.00, "TL");
            musteriManager.MudiEkle("000120", "100501", "Faruk", "Uçar  ", 700000.50, "TL");
            Console.WriteLine("---------------------ŞUBE-HESAP NO--HESAP SAHİBİ--BAKİYE--");
            musteriManager.MudiCikar("000120", "100301", "Ayşen", "Şen   ", 000000.00, "TL");

            
        }
    }
}
