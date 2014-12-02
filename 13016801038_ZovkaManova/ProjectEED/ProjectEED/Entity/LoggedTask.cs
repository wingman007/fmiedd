using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEED.Entity
{
    class LoggedTask
    {
        public int ID { get; set; }

        public int ParentUserID { get; set; }

        public string Task { get; set; }

        public double LoggedTime { get; set; }

        public bool Finsihed { get; set; }

        public override string ToString()
        {
            return Task + "- Finished: "+Finsihed;
        }
    }
}
