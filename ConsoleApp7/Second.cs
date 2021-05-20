using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Second
    {
        public static void Main()
        {
            AccessSpecifiers t = new AccessSpecifiers();
            t.InternalM();t.ProtectedInternalM();
            t.PublicMethod();
        }
    }
}