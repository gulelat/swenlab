using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SwenUI.Classes
{
    public class Paymentdetails
    {
        private int paymentid;
        private string nric;
        private string paymentmeth;
        private string creditcardnum;
        private string creditholdername;
        private string expirydate;
        private string firstname;
        private string lastname;
        private string reservationnum;

        public Paymentdetails()
        {
        }

        public Paymentdetails(int paymentid, string nric, string paymentmeth, string creditcardnum, string creditholdername, string expirydate, string firstname, string lastname, string reservationnum)
        {
            this.paymentid = paymentid;
            this.nric = nric;
            this.paymentmeth = paymentmeth;
            this.creditcardnum = creditcardnum;
            this.creditholdername = creditholdername;
            this.expirydate = expirydate;
            this.firstname = firstname;
            this.lastname = lastname;
            this.reservationnum = reservationnum;
        }

        public int Paymentid
        {
            get { return paymentid; }
            set { paymentid = value; }
        }

        public string Nric
        {
            get { return nric; }
            set { nric = value; }
        }

        public string Paymentmeth
        {
            get { return paymentmeth; }
            set { paymentmeth = value; }
        }

        public string Creditcardnum
        {
            get { return creditcardnum; }
            set { creditcardnum = value; }
        }

        public string Creditholdername
        {
            get { return creditholdername; }
            set { creditholdername = value; }
        }

        public string Expirydate
        {
            get { return expirydate; }
            set { expirydate = value; }
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

        public string Reservationnum
        {
            get { return reservationnum; }
            set { reservationnum = value; }
        }
    }
}