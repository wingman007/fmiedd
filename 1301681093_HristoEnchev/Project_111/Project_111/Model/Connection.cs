using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_111.Model
{
    public class Connection
    {
        public OleDbConnection 
            connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Ico-PC\Source\Repos\fmiedd\1301681093_HristoEnchev\Project_111\Project_111\Data\usersDB.accdb;Persist Security Info=False;");
    }
}
