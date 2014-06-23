using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SwenUI.Classes
{
    public class Room
    {
        private int roomid;
        private string roomnum;
        private string roomtype;
        private string roomclass;
        private int numofbed;
        private string bedtype;
        private string roomrate;
        private string roomstatus;

        public Room()
        {
        }

        public Room(int roomid, string roomnum, string roomtype, string roomclass, int numofbed, string bedtype, string roomrate, string roomstatus)
        {
            this.roomid = roomid;
            this.roomnum = roomnum;
            this.roomtype = roomtype;
            this.roomclass = roomclass;
            this.numofbed = numofbed;
            this.bedtype = bedtype;
            this.roomrate = roomrate;
            this.roomstatus = roomstatus;
            
        }
        public int Roomid
        {
            get { return roomid; }
            set { roomid = value; }
        }

        public string Roomnum
        {
            get { return roomnum; }
            set { roomnum = value; }
        }

        public string Roomtype
        {
            get { return roomtype; }
            set { roomtype = value; }
        }

        public string Roomclass
        {
            get { return roomclass; }
            set { roomclass = value; }
        }

        public int Numofbed
        {
            get { return numofbed; }
            set { numofbed = value; }
        }

        public string Bedtype
        {
            get { return bedtype; }
            set { bedtype = value; }
        }
        public string Roomrate
        {
            get { return roomrate; }
            set { roomrate = value; }
        }

        public string Roomstatus
        {
            get { return roomstatus; }
            set { roomstatus = value; }
        }
    }
}