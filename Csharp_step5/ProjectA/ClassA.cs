using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectA
{
    public class ClassA
    {
        private string privateVar = "Private: Only accessible within the class.";
        protected string protectedVar = "Protected: Accessible in derived classes.";
        internal string internalVar = "Internal: Accessible within the same assembly.";
        protected internal string protectedInternalVar = "Protected Internal: Accessible in same assembly or derived class of another Assembly.";
        public string publicVar = "Public: Accessible everywhere.";



        void DisplayBaseClassMembers()
        {
            Console.WriteLine("Inside Class A:");
            Console.WriteLine(privateVar);    // ✅ Accessible
            Console.WriteLine(protectedVar);  //✅ Accessible
            Console.WriteLine(internalVar);  //✅ Accessible
            Console.WriteLine(protectedInternalVar);  //✅ Accessible
            Console.WriteLine(publicVar);  //✅ Accessible
        }

    }


}