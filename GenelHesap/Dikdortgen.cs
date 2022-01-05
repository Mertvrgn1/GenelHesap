using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenelHesap
{
    public class Dikdortgen:Sekiller
    {
        private double _kısaKenar;
        public double KısaKenar 
        {
            get { return _kısaKenar; }
            set { _kısaKenar = value; } 
        }
        public Dikdortgen(double kısakenar,double uzunkenar)
        {
            this.Kenar = uzunkenar;
            this.KısaKenar = kısakenar;
                         
        }
        public Dikdortgen()
        {

        }
        public override void alanHesapla()
        {
            Console.WriteLine("Dikdörtgenin alanı:" + (Kenar * KısaKenar));
        }
        public override void cevreHesapla()
        {
            Console.WriteLine("Dikdörtgenin çevresi:" + (2*(Kenar+KısaKenar)));
        }
    }
}
