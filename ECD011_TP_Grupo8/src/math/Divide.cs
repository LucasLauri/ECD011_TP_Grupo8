using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECD011_TP_Grupo8.src.math
{
    public  class Divide : MathOperation
    {

        /// <summary>
        /// Executa a divisão dos números em <see cref="MathOperation.Numbers"/> na ordem em que aparecem
        /// </summary>
        /// <returns>A divisão dos números em <see cref="MathOperation.Numbers"/> na ordem em que aparecem</returns>
        /// <exception cref="DivideByZeroException">Um dos denominadores em <see cref="MathOperation.Numbers"/> é igual a zero!</exception>
        public override double Run()
        {
            double ret = 0;

            //Verifica de antemão se um divisão por zero iria ocorrer
            for (int i = 1; i < Numbers.Count; i++)
                if (Numbers[i] == 0)
                    throw new DivideByZeroException("Um dos denominadores é igual a zero!");
            

            if (Numbers.Count >= 1)
            {
                ret = Numbers[0];

                for (int i = 1; i < Numbers.Count; i++)
                    ret /= Numbers[i];
            }

            return ret;
        }
    }
}
