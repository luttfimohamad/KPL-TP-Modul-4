using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul4_1302204066
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataGeneric<String> data = new DataGeneric<string>("1302204066");
            data.PrintInfo();
        }
    }
}
