using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePhonebookDB.Entity
{
    public class User
    {
        public Int32 ID { get; set; }
        public String Username { get; set; }
        public String Password { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }

        public override string ToString()
        {
            if (this.FirstName != string.Empty && this.LastName != string.Empty)
                return this.FirstName + " " + this.LastName;
            else return this.Username;
                
        }
    }
}
