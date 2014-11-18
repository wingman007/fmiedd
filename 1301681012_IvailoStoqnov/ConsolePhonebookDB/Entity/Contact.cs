using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePhonebookDB.Entity
{
    public class Contact
    {
        public Int32 ID { get; set; }
        public Int32 UserId { get; set; }
        public String Phone { get; set; }

        public override string ToString()
        {
            return this.Phone;
        }
    }
}
