using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 在这里伦家再来回顾一下参数的传递方式：①按值传递 ②引用传递 ③ref引用参数 ④输出参数
/// </summary>
namespace ch3_16
{ 
    class Program
    {
        static int CalcSquare(int nSideLength)
        {
            return nSideLength * nSideLength;
        }

        static void Main(string[] args)
        {
            ///喵喵喵，这里有几点要注意的喵。
            ///一是双引号的反引号所在的位置！！在传入的变量的前面！！不在整个括号的最后！！
            ///二是方法原来可以直接作为参数传入啊CalcSquare(25)
            ///最后是ToString，前面是.点号，后面带括号喵喵，带括号喵喵！
            Console.WriteLine("the area of the square is:{0}", CalcSquare(25).ToString());
            Console.ReadKey;
        }
    }

}
