using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_数组练习题
{
    class Program
    {
        static void Main(string[] args)
        {
            //练习1：从一个整数数组中取出最大的整数,最小整数,总和,平均值

            int[] intArr = { -5, 6, 89, 12, 7, 3 };
            int maxV = int.MinValue;  //最大数
            foreach (var item in intArr)
            {
                if (maxV < item) {
                    maxV = item;
                }
            }
            Console.WriteLine("Max value : "+maxV);

            int minV = int.MaxValue;  //如果数组里面没有元素 这样就报错了
            for (int i = 0; i < intArr.Length; i++)
            {
                if (minV > intArr[i])
                    minV = intArr[i];
            }
            Console.WriteLine("Min value : " + minV);
            int sum = 0;        //总和
            for (int i = 0; i < intArr.Length; i++)
            {
                sum += intArr[i];
            }
            Console.WriteLine("sum : " + sum);
            Console.WriteLine("平均值 : " + (sum/ (float)intArr.Length));



            //练习2:数组里面都是人的名字,分割成:例如:老杨|老苏|老邹…”
            //(老杨, 老苏, 老邹, 老虎, 老牛, 老蒋, 老王, 老马)
            string[] names = { "老杨", "老苏", "老邹", "老虎", "老牛", "老蒋", "老王", "老马" };
            string result = "";
            for (int i = 0; i < names.Length-1; i++)
            {
                result += names[i] + "|";
            }
            result += names[names.Length - 1];
            Console.WriteLine(result);

            //练习3：将一个整数数组的每一个元素进行如下的处理：如果元素是正数则将这个位置的元素的值加1，
            //如果元素是负数则将这个位置的元素的值减1,如果元素是0,则不变。
            int[] nums = { -5, -8, 3, 9, 0, -15, 0, 9 };
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0)
                {
                    nums[i] = nums[i] + 1;
                }
                else if (nums[i] < 0) {
                    nums[i] = nums[i] - 1;
                }
            }
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(i+":"+nums[i]);
            }
            //练习4：将一个字符串数组的元素的顺序进行反转。{“我”,“是”,”好人”}  {“好人”,”是”,”我”}。
            string[] strArr = { "hello","张三","nihao","雪花"};
            for (int i = 0; i < strArr.Length/2; i++)
            {
                //临时存储需要交换的后面那个元素的值
                string temp = strArr[strArr.Length - 1 - i];
                strArr[strArr.Length - 1 - i] = strArr[i];
                strArr[i] = temp;
            }
            for (int i = 0; i < strArr.Length; i++)
            {
                Console.WriteLine(i+" : "+strArr[i]);
            }

            Console.ReadKey();
        }
    }
}
