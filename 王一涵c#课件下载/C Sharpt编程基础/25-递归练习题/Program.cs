using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_递归练习题
{
    class Program
    {
        static void Main(string[] args)
        {
           int rs = JieCheng(5);

            int rs1 = FeiBo(6);
            Console.WriteLine(rs1);
            Console.ReadKey();
        }
        public static int FeiBo(int n) {
            if (n < 1) return 0;
            if (n == 1) {
                return 2;
            }
            if (n == 2) {
                return 3;
            }
            return FeiBo(n - 1) + FeiBo(n - 2);
        }
        public static int JieCheng(int n) {
            if (n < 1) {
                return 0;
            }
            if(n== 1) {
                return 1;
            }
            return n * JieCheng(n - 1);
        }
    }
}
