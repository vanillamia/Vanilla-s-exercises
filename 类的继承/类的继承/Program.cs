using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch4_1
{
    ////////////////////////////////////////////////////
    class Vehicle
    {
        protected int wheels; //公有成员：轮子个数
        protected float weight; //保护成员：重量
        public Vehicle() { }
        public Vehicle(int w, float g)
        {
            wheels = w;
            weight = g;
        }
        public void Speak()
        {
            Console.WriteLine("交通工具的轮子个数是可以变化的！");
        }
    }
    ////////////////////////////////////////////////////
    class Car : Vehicle //轿车类：从汽车类中继承
    {
        int passengers; //私有成员：乘客数
        public Car(int w, float g, int p)
            : base(w, g)
        {
            wheels = w;
            weight = g;
            passengers = p;
        }
    }
    ////////////////////////////////////////////////////

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
