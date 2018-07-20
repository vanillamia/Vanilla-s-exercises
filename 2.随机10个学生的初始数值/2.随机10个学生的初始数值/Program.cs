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
        //学生外向还是内向，男性还是女性
        Random p_sex = new Random();
        Random p_per = new Random();
        //学生是同性恋还是异性恋
        Random p_ori = new Random();
        //随机抽取一个名字
        


        private string GetName()
        {
            //从列表中取得一个名字
            if (p_sex.NextDouble() < 0.5)
                return "男生";
            else
                return "女生";
        }

        //【方法】从List中拿出一个名字，然后删掉该名字
       

        //【方法】//随机获得一个学生的等级
        private int GeneLev()
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

        private string GeneSex()
        {
            //50%几率男，50%几率女
            if (p_sex.NextDouble() < 0.5)
                return "男生";
            else
                return "女生";
        }

        private string GenePer()
        {
            //50%几率外向，50%几率内向
            if (p_per.NextDouble() < 0.5)
                return "外向";
            else
                return "内向";
        }

        private string GeneOri()
        {
            //80%几率异性恋，20%几率同性恋
            int pro_sexOrient = 80;
            if (p_sex.Next(100) < pro_sexOrient)
                return "异性恋";
            else
                return "同性恋";
        }


        //【方法】//获得每个学生的等级和四项属性, 
        public void GeneStuStatus(out int stuLev,out string stuPer, out string stuSex, out string stuSexOri, out int stu, out int spo, out int reser, out int cha)
        {
            
            stuLev = this.GeneLev(); //随机生成介个学生的等级
            stuPer = this.GenePer();//随机生成介个学生的个性
            stuSex = this.GeneSex(); //随机生成介个学生的性别
            stuSexOri = this.GeneOri(); //随机生成介个学生的性取向

            int[] levelStatus = new int[5] { 1, 51, 81, 121, 151 }; //5个等级的初始值，以后说不定会改啦(・//ω//・)

            switch (stuLev)
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
                string stuName, stuSex, stuPersonality, stuSexOrient; 
                //初始化学生的等级
                int stuLevel = 1;
                List<string> allNames = new List<string>();
                string[] names = new string[] { "玩偶", "百合子", "王安泽", "GAL", "lika", "章鱼", "mili", "零", "SB老师", "水管", "世界线","inovker","代码星人" };
                allNames.AddRange(names);
                
            
                StudentStatus test = new StudentStatus();
                List<string> nameList = new List<string>();
                Random r_name = new Random();
                for (int i=0; i < 10; i++) {
                    int m = (int)(r_name.Next(allNames.Count()));
                    nameList.Add(allNames[m]);
                    allNames.RemoveAt(m);
                 }

                for (int i = 1; i <= 10; i++)
                {
                    test.GeneStuStatus(out stuLevel, out stuPersonality, out stuSex, out stuSexOrient, out study, out sports, out research, out charm);
                    stuName = nameList[i - 1];
                    Console.WriteLine("{0, 2}号学生 {1,-6} 等级{2} 学习{3,-3} 运动{4,-3} 研究{5,-3} 魅力{6,-3} {7} {8} {9}", i, stuName, stuLevel, study, sports, research, charm, stuSex, stuPersonality, stuSexOrient);
                }
                
                Console.ReadLine();

            }
        }
    }
}
