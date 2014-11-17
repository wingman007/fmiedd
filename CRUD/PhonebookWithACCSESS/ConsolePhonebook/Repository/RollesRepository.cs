using ConsoleLibrary.Entity;
using ConsolePhonebook.Entity;
using ConsolePhonebook.Service;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLibrary.Repository
{
  public  class RollesRepository
    {
        private OleDbConnection myconn = new OleDbConnection(AuthenticationService.connectionstring);

        public string GetRolleByUserId(int userId)
        {
            
            Rolles rolle = new Rolles();
            OleDbParameter rolles = new OleDbParameter("@userID", userId);


            string oString = @"Select * from Rolles where userID=@userID";
            OleDbCommand oCmd = new OleDbCommand(oString, myconn);
            oCmd.Parameters.Add(rolles);
           

            try
            {
                myconn.Open();
                OleDbDataReader oReader = oCmd.ExecuteReader();

                while (oReader.Read())
                {
                    rolle.RolleId = Convert.ToInt32(oReader["rolleID"]);
                    rolle.RolleName = oReader["rollename"].ToString();
                   
                }

                oReader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {

                myconn.Close();
            }


            return rolle.RolleName;
        }

    }
}
