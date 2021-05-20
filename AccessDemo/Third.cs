using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessDemo2
{
    class Third : ConsoleApp7.AccessSpecifiers
    {
        static void Main(string[] args)
        {
            Third p = new Third();
            p.ProtectedM(); p.ProtectedInternalM(); p.PublicMethod();
        }
    }
}