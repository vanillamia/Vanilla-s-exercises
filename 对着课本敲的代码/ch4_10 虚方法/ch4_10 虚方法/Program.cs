using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
///这个例子俺没有看懂，留着以后懂吧QwQ
/// </summary>
namespace ch4_10
{
    
    class MyBase
    {
        public void F()
        {
            Console.WriteLine("MyBase.F");
        }
        public virtual void G()
        {
            Console.WriteLine("MyBase.G");
        }
    }

    class MyDerived: MyBase
    {
        new public void F()
        {
            Console.WriteLine("MyDerived.F");
        }

        public override void G()
        {
            Console.WriteLine("MyDerived.G");
        }
    }

    class Program
    {
        static void Main()
        {
            MyDerived b = new MyDerived();
            MyBase a = b;
            a.F();
            b.F();
            a.G();
            b.G();
            Console.ReadKey();
        }
    }
}

//方法MyBase.G()实际调用了MyDerived.G, 而不是MyBase.G。这是因为编译时值为MyBase，但运行时值为MyDerived，所以MyDerived完成了对方法的实际调用。

