using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SwenUI.Classes;

namespace SwenUI
{
    public partial class CreateRoomPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void rtnhomebtn_Click(object sender, EventArgs e)
        {
            string staffnum = Request.QueryString["staffnum"];
            Response.Redirect("HomePage.aspx?staffnum=" + staffnum);
        }

        protected void createroombtn_Click(object sender, EventArgs e)
        {
            Room r = new Room();
            r.Roomnum = rnotbx.Text;
            r.Roomtype = rttbx.Text;
            r.Roomclass = rctbx.Text;
            r.Numofbed = Convert.ToInt32(nobtbx.Text);
            r.Bedtype = tobtbx.Text;
            r.Roomstatus = rstbx.Text;
            r.Roomrate = rrtbx.Text;

            if (SWENDbmanager.InsertRoom(r) == 1)
            {
                lblSuccessful.Text = "Room Creation Completed..";
            }
            else
            {
                lblSuccessful.Text = "Room Creation Failed..";
            }
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
    }
}