using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul4_1302204066
{
    internal class HaloGeneric<T>
    {
        public void SapaUser(T inputan)
        {
            Console.WriteLine("Halo user " + inputan);
        }
    }
}
