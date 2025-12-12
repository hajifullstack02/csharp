using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectA
{
    class ClassC
    {
        public void DisplayClassCMembers()
        {
            Console.WriteLine("Inside Class C:");

            ClassA classA = new ClassA();
            //Console.WriteLine(classA.privateVar);  // ❌ Not Accessible
            //Console.WriteLine(classA.protectedVar);  // ❌ Not Accessible
            Console.WriteLine(classA.internalVar);  //✅ Accessible
            Console.WriteLine(classA.protectedInternalVar);  //✅ Accessible
            Console.WriteLine(classA.publicVar);  //✅ Accessible
        }
    }
}