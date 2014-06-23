using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SwenUI.Classes;

namespace SwenUI
{
    public partial class CreateReservationPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            rm2tbx.Text = Request.QueryString["roomnum"];
        }

        protected void rsvcreatebtn_Click(object sender, EventArgs e)
        {
            Reservation r = new Reservation();
            
            r.Reservationnum = rsv2tbx.Text;
            r.Roomnum = rm2tbx.Text;
            r.Firstname = gf2tbx.Text;
            r.Lastname = gl2tbx.Text;
            r.Nric = nric2tbx.Text;
            r.Numofadult = adg1tbx.Text;
            r.Numofchild = ch1tbx.Text;
            r.Contactnum = cnt1tbx.Text;
            r.Emailadd = email2tbx.Text;
            r.Homeadd = home2tbx.Text;
            r.Postalcode = Convert.ToInt32(post2tbx.Text);
            r.Country = co2tbx.Text;
            r.Paymentmeth = meth2ddl.Text;
            r.Checkindate = ci2tbx.Text;
            r.Checkoutdate = cho2tbx.Text;
            r.Addremarks = add2tbx.Text;
            r.Indicationlate = ind2tbx.Text;
            r.Roomclass = class2tbx.Text;

            Paymentdetails p = new Paymentdetails();
            p.Paymentmeth = meth2ddl.Text;
            p.Creditcardnum = cred2tbx.Text;
            p.Creditholdername = holder2tbx.Text;
            p.Expirydate = exp2tbx.Text;
            p.Nric = nric2tbx.Text;
            p.Firstname = gf2tbx.Text;
            p.Lastname = gl2tbx.Text;
            p.Reservationnum = rsv2tbx.Text;
            

            if (SWENDbmanager.InsertReservation(r) == 1)
            {
                lblsuccesscreate.Text = "Reservation Creation Completed..";
            }
            else
            {
                lblsuccesscreate.Text = "Reservation Creation Failed..";
            }

            if (SWENDbmanager.InsertPayment(p) == 1)
            {
                lblpaycreated.Text = "Payment Details Creation Completed..";
            }
            else
            {
                lblpaycreated.Text = "Payment Details Creation Failed..";
            }
        }

        protected void rtnhmbtn_Click(object sender, EventArgs e)
        {
            string staffnum = Request.QueryString["staffnum"];
            Response.Redirect("HomePage.aspx?staffnum=" + staffnum);
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