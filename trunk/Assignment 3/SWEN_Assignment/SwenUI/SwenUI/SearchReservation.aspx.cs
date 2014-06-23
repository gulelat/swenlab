using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SwenUI.Classes;

namespace SwenUI
{
    public partial class SearchReservation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
               
            }
        }

        protected void rsvnobtn_Click(object sender, EventArgs e)
        {
            string reservationnum = rsvnotbx.Text;
            Reservation r = SWENDbmanager.GetReservationByNum(reservationnum);
            Paymentdetails p = SWENDbmanager.GetPaymentdetailsByNum(reservationnum);
            gfnametbx.Text = r.Firstname;
            glnametbx.Text = r.Lastname;
            nrictbx.Text = r.Nric;
            roomtbx.Text = Convert.ToString(r.Roomnum);
            classtbx.Text = r.Roomclass;
            cntbx.Text = r.Contactnum;
            emailtbx.Text = r.Emailadd;
            ctbx.Text = r.Country;
            hometbx.Text = r.Homeadd;
            postaltbx.Text = Convert.ToString(r.Postalcode);
            citbx.Text = r.Checkindate;
            cotbx.Text = r.Checkoutdate;
            paymentddl.Text = r.Paymentmeth;
            indtbx.Text = r.Indicationlate;
            addrtbx.Text = r.Addremarks;
            childtbx.Text = r.Numofchild;
            adulttbx.Text = r.Numofadult;
            cardnotbx.Text = p.Creditcardnum;
            holdertbx.Text = p.Creditholdername;
            exptbx.Text = p.Expirydate;
            
        }

        protected void srbtn_Click(object sender, EventArgs e)
        {
            string staffnum = Request.QueryString["staffnum"];
            Response.Redirect("RoomStatusPage.aspx?staffnum=" + staffnum);
        }

        protected void dlbtn_Click(object sender, EventArgs e)
        {
            string reservationnum = rsvnotbx.Text;
            
            if (SWENDbmanager.DeleteReservation(reservationnum) == 1)
            {
                lblSuccessful.Text = "Reservation Deletion Completed..";
            }
            else
            {
                lblUnsuccessful.Text = "Reservation Deletion Failed..";
            }

            if (SWENDbmanager.DeletePaymendDetails(reservationnum) == 1)
            {
                lblpaycompleted.Text = "Payment Details Deletion Completed..";
            }
            else
            {
                lblpayfailed.Text = "Payment Details Deletion Failed..";
            }

            
        }

        protected void updbtn_Click(object sender, EventArgs e)
        {
            Reservation r = new Reservation();
            r.Firstname = gfnametbx.Text;
            r.Lastname = glnametbx.Text;
            r.Nric = nrictbx.Text;
            r.Roomnum = roomtbx.Text;
            r.Roomclass = classtbx.Text;
            r.Contactnum = cntbx.Text;
            r.Emailadd = emailtbx.Text;
            r.Country = ctbx.Text;
            r.Homeadd = hometbx.Text;
            r.Postalcode = Convert.ToInt32(postaltbx.Text);
            r.Checkindate = citbx.Text;
            r.Checkoutdate = cotbx.Text;
            r.Paymentmeth = paymentddl.Text;
            r.Indicationlate = indtbx.Text;
            r.Addremarks = addrtbx.Text;
            r.Reservationnum = rsvnotbx.Text;
            r.Numofchild = childtbx.Text;
            r.Numofadult = adulttbx.Text;

            Paymentdetails p = new Paymentdetails();
            p.Nric = nrictbx.Text;
            p.Paymentmeth = paymentddl.Text;
            p.Creditcardnum = cardnotbx.Text;
            p.Creditholdername = holdertbx.Text;
            p.Expirydate = exptbx.Text;
            p.Firstname = gfnametbx.Text;
            p.Lastname = glnametbx.Text;
            p.Reservationnum = rsvnotbx.Text;

            if (SWENDbmanager.UpdateReservation(r) == 1)
            {
                lblSuccessful.Text = "Reservation Update Completed..";
            }
            else
            {
                lblUnsuccessful.Text = "Reservation Update Failed..";
            }

            if (SWENDbmanager.UpdatePaymentDetails(p) == 1)
            {
                lblpaycompleted.Text = "Payment Details Update Completed..";
            }
            else
            {
                lblpayfailed.Text = "Payment Details Update Failed..";
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

        protected void Button1_Click(object sender, EventArgs e)
        {
            string staffnum = Request.QueryString["staffnum"];
            Response.Redirect("HomePage.aspx?staffnum=" + staffnum);
        }

        
    }
}