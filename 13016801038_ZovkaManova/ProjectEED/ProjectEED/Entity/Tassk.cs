using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEED.Entity
{
   public class Tassk
    {
       public int ID { get; set; }
       public int ParentUserID { get; set; }

       public string Name { get; set; }

       public string Description { get; set; }

       public override string ToString()
       {
           return Name;
       }
    }
}
