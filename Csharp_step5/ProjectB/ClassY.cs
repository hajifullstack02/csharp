using System;
using ProjectA;

namespace ProjectB
{
    class ClassY
    {

        public void DisplayClassYMembers()
        {
            Console.WriteLine("Inside Class Y:");

            ClassA classA = new ClassA();
            //Console.WriteLine(classA.privateVar);  // ❌ Not Accessible
            //Console.WriteLine(classA.protectedVar);  // ❌ Not Accessible
            //Console.WriteLine(classA.internalVar);  // ❌ Not Accessible
            //Console.WriteLine(classA.protectedInternalVar);  // ❌ Not Accessible
            Console.WriteLine(classA.publicVar);      //✅ Accessible

        }
    }
}