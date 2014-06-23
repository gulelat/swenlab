using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Collections;
using System.Configuration;

namespace SwenUI.Classes
{
    public class SWENDbmanager
    {
        public static Reservation GetReservationByNum(string reservationnum)
        {
            Reservation r = new Reservation();
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["SWENConnectionString"].ConnectionString;
                conn.Open();
                SqlCommand comm = new SqlCommand();
                comm.Connection = conn;
                comm.CommandText = "SELECT * FROM Reservation WHERE reservationnum=@reservationnum";
                comm.Parameters.AddWithValue("@reservationnum", reservationnum);
                SqlDataReader dr = comm.ExecuteReader();
                if (dr.Read())
                {
                    
                    r.Reservationnum = (string)dr["reservationnum"];
                    r.Firstname = (string)dr["firstname"];
                    r.Lastname = (string)dr["lastname"];
                    r.Nric = (string)dr["nric"];
                    r.Roomnum = (string)dr["roomnum"];
                    r.Addremarks = (string)dr["addremarks"];
                    r.Contactnum = (string)dr["contactnum"];
                    r.Emailadd = (string)dr["emailaddress"];
                    r.Homeadd = (string)dr["homeaddress"];
                    r.Postalcode = (int)dr["postalcode"];
                    r.Country = (string)dr["country"];
                    r.Paymentmeth = (string)dr["paymentmeth"];
                    r.Roomclass = (string)dr["roomclass"];
                    r.Checkindate = (string)dr["checkindate"];
                    r.Checkoutdate = (string)dr["checkoutdate"];
                    r.Indicationlate = (string)dr["indicationlate"];
                    r.Numofchild = (string)dr["numofchild"];
                    r.Numofadult = (string)dr["numofadult"];
                }
                dr.Close();
            }

            catch (SqlException e)
            {
                throw e;
            }

            return r;

        }

