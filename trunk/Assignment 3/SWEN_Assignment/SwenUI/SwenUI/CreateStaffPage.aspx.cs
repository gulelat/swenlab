using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SwenUI.Classes;

namespace SwenUI
{
    public partial class CreateStaffPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void rsvbtn_Click(object sender, EventArgs e)
        {
            string staffnum = Request.QueryString["staffnum"];
            Response.Redirect("SearchReservation.aspx?staffnum=" + staffnum);
        }

        protected void rmbtn_Click(object sender, EventArgs e)
        {
            string staffnum = Request.QueryString["staffnum"];
            Response.Redirect("RoomStatusPage.aspx?staffnum=" + staffnum);
        }

        protected void paybtn_Click(object sender, EventArgs e)
        {
            string staffnum = Request.QueryString["staffnum"];
            Response.Redirect("PaymentPage.aspx?staffnum=" + staffnum);
        }

        protected void rptbtn_Click(object sender, EventArgs e)
        {
            string staffnum = Request.QueryString["staffnum"];
            Response.Redirect("MainReportPage.aspx?staffnum=" + staffnum);
        }

        protected void staffbtn_Click(object sender, EventArgs e)
        {
            string staffnum = Request.QueryString["staffnum"];
            Response.Redirect("StaffPage.aspx?staffnum=" + staffnum);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string staffnum = Request.QueryString["staffnum"];
            Response.Redirect("HomePage.aspx?staffnum=" + staffnum);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Staff s = new Staff();
            s.Staffname = staffnametbx.Text;
            s.Dob = dobtbx.Text;
            s.Bankaccnum = banknotbx.Text;
            s.Contactnum = Convert.ToInt32(contatbx.Text);
            s.Homeadd = hometbx.Text;
            s.Dutytype = dutytbx.Text;
            s.Username = usernametbx.Text;
            s.Password = passtbx.Text;

            if (SWENDbmanager.InsertStaff(s) == 1)
            {
                lblSuccessful.Text = "Staff Creation Completed..";
            }
            else
            {
                lblSuccessful.Text = "Staff Creation Failed..";
            }
        }
    }
}