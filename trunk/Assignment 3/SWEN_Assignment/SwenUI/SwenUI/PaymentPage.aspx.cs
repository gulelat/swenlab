using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SwenUI.Classes;

namespace SwenUI
{
    public partial class PaymentPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {

            }
        }

        protected void shgbtn_Click(object sender, EventArgs e)
        {
            string reservationnum = shgtbx.Text;
            Reservation r = SWENDbmanager.GetReservationByNum(reservationnum);
            Paymentdetails p = SWENDbmanager.GetPaymentdetailsByNum(reservationnum);
            lblrmno.Text = r.Roomnum;
            string roomnum = lblrmno.Text;
            Room r1 = SWENDbmanager.GetRoomByNum(roomnum);
            lblrmtype.Text = r1.Roomtype;
            lblgname.Text = r.Firstname;
            lblgnamel.Text = r.Lastname;
            lblnric.Text = r.Nric;
            lblagno.Text = r.Numofadult;
            lblcgno.Text = r.Numofchild;
            lblcno.Text = r.Contactnum;
            lblem.Text = r.Emailadd;
            lblhma.Text = r.Homeadd;
            lblpc.Text = Convert.ToString(r.Postalcode);
            lblc.Text = r.Country;
            lblpm.Text = p.Paymentmeth;
            lblcrno.Text = p.Creditcardnum;
            lblcrname.Text = p.Creditholdername;
            lblexp.Text = p.Expirydate;
            lblcid.Text = r.Checkindate;
            lblcod.Text = r.Checkoutdate;
            lblrr.Text = r1.Roomrate;
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

        protected void Button1_Click(object sender, EventArgs e)
        {
            string staffnum = Request.QueryString["staffnum"];
            Response.Redirect("HomePage.aspx?staffnum=" + staffnum);
        }
    }
}