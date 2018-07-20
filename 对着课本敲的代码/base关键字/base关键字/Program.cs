using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch4_11
{
/////////////////基类Person/////////////////////
    public class Person
    {
        protected string strid = "42280101010111";
        protected string strname = "张三";
        public virtual void GetInfo()
        {
            Console.WriteLine("姓名：{0}", strname);
            Console.WriteLine("身份证号：{0}", strid);
        }
    }
////////////////子类Student，继承基类////////////
    public class Student:Person
    {
        public string sno = "1303589";
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine("学号：{0}", sno);
        }
    }
///////////////////主程序从这里开始//////////////
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.GetInfo();
            Console.ReadKey();
        }
    }
}
