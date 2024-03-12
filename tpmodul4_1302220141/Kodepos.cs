using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul4_1302220141.kodepos
{
    internal class Kodepos
    {
        public String kelurahan;
        public int kodepos;
        public List<Kodepos> listKodepost = new List<Kodepos>();
        public Kodepos(String a = "", int k = 0)
        {
            this.kelurahan = a;
            this.kodepos = k;
        }

        public void setKodePost()
        {
            this.listKodepost.Add(new Kodepos("Cibaduyut", 40221));
            this.listKodepost.Add(new Kodepos("Kujangsari", 40287));
            this.listKodepost.Add(new Kodepos("Mengger", 40267));
            this.listKodepost.Add(new Kodepos("Wates", 40256));
            this.listKodepost.Add(new Kodepos("Cijaura", 40287));
            this.listKodepost.Add(new Kodepos("Jatisari", 40286));
            this.listKodepost.Add(new Kodepos("Margasari", 40286));
            this.listKodepost.Add(new Kodepos("Sekejati", 40286));
            this.listKodepost.Add(new Kodepos("Kebonwaru", 40272));
            this.listKodepost.Add(new Kodepos("Maleer", 40274));
            this.listKodepost.Add(new Kodepos("Samoja", 40273));
        }

        public void getKodePos()
        {
            Console.WriteLine("Kelurahan\tKode Pos");
            foreach (Kodepos k in this.listKodepost)
            {
                string kelPad = k.kelurahan.PadRight(15);
                Console.Write(kelPad + "\t" + k.kodepos);
                Console.WriteLine();
            }

        }

    }
}
