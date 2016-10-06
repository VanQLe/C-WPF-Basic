using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            UnityContainer ioc = new UnityContainer();

            ClassA a = new ClassA() { Message = "Testing value" };
            ClassB b = new ClassB() { Number = 93249499 };
            ClassA a1 = new ClassA() { Message = "Hello World" };

            ioc.RegisterInstance(b);
            //ioc.RegisterInstance(a1);//register ClassA
            //ioc.RegisterInstance(a);
            //ioc.RegisterType<IClassA, ClassA>();

            ioc.RegisterType<IClassB, ClassB>();
            ioc.RegisterType<IClassA, ClassA>(new ContainerControlledLifetimeManager());

            ClassA a2 = ioc.Resolve<ClassA>();///do this to register ClassA using ContainerControlledLifetimeManager.
            a2.Message = "Testing ioc";


            ClassA asdsada = ioc.Resolve<ClassA>();///do this to register ClassA using ContainerControlledLifetimeManager.
            a2.Message = "Testasdadsadsadasing ioc";
            //ClassC c = new ClassC(a, b);
            //ClassC c1 = new ClassC(new ClassA(), new ClassB());
            ClassC c = ioc.Resolve<ClassC>();//generate  ClassC and resolve any dependency that ClassC needs

        }
    }
}
