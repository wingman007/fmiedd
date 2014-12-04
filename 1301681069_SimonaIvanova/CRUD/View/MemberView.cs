using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD
{
    class MemberView
    {
        Operations oprarations = new Operations();
        public void Read()
        {
            oprarations.Read();
            Console.ReadKey(true);
        }
    }
}
