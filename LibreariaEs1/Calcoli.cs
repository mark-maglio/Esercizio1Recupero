using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreariaEs1
{
    public class Calcoli
    {
        public static bool QuadratoPerfetto(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                int q = i * i;
                if (q == n)
                    return true;
                if (q > n)
                    return false;
            }
            return false;
        }
    }
}