using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectA
{
    class ClassB : ClassA
    {
        public void DisplayDerivedClassMembers()
        {
            Console.WriteLine("Inside Class B:");
            //Console.WriteLine(privateVar);  // ❌ Not Accessible
            Console.WriteLine(protectedVar);  //✅ Accessible
            Console.WriteLine(internalVar);  //✅ Accessible
            Console.WriteLine(protectedInternalVar);  //✅ Accessible
            Console.WriteLine(publicVar);  //✅ Accessible
        }
    }
}