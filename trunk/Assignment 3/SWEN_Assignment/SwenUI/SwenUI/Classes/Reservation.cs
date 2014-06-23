using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SwenUI.Classes
{
    public class Reservation
    {
       
            private string reservationnum;
            private string firstname;
            private string lastname;
            private string nric;
            private string roomnum;
            private string addremarks;
            private string contactnum;
            private string emailadd;
            private string homeadd;
            private int postalcode;
            private string country;
            private string paymentmeth;
            private string roomclass;
            private string checkindate;
            private string checkoutdate;
            private string indicationlate;
            private string numofchild;
            private string numofadult;

            public Reservation()
            {
            }

            public Reservation(string reservationnum, string firstname, string lastname, string nric, string roomnum, string addremarks, string contactnum, string emailadd, string homeadd, int postalcode, string country, string paymentmeth, string roomclass, string checkindate, string checkoutdate, string indicationlate, string numofchild, string numofadult)
            {
                this.reservationnum = reservationnum;
                this.firstname = firstname;
                this.lastname = lastname;
                this.nric = nric;
                this.roomnum = roomnum;
                this.addremarks = addremarks;
                this.contactnum = contactnum;
                this.emailadd = emailadd;
                this.homeadd = homeadd;
                this.postalcode = postalcode;
                this.country = country;
                this.paymentmeth = paymentmeth;
                this.roomclass = roomclass;
                this.checkindate = checkindate;
                this.checkoutdate = checkoutdate;
                this.indicationlate = indicationlate;
                this.numofchild = numofchild;
                this.numofadult = numofadult;
            }

            public string Reservationnum
            {
                get { return reservationnum; }
                set { reservationnum = value; }
            }

            public string Firstname
            {
                get { return firstname; }
                set { firstname = value; }
            }

            public string Lastname
            {
                get { return lastname; }
                set { lastname = value; }
            }

            public string Nric
            {
                get { return nric; }
                set { nric = value; }
            }

            public string Roomnum
            {
                get { return roomnum; }
                set { roomnum = value; }
            }

            public string Addremarks
            {
                get { return addremarks; }
                set { addremarks = value; }
            }

            public string Contactnum
            {
                get { return contactnum; }
                set { contactnum = value; }
            }

            public string Emailadd
            {
                get { return emailadd; }
                set { emailadd = value; }
            }

            public string Homeadd
            {
                get { return homeadd; }
                set { homeadd = value; }
            }

            public int Postalcode
            {
                get { return postalcode; }
                set { postalcode = value; }
            }

            public string Country
            {
                get { return country; }
                set { country = value; }
            }

            public string Paymentmeth
            {
                get { return paymentmeth; }
                set { paymentmeth = value; }
            }

            public string Roomclass
            {
                get { return roomclass; }
                set { roomclass = value; }
            }

            public string Checkindate
            {
                get { return checkindate; }
                set { checkindate = value; }
            }

            public string Checkoutdate
            {
                get { return checkoutdate; }
                set { checkoutdate = value; }
            }

            public string Indicationlate
            {
                get { return indicationlate; }
                set { indicationlate = value; }
            }

            public string Numofchild
            {
                get { return numofchild; }
                set { numofchild = value; }
            }

            public string Numofadult
            {
                get { return numofadult; }
                set { numofadult = value; }
            }
        }
    
}