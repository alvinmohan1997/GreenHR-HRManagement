using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;



namespace WebApplication1
{
    public class dal
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B0P46V9\SQLEXPRESS;Initial Catalog=greenhr;Integrated Security=True");
        public DataTable dispRec()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from managerlogin_table", con);
            SqlDataReader rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(rdr);
            con.Close();
            return dt;
        }

        public void store(managerreq usr)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into request_table values(@mgrname,@projectname,@period,@noofvac,@skill,@pgmlang,@exp,@desc,@status,@desig,@date)", con);
            cmd.Parameters.AddWithValue("@mgrname", usr.mgrname);
            cmd.Parameters.AddWithValue("@projectname", usr.prjname);
            cmd.Parameters.AddWithValue("@period", usr.period);
            cmd.Parameters.AddWithValue("@noofvac", usr.noofvacancies);
            cmd.Parameters.AddWithValue("@skill", usr.skill);
            cmd.Parameters.AddWithValue("@pgmlang", usr.pgmlang);
            
            cmd.Parameters.AddWithValue("@exp", usr.exp);
            cmd.Parameters.AddWithValue("@desc", usr.prjdesc);
            cmd.Parameters.AddWithValue("@status", usr.status);
            
            cmd.Parameters.AddWithValue("@desig", usr.desig);
            cmd.Parameters.AddWithValue("@date", usr.date);


            cmd.ExecuteNonQuery();
            con.Close();
        }
        public DataTable status()
        {
            managerreq usr = new managerreq();
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from request_table", con);
           
            SqlDataReader rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            
            dt.Load(rdr);
            
            con.Close();
            return dt;
        }
        public DataTable app()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from application_table", con);
            SqlDataReader rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(rdr);
            con.Close();
            return dt;
        }
        public void storecandidate(candidate cn)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into candidate_table values(@cand_name,@skills,@pgm_language,@high_qualification,@college,@university,@address,@exp_years,@notice_months,@latest_company,@latest_desg,@cur_sal,@reg_date,@age,@dob,@reqid,@cand_email,@interview_date,@appid)", con);
            
            cmd.Parameters.AddWithValue("@cand_name", cn.candidatename);
            
            cmd.Parameters.AddWithValue("@skills", cn.candidateskills);
            cmd.Parameters.AddWithValue("@pgm_language", cn.pgmlanguage);
            cmd.Parameters.AddWithValue("@high_qualification", cn.qualification);
            cmd.Parameters.AddWithValue("@college", cn.college);
            cmd.Parameters.AddWithValue("@university", cn.university);
            cmd.Parameters.AddWithValue("@address", cn.address);
            cmd.Parameters.AddWithValue("@exp_years", cn.experience);
            cmd.Parameters.AddWithValue("@notice_months", cn.noticeperiod);
            cmd.Parameters.AddWithValue("@latest_company", cn.latestcompany);

            cmd.Parameters.AddWithValue("@latest_desg", cn.latestdesignation);

            cmd.Parameters.AddWithValue("@cur_sal", cn.currentsalary);

            cmd.Parameters.AddWithValue("@reg_date", cn.registerationdate);

            cmd.Parameters.AddWithValue("@age", cn.age);
            cmd.Parameters.AddWithValue("@dob", cn.dob);
            cmd.Parameters.AddWithValue("@reqid", cn.requestid);
            cmd.Parameters.AddWithValue("@cand_email", cn.email);
            cmd.Parameters.AddWithValue("@interview_date", cn.interviewdate);
            cmd.Parameters.AddWithValue("@appid", cn.applid);



            cmd.ExecuteNonQuery();

            con.Close();

        }
        public DataTable candidatedetails(candidate cn)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from hiredcandidate_table" , con);
            //cmd.Parameters.AddWithValue("@reqid", cn.requestid);
            
            SqlDataReader rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(rdr);
            con.Close();
            return dt;
        }
    }
}