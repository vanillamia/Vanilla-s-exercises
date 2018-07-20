using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 随机获得10个学生的等级
{

    public class StudentLevel
    {
        //【字段】//学生有5个等级，用stuLevel表示，等级仅影响每个学生入校时的初始值
        //public int stuLevel = 1;
        //【字段】//p用来控制各个等级的几率，随着游戏进行可以被改变（先当它常量）
        static double p = 0.5;
        //每个学生随机产生一个等级，定义一个随机数种子
        Random p_r = new Random();

        //【方法】//随机获得一个学生的等级
        public int GeneStuLevel()
        {
            //生成一个1到12的随机数,然后乘以概率
            double i = p*(p_r.Next(1, 13));
            if (i >= 5.0)
                return 5;
            else if (i >= 4.0)
                return  4;
            else if (i >= 3.0)
                return  3;
            else if (i >= 2.0)
                return 2;
            else
                return 1;
        }

        //Random r = new Random();
        //int lev1Default = 1;
        //int lev2Default = 51;
        //int lev3Default = 81;
        //int lev4Default = 121;
        //int lev5Default = 151;
    }

    class Program
    {
        static void Main(string[] args)
        {
            StudentLevel test = new StudentLevel();
            for(int m = 0; m <= 10; m++)
            {
                int i = test.GeneStuLevel();
                Console.WriteLine("随机生成一个学生的等级是：{0}", i);
            }
            Console.ReadLine();

        }
    }
}
