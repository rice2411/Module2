using System;
using System.Text;
namespace PhuongTrinhBac2
{
    class PTBac2
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            double a, b, c;
            Console.WriteLine("Nhập giá trị a: ");
            a = Double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập giá trị b: ");
            b = Double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập giá trị c:");
            c = Double.Parse(Console.ReadLine());
            QuadraticEquation ptb2 = new QuadraticEquation(a, b, c);
            if(a==0)
            {
                Console.WriteLine("Đây không phải là phương trình bậc 2");
            }  else
            {
                Console.WriteLine("Phương trình của bạn là: {0}x^{1}+{2}x+{3}", a, 2, b, c);
                if(ptb2.GetDiscriminant()<0)
                {
                    Console.WriteLine("Phương tình vô nghiệm");
                }  else if(ptb2.GetDiscriminant() == 0)
                {
                    Console.WriteLine("Phương trình có một nghiệm kép: {0}", ptb2.result3());
                }  else
                {
                    Console.WriteLine("Phương tình có 2 nghiệm phân biệt: {0},{1}", ptb2.result(), ptb2.result2());

                }    
                    
            }    
        }
        public class QuadraticEquation
        {
            double a, b,c, delta, rs,rs2,rs3;


            public QuadraticEquation(double a, double b,double c)
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }
            public double GetDiscriminant()
            {
                 this.delta = (Math.Pow(this.b, 2) - 4 * (this.a * this.c));
                return this.delta;
            }

            public double result ()
            {
                this.rs =(-b + Math.Sqrt(this.delta) / 2 * a);
                return this.rs;

            }
            public double result2()
            {
                this.rs2 = (-b - Math.Sqrt(this.delta) / 2 * a);
                return this.rs2;

            }
            public double result3()
            {
                this.rs3 = (-b / 2 * a);
                return this.rs3;

            }
        }
    }
}
