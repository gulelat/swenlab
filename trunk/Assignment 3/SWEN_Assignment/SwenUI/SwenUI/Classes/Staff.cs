using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SwenUI.Classes
{
    public class Staff
    {
        private int staffnum;
        private string staffname;
        private string dob;
        private string bankaccnum;
        private int contactnum;
        private string dutytype;
        private string homeadd;
        private string username;
        private string password;

        public Staff()
        {
        }

        public Staff(int staffnum, string staffname, string dob, string bankaccnum, int contactnum, string dutytype, string homeadd, string username, string password)
        {
            this.staffnum = staffnum;
            this.staffname = staffname;
            this.dob = dob;
            this.bankaccnum = bankaccnum;
            this.contactnum = contactnum;
            this.dutytype = dutytype;
            this.homeadd = homeadd;
            this.username = username;
            this.password = password;
        }

        public int Staffnum
        {
            get { return staffnum; }
            set { staffnum = value; }
        }

        public string Staffname
        {
            get { return staffname; }
            set { staffname = value; }
        }

        public string Dob
        {
            get { return dob; }
            set { dob = value; }
        }

        public string Bankaccnum
        {
            get { return bankaccnum; }
            set { bankaccnum = value; }
        }

        public int Contactnum
        {
            get { return contactnum; }
            set { contactnum = value; }
        }

        public string Dutytype
        {
            get { return dutytype; }
            set { dutytype = value; }
        }

        public string Homeadd
        {
            get { return homeadd; }
            set { homeadd = value; }
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
    }
}