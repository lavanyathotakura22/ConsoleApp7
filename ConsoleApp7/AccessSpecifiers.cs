using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class AccessSpecifiers
    {
        private void PrivateM()
        {
            Console.WriteLine("This is Private Method");
        }

        internal void InternalM()
        {
            Console.WriteLine("This is Internal Method");
        }

        protected void ProtectedM()
        {
            Console.WriteLine("This is Protected Method");
        }

        protected internal void ProtectedInternalM()
        {
            Console.WriteLine("This is Protected internal Method");
        }

        public void PublicMethod()
        {
            Console.WriteLine(" This is Public Method");
        }
        static void Main(string[] args)
        {
            AccessSpecifiers p = new AccessSpecifiers();
            //p.PrivateMethod()
            //p.PublicMethod()

        }
    }
}