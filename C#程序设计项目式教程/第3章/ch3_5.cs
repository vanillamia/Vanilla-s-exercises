using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch3_5
{ 
    public class Student
    {
        ///姓名字段
        private string name;
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        ///学号字段
        private string id;
        public string Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        ///电话字段
        private string phone;
        public string Phone
        {
            get
            {
                return phone;
            }

            set
            {
                phone = value;
            }
        }

        ///出生日期字段
        private DateTime birthday;
        public DateTime Birthday
        {
            get
            {
                return birthday;
            }

            set
            {
                birthday = value;
            }
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Student stu1 = new Student();
            Student stu2 = new Student();
            stu1.Name = "张三";
            stu1.Id = "120040600";
            stu2.Name = "李四";
            stu2.Id = "120040059";
            Console.WriteLine("第一个学生的姓名是：{0}，学号是{1}", stu1.Name, stu1.Id);
            Console.WriteLine("第二个学生的姓名是：{0}，学号是{1}", stu2.Name, stu2.Id);
            Console.ReadLine();
        }
    }
}
