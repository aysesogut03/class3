using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    internal class bilgisayar
    {
        public string pcRengi;
        public int modelYili;
        public string marka;

        public bilgisayar( string _pcRengi, int _modelYili,string _marka)
        {
            pcRengi= _pcRengi;
            modelYili= _modelYili;  
            marka= _marka; 
        }
        public void calistir()
        {
            Console.WriteLine("Bilgisayar çalıştırılıyor...");
        }
        public void sifregir()
        {
            Console.WriteLine("Şifre giriliyor...");
        }
    }
}