        public static int DeleteReservation(string reservationnum)
        {
            int rowsdeleted = 0;
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["SWENConnectionString"].ConnectionString;
                conn.Open();
                SqlCommand comm = new SqlCommand();
                comm.Connection = conn;
                comm.CommandText = "DELETE FROM Reservation WHERE reservationnum=@reservationnum";
                comm.Parameters.AddWithValue("@reservationnum", reservationnum);

                rowsdeleted = comm.ExecuteNonQuery();
                conn.Close();
            }
            catch (SqlException e)
            {
                throw e;
            }
            return rowsdeleted;
        }

        public static int InsertReservation(Reservation r)
        {
            int rowsinserted = 0;

            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["SWENConnectionString"].ConnectionString;
                conn.Open();
                SqlCommand comm = new SqlCommand();
                comm.Connection = conn;
                comm.CommandText = "INSERT INTO Reservation(reservationnum,firstname,lastname,nric,roomnum,addremarks,contactnum,emailaddress,homeaddress,postalcode,country,paymentmeth,roomclass,checkindate,checkoutdate,indicationlate,numofchild,numofadult)" +
                    " VALUES (@reservationnum,@firstname,@lastname,@nric,@roomnum,@addremarks,@contactnum,@emailaddress,@homeaddress,@postalcode,@country,@paymentmeth,@roomclass,@checkindate,@checkoutdate,@indicationlate,@numofchild,@numofadult)";
                comm.Parameters.AddWithValue("@reservationnum", r.Reservationnum);
                comm.Parameters.AddWithValue("@firstname", r.Firstname);
                comm.Parameters.AddWithValue("@lastname", r.Lastname);
                comm.Parameters.AddWithValue("@nric", r.Nric);
                comm.Parameters.AddWithValue("@roomnum", r.Roomnum);
                comm.Parameters.AddWithValue("@addremarks", r.Addremarks);
                comm.Parameters.AddWithValue("@contactnum", r.Contactnum);
                comm.Parameters.AddWithValue("@emailaddress", r.Emailadd);
                comm.Parameters.AddWithValue("@homeaddress", r.Homeadd);
                comm.Parameters.AddWithValue("@postalcode", r.Postalcode);
                comm.Parameters.AddWithValue("@country", r.Country);
                comm.Parameters.AddWithValue("@paymentmeth", r.Paymentmeth);
                comm.Parameters.AddWithValue("@roomclass", r.Roomclass);
                comm.Parameters.AddWithValue("@checkindate", r.Checkindate);
                comm.Parameters.AddWithValue("@checkoutdate", r.Checkoutdate);
                comm.Parameters.AddWithValue("@indicationlate", r.Indicationlate);
                comm.Parameters.AddWithValue("@numofchild",r.Numofchild);
                comm.Parameters.AddWithValue("@numofadult",r.Numofadult);
                rowsinserted = comm.ExecuteNonQuery();

                conn.Close();
            }
            catch (SqlException e)
            {
                throw e;
            }
            return rowsinserted;
        }

        public static int UpdateReservation(Reservation r)
        {
            int rowsupdated = 0;

            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["SWENConnectionString"].ConnectionString;
                conn.Open();
                SqlCommand comm = new SqlCommand();
                comm.Connection = conn;
                comm.CommandText = "UPDATE Reservation SET  firstname=@firstname, lastname=@lastname, nric=@nric, roomnum=@roomnum, addremarks=@addremarks, contactnum=@contactnum, emailaddress=@emailaddress, homeaddress=@homeaddress, postalcode=@postalcode, country=@country, paymentmeth=@paymentmeth, roomclass=@roomclass, checkindate=@checkindate, checkoutdate=@checkoutdate, indicationlate=@indicationlate, numofchild=@numofchild, numofadult=@numofadult WHERE reservationnum=@reservationnum";
                
                comm.Parameters.AddWithValue("@firstname", r.Firstname);
                comm.Parameters.AddWithValue("@lastname", r.Lastname);
                comm.Parameters.AddWithValue("@nric", r.Nric);
                comm.Parameters.AddWithValue("@roomnum", r.Roomnum);
                comm.Parameters.AddWithValue("@addremarks", r.Addremarks);
                comm.Parameters.AddWithValue("@contactnum", r.Contactnum);
                comm.Parameters.AddWithValue("@emailaddress", r.Emailadd);
                comm.Parameters.AddWithValue("@homeaddress", r.Homeadd);
                comm.Parameters.AddWithValue("@postalcode", r.Postalcode);
                comm.Parameters.AddWithValue("@country", r.Country);
                comm.Parameters.AddWithValue("@paymentmeth", r.Paymentmeth);
                comm.Parameters.AddWithValue("@roomclass", r.Roomclass);
                comm.Parameters.AddWithValue("@checkindate", r.Checkindate);
                comm.Parameters.AddWithValue("@checkoutdate", r.Checkoutdate);
                comm.Parameters.AddWithValue("@indicationlate", r.Indicationlate);
                comm.Parameters.AddWithValue("@numofchild",r.Numofchild);
                comm.Parameters.AddWithValue("@numofadult",r.Numofadult);
                comm.Parameters.AddWithValue("@reservationnum", r.Reservationnum);

                rowsupdated = comm.ExecuteNonQuery();
                conn.Close();
            }
            catch (SqlException e)
            {
                throw e;
            }
            return rowsupdated;
        }

        public static Paymentdetails GetPaymentdetailsByNum(string reservationnum)
        {
            Paymentdetails p = new Paymentdetails();
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["SWENConnectionString"].ConnectionString;
                conn.Open();
                SqlCommand comm = new SqlCommand();
                comm.Connection = conn;
                comm.CommandText = "SELECT * FROM PaymentDetails WHERE reservationnum=@reservationnum";
                comm.Parameters.AddWithValue("@reservationnum", reservationnum);
                SqlDataReader dr = comm.ExecuteReader();
                if (dr.Read())
                {

                    p.Reservationnum = (string)dr["reservationnum"];
                    
                    p.Paymentmeth = (string)dr["paymentmeth"];
                    p.Creditcardnum = (string)dr["creditcardnum"];
                    p.Creditholdername = (string)dr["creditholdername"];
                    p.Expirydate = (string)dr["expirydate"];
                   
                }
                dr.Close();
            }

            catch (SqlException e)
            {
                throw e;
            }

            return p;

        }

        public static Room GetRoomByNum(string roomnum)
        {
            Room r = new Room();
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["SWENConnectionString"].ConnectionString;
                conn.Open();
                SqlCommand comm = new SqlCommand();
                comm.Connection = conn;
                comm.CommandText = "SELECT * FROM Room WHERE roomnum=@roomnum";
                comm.Parameters.AddWithValue("@roomnum", roomnum);
                SqlDataReader dr = comm.ExecuteReader();
                if (dr.Read())
                {
                   
                    r.Roomnum = (string)dr["roomnum"];
                    r.Roomtype = (string)dr["roomtype"];
                    r.Roomclass = (string)dr["roomclass"];
                    r.Numofbed = (int)dr["numofbed"];
                    r.Bedtype = (string)dr["bedtype"];
                    r.Roomrate = (string)dr["roomrate"];
                    r.Roomstatus = (string)dr["roomstatus"];
                    r.Roomid = (int)dr["roomid"];
                    
                   
                }
                dr.Close();
            }

            catch (SqlException e)
            {
                throw e;
            }

            return r;

        }

        public static int DeleteRoom(string roomnum)
        {
            
            int rowsdeleted = 0;
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["SWENConnectionString"].ConnectionString;
                conn.Open();
                SqlCommand comm = new SqlCommand();
                comm.Connection = conn;
                comm.CommandText = "DELETE FROM Room WHERE roomnum=@roomnum";
                comm.Parameters.AddWithValue("@roomnum", roomnum);

                rowsdeleted = comm.ExecuteNonQuery();
                conn.Close();
            }
            catch (SqlException e)
            {
                throw e;
            }
            return rowsdeleted;
        }

        public static int InsertRoom(Room r)
        {
            int rowsinserted = 0;

            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["SWENConnectionString"].ConnectionString;
                conn.Open();
                SqlCommand comm = new SqlCommand();
                comm.Connection = conn;
                comm.CommandText = "INSERT INTO Room(roomnum,roomtype,roomclass,numofbed,bedtype,roomrate,roomstatus)" +
                    " VALUES (@roomnum,@roomtype,@roomclass,@numofbed,@bedtype,@roomrate,@roomstatus)";
                comm.Parameters.AddWithValue("@roomnum", r.Roomnum);
                comm.Parameters.AddWithValue("@roomtype", r.Roomtype);
                comm.Parameters.AddWithValue("@roomclass", r.Roomclass);
                comm.Parameters.AddWithValue("@numofbed", r.Numofbed);
                comm.Parameters.AddWithValue("@bedtype", r.Bedtype);
                comm.Parameters.AddWithValue("@roomrate", r.Roomrate);
                comm.Parameters.AddWithValue("@roomstatus",r.Roomstatus);
                
                rowsinserted = comm.ExecuteNonQuery();

                conn.Close();
            }
            catch (SqlException e)
            {
                throw e;
            }
            return rowsinserted;
        }

        public static int UpdateRoom(Room r)
        {
            int rowsupdated = 0;

            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["SWENConnectionString"].ConnectionString;
                conn.Open();
                SqlCommand comm = new SqlCommand();
                comm.Connection = conn;
                comm.CommandText = "UPDATE Room SET  roomtype=@roomtype, roomclass=@roomclass, numofbed=@numofbed, bedtype=@bedtype, roomrate=@roomrate, roomstatus=@roomstatus WHERE roomnum=@roomnum";
                comm.Parameters.AddWithValue("@roomtype", r.Roomtype);
                comm.Parameters.AddWithValue("@roomclass", r.Roomclass);
                comm.Parameters.AddWithValue("@numofbed", r.Numofbed);
                comm.Parameters.AddWithValue("@bedtype", r.Bedtype);
                comm.Parameters.AddWithValue("@roomrate", r.Roomrate);
                comm.Parameters.AddWithValue("@roomstatus",r.Roomstatus);
                comm.Parameters.AddWithValue("@roomnum",r.Roomnum);
                comm.Parameters.AddWithValue("@roomid",r.Roomid);
                

                rowsupdated = comm.ExecuteNonQuery();
                conn.Close();
            }
            catch (SqlException e)
            {
                throw e;
            }
            return rowsupdated;
        }

        public static int DeletePaymendDetails(string reservationnum)
        {
            int rowsdeleted = 0;
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["SWENConnectionString"].ConnectionString;
                conn.Open();
                SqlCommand comm = new SqlCommand();
                comm.Connection = conn;
                comm.CommandText = "DELETE FROM PaymentDetails WHERE reservationnum=@reservationnum";
                comm.Parameters.AddWithValue("@reservationnum", reservationnum);

                rowsdeleted = comm.ExecuteNonQuery();
                conn.Close();
            }
            catch (SqlException e)
            {
                throw e;
            }
            return rowsdeleted;
        }

        public static int UpdatePaymentDetails(Paymentdetails p)
        {
            int rowsupdated = 0;

            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["SWENConnectionString"].ConnectionString;
                conn.Open();
                SqlCommand comm = new SqlCommand();
                comm.Connection = conn;
                comm.CommandText = "UPDATE PaymentDetails SET  guestnric=@guestnric, paymentmeth=@paymentmeth, creditcardnum=@creditcardnum, creditholdername=@creditholdername, expirydate=@expirydate, firstname=@firstname, lastname=@lastname WHERE reservationnum=@reservationnum";
                comm.Parameters.AddWithValue("@guestnric", p.Nric);
                comm.Parameters.AddWithValue("@paymentmeth", p.Paymentmeth);
                comm.Parameters.AddWithValue("@creditcardnum", p.Creditcardnum);
                comm.Parameters.AddWithValue("@creditholdername", p.Creditholdername);
                comm.Parameters.AddWithValue("@expirydate", p.Expirydate);
                comm.Parameters.AddWithValue("@firstname",p.Firstname);
                comm.Parameters.AddWithValue("@lastname",p.Lastname);
                comm.Parameters.AddWithValue("@reservationnum",p.Reservationnum);

                rowsupdated = comm.ExecuteNonQuery();
                conn.Close();
            }
            catch (SqlException e)
            {
                throw e;
            }
            return rowsupdated;
        }

        public static int UpdateRoomStatus(Room r)
        {
            int rowsupdated = 0;

            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["SWENConnectionString"].ConnectionString;
                conn.Open();
                SqlCommand comm = new SqlCommand();
                comm.Connection = conn;
                comm.CommandText = "UPDATE Room SET  roomstatus=@roomstatus WHERE roomnum=@roomnum";
                comm.Parameters.AddWithValue("@roomnum",r.Roomnum);
                comm.Parameters.AddWithValue("@roomstatus",r.Roomstatus);
                
               

                rowsupdated = comm.ExecuteNonQuery();
                conn.Close();
            }
            catch (SqlException e)
            {
                throw e;
            }
            return rowsupdated;
        }

        public static int InsertPayment(Paymentdetails p)
        {
            int rowsinserted = 0;

            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["SWENConnectionString"].ConnectionString;
                conn.Open();
                SqlCommand comm = new SqlCommand();
                comm.Connection = conn;
                comm.CommandText = "INSERT INTO PaymentDetails(guestnric,paymentmeth,creditcardnum,creditholdername,expirydate,firstname,lastname,reservationnum)" +
                    " VALUES (@guestnric,@paymentmeth,@creditcardnum,@creditholdername,@expirydate,@firstname,@lastname,@reservationnum)";
                
                comm.Parameters.AddWithValue("@guestnric", p.Nric);
                comm.Parameters.AddWithValue("@paymentmeth", p.Paymentmeth);
                comm.Parameters.AddWithValue("@creditcardnum", p.Creditcardnum);
                comm.Parameters.AddWithValue("@creditholdername", p.Creditholdername);
                comm.Parameters.AddWithValue("@expirydate", p.Expirydate);
                comm.Parameters.AddWithValue("@firstname", p.Firstname);
                comm.Parameters.AddWithValue("@lastname",p.Lastname);
                comm.Parameters.AddWithValue("@reservationnum",p.Reservationnum);

                rowsinserted = comm.ExecuteNonQuery();

                conn.Close();
            }
            catch (SqlException e)
            {
                throw e;
            }
            return rowsinserted;
        }

        public static Staff GetStaffByNum(int staffnum)
        {
            Staff s = new Staff();
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["SWENConnectionString"].ConnectionString;
                conn.Open();
                SqlCommand comm = new SqlCommand();
                comm.Connection = conn;
                comm.CommandText = "SELECT * FROM Staff WHERE staffnum=@staffnum";
                comm.Parameters.AddWithValue("@staffnum", staffnum);
                SqlDataReader dr = comm.ExecuteReader();
                if (dr.Read())
                {
               
                    s.Staffnum = (int)dr["staffnum"];
                    s.Staffname = (string)dr["staffname"];
                    s.Dob = (string)dr["dateofbirth"];
                    s.Bankaccnum = (string)dr["bankaccnum"];
                    s.Contactnum = (int)dr["contactnum"];
                    s.Dutytype = (string)dr["dutytype"];
                    s.Homeadd = (string)dr["homeadd"];
                    s.Username = (string)dr["username"];
                    s.Password = (string)dr["password"];

                  
                }
                dr.Close();
            }

            catch (SqlException e)
            {
                throw e;
            }

            return s;
        }

        public static int InsertStaff(Staff s)
        {
            int rowsinserted = 0;

            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["SWENConnectionString"].ConnectionString;
                conn.Open();
                SqlCommand comm = new SqlCommand();
                comm.Connection = conn;
                comm.CommandText = "INSERT INTO Staff(staffname,dateofbirth,bankaccnum,contactnum,dutytype,homeadd,username,password)" +
                    " VALUES (@staffname,@dateofbirth,@bankaccnum,@contactnum,@dutytype,@homeadd,@username,@password)";
                
                comm.Parameters.AddWithValue("@staffname", s.Staffname);
                comm.Parameters.AddWithValue("@dateofbirth", s.Dob);
                comm.Parameters.AddWithValue("@bankaccnum", s.Bankaccnum);
                comm.Parameters.AddWithValue("@contactnum" , s.Contactnum);
                comm.Parameters.AddWithValue("@dutytype", s.Dutytype);
                comm.Parameters.AddWithValue("@homeadd", s.Homeadd);
                comm.Parameters.AddWithValue("@username", s.Username);
                comm.Parameters.AddWithValue("@password", s.Password);
                rowsinserted = comm.ExecuteNonQuery();

                conn.Close();
            }
            catch (SqlException e)
            {
                throw e;
            }
            return rowsinserted;
        }
        
        public static int UpdateStaff(Staff s)
        {
            int rowsupdated = 0;

            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["SWENConnectionString"].ConnectionString;
                conn.Open();
                SqlCommand comm = new SqlCommand();
                comm.Connection = conn;
                comm.CommandText = "UPDATE Staff SET staffname=@staffname, dateofbirth=@dateofbirth, bankaccnum=@bankaccnum, contactnum=@contactnum, dutytype=@dutytype,  homeadd=@homeadd, username=@username, password=@password WHERE staffnum=@staffnum";
                comm.Parameters.AddWithValue("@staffname", s.Staffname);
                comm.Parameters.AddWithValue("@dateofbirth", s.Dob);
                comm.Parameters.AddWithValue("@bankaccnum", s.Bankaccnum);
                comm.Parameters.AddWithValue("@contactnum", s.Contactnum);
                comm.Parameters.AddWithValue("@dutytype", s.Dutytype);
                comm.Parameters.AddWithValue("@homeadd", s.Homeadd);
                comm.Parameters.AddWithValue("@username", s.Username);
                comm.Parameters.AddWithValue("@password", s.Password);
                comm.Parameters.AddWithValue("@staffnum",s.Staffnum);

                rowsupdated = comm.ExecuteNonQuery();
                conn.Close();
            }
            catch (SqlException e)
            {
                throw e;
            }
            return rowsupdated;
        }

        public static int DeleteStaff(string staffnum)
        {
            int rowsdeleted = 0;
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["SWENConnectionString"].ConnectionString;
                conn.Open();
                SqlCommand comm = new SqlCommand();
                comm.Connection = conn;
                comm.CommandText = "DELETE FROM Staff WHERE staffnum=@staffnum";
                comm.Parameters.AddWithValue("@staffnum", staffnum);

                rowsdeleted = comm.ExecuteNonQuery();
                conn.Close();
            }
            catch (SqlException e)
            {
                throw e;
            }
            return rowsdeleted;
        }

        public static Staff UserLogin(string username, string password)
        {
            Staff s = null;
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["SWENConnectionString"].ConnectionString;
                conn.Open();
                SqlCommand comm = new SqlCommand();
                comm.Connection = conn;
                comm.CommandText = "SELECT * FROM Staff WHERE password=@password COLLATE SQL_Latin1_General_CP1_CS_AS and username=@username COLLATE SQL_Latin1_General_CP1_CS_AS";

                comm.Parameters.AddWithValue("@password", password);
                comm.Parameters.AddWithValue("@username", username);
                SqlDataReader dr = comm.ExecuteReader();
                if (dr.Read())
                {   
                    s = new Staff();
                   
                 s.Username = (string)dr["username"];
                 s.Password = (string)dr["password"];
                 s.Staffnum = (int)dr["staffnum"];
                 s.Staffname = (string)dr["staffname"];;
                 s.Dob = (string)dr["dateofbirth"];
                 s.Bankaccnum = (string)dr["bankaccnum"];
                 s.Contactnum = (int)dr["contactnum"];
                 s.Homeadd = (string)dr["homeadd"];
                 s.Dutytype = (string)dr["dutytype"];
                }
                dr.Close();
            }
            catch (SqlException e)
            {
                throw e;
            }
            return s;
        }
    }
    
}