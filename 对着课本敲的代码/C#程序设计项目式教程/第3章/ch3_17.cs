using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 在这里伦家再来回顾一下参数的传递方式：①按值传递 ②引用传递 ③ref引用参数 ④输出参数
/// </summary>
namespace ch3_17
{ 
    class Program
    {
        static void Change(int[] pArray)
        {
            pArray[0] = 888;
            Console.WriteLine("方法内0号元素值为{0}", pArray[0]);
        }

        static void Main(string[] args)
        {
            //先定义一个数组
            int[] arr = { 1, 4, 5 };
            //然后伦家把它传入方法
            Change(arr);
            Console.WriteLine("来看一看新的值是多少吧！\n {0}", arr[0]);
            Console.ReadKey;
        }
    }

}
