using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mayın_tarlası
{
    internal class Class_game
    {
        public int _boyut;
        List<int> bombalar = new List<int>();
        public void bomba_yerlestir(int adet)
        {
            int sayac = 0;

            while (sayac < adet)
            {
                Random r = new Random();
                int random_sayi = r.Next(_boyut);
                if (bombalar.IndexOf(random_sayi) == -1)
                {
                    bombalar.Add(random_sayi);
                    sayac++;
                }
            }
        }

        public bool kontrol(int btn_no)
        {
            if (bombalar.IndexOf(btn_no) == -1) 
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
