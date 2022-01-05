using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenelHesap
{
    public class Sekiller
    {
        double _kenar;
        public double Kenar 
        {
            get { return _kenar; }
            set { _kenar = value; }
        }

        public virtual void alanHesapla()
        {
            //......Base.........
            Console.WriteLine("Bu base classtaki alan hesapla metodudur.");
        }

        public virtual void cevreHesapla()
        {
            //......Base.........
            Console.WriteLine("Bu base classtaki cevre hesapla metodudur.");

        }
    }
}
