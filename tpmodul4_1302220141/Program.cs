using tpmodul4_1302220141.kodepos;
using System;
using tpmodul4_1302220141.cepatan;


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

            Doormachine door = new Doormachine();
            door.run();
        }
    }
}