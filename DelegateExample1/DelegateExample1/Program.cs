using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExample1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass();
            obj.LongRunning(Method1);

        }

        static void Method(int i)
        {
            Console.WriteLine(i);
        }
        static void Method1(string i)
        {
            Console.WriteLine(i);
        }
    }

    public class MyClass
    {
        public delegate void a(string i);
        public void LongRunning(a obj)
        {
            for (int i = 0; i < 1000; i++)
            {
                obj(i.ToString());
            }
        }
    }

}
