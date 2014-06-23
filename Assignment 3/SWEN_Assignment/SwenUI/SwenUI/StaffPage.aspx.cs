using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SwenUI.Classes;

namespace SwenUI
{
    public partial class StaffPage : System.Web.UI.Page
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
            Response.Redirect("CreateStaffPage.aspx?staffnum=" + staffnum);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string staffno = staffnotbx.Text;
            Staff s = SWENDbmanager.GetStaffByNum(Convert.ToInt32(staffno));
            lblstaffno.Text = Convert.ToString(s.Staffnum);
            staffnametbx.Text = s.Staffname;
            lbldob.Text = s.Dob;
            lblbankno.Text = s.Bankaccnum;
            contatbx.Text = Convert.ToString(s.Contactnum);
            homeaddtbx.Text = s.Homeadd;
            dutytbx.Text = s.Dutytype;
            usernametbx.Text = s.Username;
            passtbx.Text = s.Password;
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            string staffnum = Request.QueryString["staffnum"];
            Response.Redirect("HomePage.aspx?staffnum=" + staffnum);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Staff s = new Staff();
            s.Staffnum = Convert.ToInt32(lblstaffno.Text);
            s.Staffname = staffnametbx.Text;
            s.Dob = lbldob.Text;
            s.Bankaccnum = lblbankno.Text;
            s.Contactnum = Convert.ToInt32(contatbx.Text);
            s.Homeadd = homeaddtbx.Text;
            s.Dutytype = dutytbx.Text;
            s.Username = usernametbx.Text;
            s.Password = passtbx.Text;

            if (SWENDbmanager.UpdateStaff(s) == 1)
            {
                lblSuccesful.Text = "Staff Update Completed..";
            }
            else
            {
                lblSuccesful.Text = "Staff Update Failed..";
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            string staffno = staffnotbx.Text;

            if (SWENDbmanager.DeleteStaff(staffno) == 1)
            {
                lblSuccesful.Text = "Staff Deletion Completed..";
            }
            else
            {
                lblSuccesful.Text = "Staff Deletion Failed..";
            }
        }
    }
}