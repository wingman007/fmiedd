using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CRUD2.Models;

namespace CRUD2
{
    public partial class MemberForm : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

            try
            {
                Repo r = new Repo();
                gridUsers.DataSource = r.List();
                gridUsers.DataBind();

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }
        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {



        }
    }
}