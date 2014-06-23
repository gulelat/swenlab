using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SwenUI.Classes;

namespace SwenUI
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void loginbtn_Click(object sender, EventArgs e)
        {
            string username = usertbx.Text;
            string password = pwtbx.Text;
            Staff s = new Staff();
            s = SWENDbmanager.UserLogin(username,password);
            
            if (s == null)
            {
                lblfail.Text = "Invalid Username or Password..";
            }
            else
            {
                string staffnum = Convert.ToString(s.Staffnum);
                Response.Redirect("HomePage.aspx?staffnum=" + staffnum);
            }
            
        }
    }
}