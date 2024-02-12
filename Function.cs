using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionLibrary
{
    public class Function
    {
        private double k;
        private double N;
        private int count;

        public Function(double k, double N, int count)
        {
            this.k = k;
            this.N = N;
            this.count = count;
        }

        public void CalculateFunction()
        {

            double y;
            double x = 0;
            for (int i = 0; i < count; i++)
            {
                try
                {
                    Console.WriteLine("Итерация №{0}", i+1);

                    y = 1 / (x - N);

                    if (Math.Abs(x - N) == 0)
                    {
                        throw new ArithmeticException("Деление на ноль");
                    }
                    else if ((x >= k) && (i < count))
                    {
                        throw new ArithmeticException("Выход за пределы диапазона");
                    }

                    if (x < k)
                    {
                        x += 0.1;
                    }

                    Console.WriteLine("x = " + x + " f(x) = " + y);
                }
                catch (ArithmeticException e)
                {
                    Console.WriteLine(e);
                }
                finally
                {
                    Console.WriteLine("Программа завершена.");
                }
            }
        }
    }
}
