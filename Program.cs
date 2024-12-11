using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bilgisayar bilgisayar1=new bilgisayar("siyah",2017,"Dell");

            Console.WriteLine("Bilgisayar rengi:" + bilgisayar1.pcRengi);
            Console.WriteLine("Bilgisayar üretim yılı:"+bilgisayar1.modelYili);
            Console.WriteLine("Bilgisayar model:"+bilgisayar1.modelYili);
            bilgisayar1.calistir();
            bilgisayar1.sifregir();
            Console.ReadLine();
        }
    }
}
