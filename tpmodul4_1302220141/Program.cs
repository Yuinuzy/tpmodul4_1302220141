using tpmodul4_1302220141.kodepos;
using System;


namespace TPMOD4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Contoh pertama :");
            Kodepos kodepos = new Kodepos();
            kodepos.setKodePost();
            kodepos.getKodePos();

         
        }
    }
}