using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch3_46
{
    class Student
    {
        private string sname;
        private string sno;
        private string sphone;

        public string Sname
        {
            get
            {
                return sname;
            }

            set
            {
                sname = value;
            }
        }

        public string Sno
        {
            get
            {
                return sno;
            }

            set
            {
                sno = value;
            }
        }

        public string Sphone
        {
            get
            {
                return sphone;
            }

            set
            {
                sphone = value;
            }
        }
    }

    //班级类
    class StudentClass
    {
        public Student[] students = new Student[48];
        public Student this[int i]
        {
            get
            {
                if ((i >= 0) && (i < students.Length))
                {
                    return students[i];
                }
                else
                {
                    return null;
                }
            }
            set
            {
                if ((i >= 0) && (i < students.Length))
                {
                    students[i] = value;
                }
            }
        }
    }
    


    class Program
    {
        static void Main(string[] args)
        {
            Student s3;
            s3 = new Student();
            s3.Sname = "wx";
            s3.Sno = "120701";

            Student s4;
            s4 = new Student();
            s3.Sname = "zq";
            s3.Sno = "120702";

            StudentClass cs1207;
            cs1207 = new StudentClass();
            cs1207[0] = s3;
            cs1207[1] = s4;
        }
    }


}
