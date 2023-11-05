using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.GunbinNA.Sprint4.Task0.V19.Lib
{
    public class DataService : ISprint4Task0V19
    {
        public int GetMultOddArrEl(int[] array)
        {
            int wait = 1;
            foreach (int i in array)
            {
                if (i % 2 != 0)
                    wait *= i;
            }
            return wait;
        }
    }
}
