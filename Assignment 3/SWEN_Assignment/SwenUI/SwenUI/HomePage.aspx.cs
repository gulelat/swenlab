using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SwenUI.Classes;

namespace SwenUI
{
    public partial class HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string staffnum = Request.QueryString["staffnum"];
                Staff s = SWENDbmanager.GetStaffByNum(Convert.ToInt32(staffnum));
                lbluser.Text = s.Staffname;
                lblstaffnum.Text = Convert.ToString(s.Staffnum);
                staffnametbx.Text = s.Staffname;
                dobtbx.Text = s.Dob;
                banktbx.Text = s.Bankaccnum;
                conttbx.Text = Convert.ToString(s.Contactnum);
                lblduty.Text = s.Dutytype;
                hometbx.Text = s.Homeadd;
                usertbx.Text = s.Username;
                pwtbx.Text = s.Password;

                if (lblduty.Text == "Administrator")
                {
                    staffbtn.Visible = true;
                }
            }
               
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Staff s1 = new Staff();
            s1.Staffnum = Convert.ToInt32(lblstaffnum.Text);
            s1.Staffname = staffnametbx.Text;
            s1.Dob = dobtbx.Text;
            s1.Bankaccnum = banktbx.Text;
            s1.Contactnum = Convert.ToInt32(conttbx.Text);
            s1.Dutytype = lblduty.Text;
            s1.Homeadd = hometbx.Text;
            s1.Username = usertbx.Text;
            s1.Password = pwtbx.Text;
            

            if (SWENDbmanager.UpdateStaff(s1) == 1)
            {
                lblupdated.Text = "Profile Update Completed..";
            }
            else
            {
                lblupdated.Text = "Profile Update Failed..";
            }

        }

        protected void logoutbtn_Click(object sender, EventArgs e)
        {
            
            Response.Redirect("LoginPage.aspx?");
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

        protected void staffbtn_Click(object sender, EventArgs e)
        {
            string staffnum = Request.QueryString["staffnum"];
            Response.Redirect("StaffPage.aspx?staffnum=" + staffnum);
        }

        protected void rptbtn_Click(object sender, EventArgs e)
        {
            string staffnum = Request.QueryString["staffnum"];
            Response.Redirect("MainReportPage.aspx?staffnum=" + staffnum);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string staffnum = Request.QueryString["staffnum"];
            Staff s = SWENDbmanager.GetStaffByNum(Convert.ToInt32(staffnum));
            lbluser.Text = s.Staffname;
            lblstaffnum.Text = Convert.ToString(s.Staffnum);
            staffnametbx.Text = s.Staffname;
            dobtbx.Text = s.Dob;
            banktbx.Text = s.Bankaccnum;
            conttbx.Text = Convert.ToString(s.Contactnum);
            lblduty.Text = s.Dutytype;
            hometbx.Text = s.Homeadd;
            usertbx.Text = s.Username;
            pwtbx.Text = s.Password;

            if (lblduty.Text == "Administrator")
            {
                staffbtn.Visible = true;
            }
        }

      
        
    }
}