using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_数组
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArr = new int[10];
            intArr[7] = 10;
            Console.WriteLine(intArr[7]);

            int[] nums1 = new int[10];   //声明的时候，我们就确定了数组的类型和长度
            int[] nums2 = { 1, 2, 3, 4, 5 };//声明的时候，直接初始化了，知道类型，长度和值


            int[] nums3 = new int[4] { 1, 2, 3, 4};  //知道长度  类型，和值 
            int[] nums4 = new int[] { 1, 2, 3, 4 };  //知道长度  类型，和值 

            //声明一个string类型的数组，长度是3，值是"hello", "world", "nihao"
            //声明的时候初始化 用{}，里面的元素 用逗号隔开
            //通过下表访问数据  数组名[下标]
            string[] strArr = { "hello", "world", "nihao" };
            Console.WriteLine(strArr[1]);
            //Console.WriteLine(strArr[3]);   //如果下表不存在，会有下表越界的异常


            int[] nums5 = new int[7];
            //nums5[0] = 1;
            //nums5[1] = 2;
            //nums5[2] = 3;
            //nums5[3] = 4;
            //nums5[4] = 5;
            //用循环的方式给数组赋值
            //可以用 数组名.Length  获取数组的长度
            for (int i = 0; i < nums5.Length; i++)
            {
                nums5[i] = i + 1;
            }
            nums5[3] = 40;
            //取值
            for (int i = 0; i < nums5.Length; i++)
            {
                Console.WriteLine(i+" = "+ nums5[i]);
            }

            foreach (var item in nums5)
            {
                Console.WriteLine("foreach : "+item);
            }

            //int a;
            //int b = 5;

            //var aa;  
            //var bb = 5; 

            Console.ReadKey();
        }
    }
}
