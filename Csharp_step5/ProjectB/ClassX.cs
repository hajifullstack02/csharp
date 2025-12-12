using System;
using ProjectA;

namespace ProjectB
{
    class ClassX : ClassA
    {
        void DisplayClassXMembers()
        {
            Console.WriteLine("Inside Class X (Derived):");

            //Console.WriteLine(privateVar);  // ❌ Not Accessible
            Console.WriteLine(protectedVar);  // ✅ Accessible
            //Console.WriteLine(internalVar);  // ❌ Not Accessible
            Console.WriteLine(protectedInternalVar);  //✅ Accessible
            Console.WriteLine(publicVar);  //✅ Accessible
        }
    }
}