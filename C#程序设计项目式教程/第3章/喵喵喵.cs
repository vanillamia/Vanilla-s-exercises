using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch3_15
{ 
    class Program
    {
        static int CalcSquare(int nSideLength)
        {
            return nSideLength * nSideLength;
        }

        static void Main(string[] args)
        {
            ///mi
            Console.WriteLine("the area of the square is:{0}", CalcSquare(25).ToString());
            Console.ReadKey;
        }
    }

}
