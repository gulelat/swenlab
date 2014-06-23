using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SwenUI.Classes;

namespace SwenUI
{
    public partial class RoomStatusPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
         
        }

        protected void rmnobtn_Click(object sender, EventArgs e)
        {
            string roomnum = rmnotbx.Text;
            Room r = SWENDbmanager.GetRoomByNum(roomnum);
            lblroomid.Text = Convert.ToString(r.Roomid);
            lblroomno.Text = r.Roomnum;
            lblroomtype.Text = r.Roomtype;
            lblnumbed.Text = Convert.ToString(r.Numofbed);
            lblbedtype.Text = r.Bedtype;
            lblclass.Text = r.Roomclass;
            lblroomrate.Text = r.Roomrate;
            roomstattbx.Text = r.Roomstatus;
        }

        protected void rmeditbtn_Click(object sender, EventArgs e)
        {
            
            Room r = new Room();
            r.Roomid = Convert.ToInt32(lblroomid.Text);
            r.Roomnum = lblroomno.Text;
            r.Roomtype = lblroomtype.Text;
            r.Numofbed = Convert.ToInt32(lblnumbed.Text);
            r.Bedtype = lblbedtype.Text;
            r.Roomclass = lblclass.Text;
            r.Roomrate = lblroomrate.Text;
            r.Roomstatus = roomstattbx.Text;
            
            if (SWENDbmanager.UpdateRoom(r) == 1)
            {
                lblSuccessful.Text = "Room Status Update Completed..";
            }
            else
            {
                lblSuccessful.Text = "Room Status Update Failed..";
            }
        }

        protected void rmdelbtn_Click(object sender, EventArgs e)
        {
            string roomnum = rmnotbx.Text;
            if (SWENDbmanager.DeleteRoom(roomnum) == 1)
            {
                lblSuccessful.Text = "Room Deletion Completed..";
            }
        }

        protected void rmcreatebtn_Click(object sender, EventArgs e)
        {
            string staffnum = Request.QueryString["staffnum"];
            Response.Redirect("CreateRoomPage.aspx?staffnum=" + staffnum);
        }

        protected void rsvcreatebtn_Click(object sender, EventArgs e)
        {
            string staffnum = Request.QueryString["staffnum"];
            string querystring = "roomnum=" + rmnotbx.Text;
            querystring += "&" + "staffnum=" + staffnum;
            Response.Redirect("CreateReservationPage.aspx?" + querystring);
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

        protected void rtnhmbtn_Click(object sender, EventArgs e)
        {
            string staffnum = Request.QueryString["staffnum"];
            Response.Redirect("HomePage.aspx?staffnum=" + staffnum);
        }
    }
}