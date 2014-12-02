using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD
{
    class DataConnection
    {
        protected static string connstring = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=|DataDirectory|\\UserDataBase.mdf;Integrated Security=True";
        public string ConnString()
        {
            return connstring;
        }
    }
}
