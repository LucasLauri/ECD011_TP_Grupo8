using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECD011_TP_Grupo8.src.math
{
    public class Subtract : MathOperation
    {
        /// <summary>
        /// Subtrai os números em <see cref="MathOperation.Numbers"/> na ordem em que aparecem
        /// </summary>
        /// <returns>A subtração de cada número em <see cref="MathOperation.Numbers"/></returns>
        public override double Run()
        {
            double ret = 0;

            if (Numbers.Count >= 1)
            {
                ret = Numbers[0];

                for (int i = 1; i < Numbers.Count; i++)
                    ret -= Numbers[i];
            }

            return ret;
        }
    }
}
