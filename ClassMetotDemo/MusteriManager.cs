using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        
    public void MudiEkle(string SubeNo, string HesapNo, string MudiAdi, string MudiSoyadi, double Bakiye, string ParaBirimi)
        
        {
            
            Console.WriteLine("Vadesiz Hesap Eklendi  :"+ (SubeNo, HesapNo, MudiAdi, MudiSoyadi,Bakiye,ParaBirimi));
        }
        public void MudiCikar(string SubeNo, string HesapNo, string MudiAdi, string MudiSoyadi, double Bakiye, string ParaBirimi)
        {
            Console.WriteLine("Vadesiz Hesap Silindi :"+(SubeNo, HesapNo, MudiAdi, MudiSoyadi, Bakiye, ParaBirimi));
        }
    }
}
