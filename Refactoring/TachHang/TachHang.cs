using System;

namespace TachHang
{
    class TachHang
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calculate(1, 1, '+'));
        }
        public static int Calculate(int firstOperand, int secondOperand, char mathOperator)
        {
            switch (mathOperator)
            {
                case '+':
                    return firstOperand + secondOperand;
                case '-':
                    return firstOperand - secondOperand;
                case '*':
                    return firstOperand * secondOperand;
                case '/':
                    if (secondOperand != 0)
                        return firstOperand / secondOperand;
                    else
                        throw new Exception("Can not divide by 0");
                default:
                    throw new Exception("Unsupported operation");
            }
        }
    }
}
