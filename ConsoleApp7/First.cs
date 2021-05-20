using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class First : AccessSpecifiers
    {
        public static void Main()
        {
            First c = new First();
            c.InternalM();c.ProtectedM();c.ProtectedInternalM();c.PublicMethod();
        }
    }
}