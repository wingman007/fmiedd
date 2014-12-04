using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace StudentInformationSystemCRUDWinForms
{
    static class Authentication
    {
        private static SqlConnection conn = new SqlConnection("Data Source=SANSAAE-PC\\SQLEXPRESS;Initial Catalog=Students;Integrated Security=True");
        private static SqlCommand command;
        private static SqlDataReader reader;
        public static int Role_id { get; private set; }
        public static bool IsLog { get; private set; }

        public static void Check(string name, string pass)
        {
            IsLog = false;
            command = new SqlCommand("Select role_id from Students s left join Roles r on s.role_id=r.ID where Fname=@name and Password=@pass ", conn);

            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@pass", pass);

            conn.Open();
            command.ExecuteNonQuery();
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                Role_id = reader.GetInt32(0);
                IsLog = true;
            }

            conn.Close();
        }
    }
}
