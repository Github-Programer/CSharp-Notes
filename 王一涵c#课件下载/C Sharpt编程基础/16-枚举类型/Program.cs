using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_枚举类型
{
    //使用enum 关键字声明一个枚举类型，
    //里面有两个值，分别是Male，Female
    //pascal 命名规则
    enum Gender {
        Male,       //男
        Female
    }
    //枚举类型，里面默认存储的是int，并且，后面的值总是前面的值+1
    //修改枚举类型 在声明枚举 名字后面 : short
    enum QQState : short{
        Online = 1,
        Offline,
        Hidden,
        Leave,
        Busy
    }
    class Program
    {
        static void Main(string[] args)
        {
            // 男 女
            // 0  1 ，male  female   ，男，女

            int a = 15;
            Gender gender = Gender.Male;   //枚举类型赋值
            gender = Gender.Female;

            //online offline  hiden;   0  1  2
            //可读性 差
            //int state = 0;
            //if (state == 0) {
            //    Console.WriteLine("在线状态");
            //}
            //state = 3;
            //QQState state = QQState.Online;
            //if (state == QQState.Online) {
            //    Console.WriteLine("在线状态");
            //}
            #region int 和枚举之间相互转换
            //枚举类型和int类型是相互兼容的，所有可以使用强制类型转换
            //int state = (int)QQState.Online;
            //Console.WriteLine(state);
            //Console.WriteLine((int)QQState.Offline);
            //Console.WriteLine((int)QQState.Hidden);
            //Console.WriteLine((int)QQState.Leave);
            //Console.WriteLine((int)QQState.Busy);


            //int 转枚举
            // 根据枚举的值进行转换，如果值不存在，就不转换，也不报错
            //QQState qq = (QQState)5;
            //QQState qq = (QQState)10;
            //Console.WriteLine(qq);
            #endregion

            //枚举转字符串  枚举转字符串，直接.ToString()
            QQState state = QQState.Online;
            Console.WriteLine(state.ToString());

            //字符串转枚举
            string str = "123";
            int myInt = int.Parse(str);


            //字符串转枚举Enum.Parse(),参数1：需要传入目标类型，typeof 获取类型，强转

            QQState state1 = (QQState)Enum.Parse(typeof(QQState), "10");
            Console.WriteLine("state1 = "+state1);

            //无论是字符串类型的数字，还是普通数字，转枚举，如果值不匹配，不会报异常，
            //但是如果转的字符串 不匹配，会报异常
            //QQState state2 = (QQState)Enum.Parse(typeof(QQState), "hello");
            //Console.WriteLine("state2 = " + state2);

            Console.WriteLine("请输入你的qq状态 ，1 - 在线，2 - 离线，3 - 隐身，4 - 离开，5 - 忙碌");
            string stateStr = Console.ReadLine();
            QQState state3 = (QQState)Enum.Parse(typeof(QQState), stateStr);
            switch (state3) {
                case QQState.Online:
                    Console.WriteLine("在线状态");
                    break;
                case QQState.Offline:
                    Console.WriteLine("离线状态");
                    break;
                case QQState.Hidden:
                    Console.WriteLine("隐身状态");
                    break;
                case QQState.Leave:
                    Console.WriteLine("离开状态");
                    break;
                case QQState.Busy:
                    Console.WriteLine("忙碌状态");
                    break;

            }
            Console.ReadKey();
        }
    }
}
