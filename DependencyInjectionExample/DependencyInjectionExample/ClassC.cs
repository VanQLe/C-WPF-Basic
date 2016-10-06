using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionExample
{
    public class ClassC
    {
        private readonly IClassA mA;
        private readonly IClassB mB;
        public ClassC(IClassA a, IClassB b)
        {
            mA = a;
            mB = b;
        }
    }
}
