using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECD011_TP_Grupo8.src.math
{
    public class Add : MathOperation
    {
        public Add() : base("+")
        {
        }

        /// <summary>
        /// Soma os valores em <see cref="MathOperation.Numbers"/>
        /// </summary>
        /// <returns>A soma dos valores em <see cref="MathOperation.Numbers"/></returns>
        public override double Run()
        {
            double ret = 0;

            foreach(double number in Numbers)
                ret += number;

            return ret;

        }
    }
}
