using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample1
{
    class Calc
    {

        public int Add(int left_operand, int right_operand)
        {
            return left_operand + right_operand;
        }


        public int Div(int left_operand,int right_operand)
        {
            return left_operand / right_operand;
        }


        public double DivB(double left_operand,double right_operand)
        {
            return left_operand / right_operand;
        }

        public float DivD(float left_operand, float right_operand)
        {
            return left_operand / right_operand;
        }

    }
}
