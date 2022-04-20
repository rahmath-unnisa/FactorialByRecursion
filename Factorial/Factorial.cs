using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    public class Factorial
    {
            int result = 1;
            int num = Convert.ToInt32(Console.ReadLine());
            public int Recursion()
            {
                if (num == 0)
                {
                    return 1;
                }
                result = result * num;
                num--;
                Recursion();
                return result;
            }


        }
    }
