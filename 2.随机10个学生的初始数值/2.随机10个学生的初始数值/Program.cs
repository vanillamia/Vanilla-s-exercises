using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 随机10个学生的初始数值
{
    public class StudentStatus
    {
        //【字段】//学生有5个等级，用stuLevel表示，等级仅影响每个学生入校时的初始值
        //public int stuLevel = 1;
        //【字段】//p用来控制各个等级的几率，随着游戏进行可以被改变（先当它常量）
        //学校声誉越高，p也就越大（算法以后再考虑(・//ω//・))
        static double p = 0.5;

        //每个学生随机产生一个等级，定义一个随机数种子
        Random p_r = new Random();
        //每个等级的数值也需要随机，再来个种子
        Random p_status = new Random();

        //【方法】//随机获得一个学生的等级
        public int GeneStuLevel()
        {
            //生成一个1到12的随机数,然后乘以概率
            double i = p * (p_r.Next(1, 13));
            if (i >= 5.0)
                return 5;
            else if (i >= 4.0)
                return 4;
            else if (i >= 3.0)
                return 3;
            else if (i >= 2.0)
                return 2;
            else
                return 1;
        }

        //【方法】//获得每个学生的等级和四项属性
        public void GeneStuStatus(out int stuLevel, out int stu, out int spo, out int reser, out int cha)
        {
            stuLevel = this.GeneStuLevel(); //随机生成介个学生的等级
            int[] levelStatus = new int[5] { 1, 51, 81, 121, 151 }; //5个等级的初始值，以后说不定会改啦(・//ω//・)

            switch (stuLevel)
            {
                case 1:
                    stu = levelStatus[0] + (int)(50 * (p_status.NextDouble()));
                    spo = levelStatus[0] + (int)(50 * (p_status.NextDouble()));
                    reser = levelStatus[0] + (int)(50 * (p_status.NextDouble()));
                    cha = levelStatus[0] + (int)(50 * (p_status.NextDouble()));
                    break;

                case 2:
                    stu = levelStatus[1] + (int)(30 * (p_status.NextDouble()));
                    spo = levelStatus[1] + (int)(30 * (p_status.NextDouble()));
                    reser = levelStatus[1] + (int)(30 * (p_status.NextDouble()));
                    cha = levelStatus[1] + (int)(30 * (p_status.NextDouble()));
                    break;

                case 3:
                    stu = levelStatus[2] + (int)(40 * (p_status.NextDouble()));
                    spo = levelStatus[2] + (int)(40 * (p_status.NextDouble()));
                    reser = levelStatus[2] + (int)(40 * (p_status.NextDouble()));
                    cha = levelStatus[2] + (int)(40 * (p_status.NextDouble()));
                    break;

                case 4:
                    stu = levelStatus[3] + (int)(30 * (p_status.NextDouble()));
                    spo = levelStatus[3] + (int)(30 * (p_status.NextDouble()));
                    reser = levelStatus[3] + (int)(30 * (p_status.NextDouble()));
                    cha = levelStatus[3] + (int)(30 * (p_status.NextDouble()));
                    break;

                case 5:
                    stu = levelStatus[4] + (int)(50 * (p_status.NextDouble()));
                    spo = levelStatus[4] + (int)(50 * (p_status.NextDouble()));
                    reser = levelStatus[4] + (int)(50 * (p_status.NextDouble()));
                    cha = levelStatus[4] + (int)(50 * (p_status.NextDouble()));
                    break;

                default:
                    stu = 100;
                    spo = 100;
                    reser = 100;
                    cha = 100;
                    break;
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                //初始化学生的四个属性
                int study = 0;
                int sports = 0;
                int research = 0;
                int charm = 0;
                //初始化学生的等级
                int stuLevel = 1;
                StudentStatus test = new StudentStatus();

                for (int i = 1; i <= 10; i++)
                {
                    test.GeneStuStatus(out stuLevel, out study, out sports, out research, out charm);
                    Console.WriteLine("{0}号学生，等级：【{1}】，学习：{2}，运动：{3}，研究：{4}，魅力：{5}", i, stuLevel, study, sports, research, charm);
                }
                
                Console.ReadLine();

            }
        }
    }
}
