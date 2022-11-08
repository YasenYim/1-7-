using System;

namespace _1_7_函数
{
    class Program
    {
        // 1.写出简单加、减、乘、除函数，注意返回值
        static int Add(int a, int b)
        {
            return a + b;
        }

        static int Sub(int a, int b)  // 这里的a和b都是临时的名字
        {
            return a - b;
        }

        static int Mul(int a, int b)
        {
            return a * b;
        }

        static float Div(int a, int b)
        {
            //return (float)a / b;
            return a * 1.0f / b;       // a * 1.0f 已经改成了浮点数了
        }


        // 输入数字，如果错误重新输入
        static int InputNum()
        {
            while (true)
            {
                Console.WriteLine("请输入一个数字：");
                string input = Console.ReadLine();

                int num;
                bool success = int.TryParse(input, out num); // out输出参数

                if (!success)
                {
                    Console.WriteLine("数字格式不正确，请重新输入");
                    continue;    // continue的意思是不再执行循环体后面的内容，直接开始下一次循环string input  = Console.ReadLine();如果成功了就会return num;
                }   

                return num;


            }
        }
        static void Main(string[] args)
        {
            //int a = Add(3, 5);   // a == 8
            //int b = Add(a, 8);   // b == 16
            //int c = Sub(a, b);   // c == -8
            //float d = Divide(8, 3);
            //Console.WriteLine("d=" + d);

            int a = InputNum();
            int b = InputNum();

            Console.WriteLine($"和为：{Add(a, b)}");
            Console.WriteLine($"差为：{Sub(a, b)}");
            Console.WriteLine($"积为: {Mul(a, b)}");
            Console.WriteLine($"商为：{Div(a, b)}");

            Console.ReadKey();
        }
    }
}
// Wechat : NikoLua
// email:1209424096@qq.com && yyf182z@gmail.com