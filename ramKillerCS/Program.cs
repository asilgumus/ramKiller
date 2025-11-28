using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ramKiller
{
    internal class Program
    {
        static void Main(string[] args)
        {

            killRam();
}

        static void killRam()
        {
            List<byte[]> ram = new List<byte[]>();

            while (true)
            {

                ram.Add(new byte[10_000_000]); // HER SEFERDE YENİ 10 MB

            }
        }
    }
}
