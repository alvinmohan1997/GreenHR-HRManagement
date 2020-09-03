using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Web.UI.WebControls;


namespace WebApplication1
{
    public class bal
    {
        managerreq mgr;
        dal d = new dal();
        List<managerreq> ls = new List<managerreq>();
        public bool Rec(userentity usr)
        {
            bool x = false;
            DataTable dt = d.dispRec();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i].ItemArray[3].ToString() == usr.email && dt.Rows[i].ItemArray[2].ToString() == usr.pwd)
                {
                    x = true;

                }
            }
            return x;
        }
        public void storereq(managerreq mgr)
        {
            d.store(mgr);
        }
        public List<managerreq> record(string name)
        {
            DataTable dt=d.status();
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                mgr = new managerreq();
                if (dt.Rows[i].ItemArray[0].ToString() == name)
                {
                    mgr.reqid = Convert.ToInt32(dt.Rows[i].ItemArray[8].ToString());
                    mgr.status = dt.Rows[i].ItemArray[9].ToString();
                    mgr.prjname = dt.Rows[i].ItemArray[1].ToString();
                    mgr.date = Convert.ToDateTime(dt.Rows[i].ItemArray[11].ToString());
                    ls.Add(mgr);


                }



            }
            return ls;
        }
        public managerreq displayapp(string name)
        {
            DataTable dt = d.app();
            int l = dt.Rows.Count-1;
            for(int i = l; i >=0; i--)
            {
                if (dt.Rows[i].ItemArray[6].ToString() == "inprogress" && dt.Rows[i].ItemArray[14].ToString()==name)
                {
                    mgr = new managerreq();
                    mgr.jobdesc = dt.Rows[i].ItemArray[1].ToString();
                    mgr.minqual = dt.Rows[i].ItemArray[2].ToString();
                    mgr.prefqual = dt.Rows[i].ItemArray[3].ToString();
                    mgr.resp = dt.Rows[i].ItemArray[4].ToString();
                    mgr.skill = dt.Rows[i].ItemArray[11].ToString();
                    mgr.pgmlang = dt.Rows[i].ItemArray[12].ToString();
                    mgr.exp= Convert.ToInt32(dt.Rows[i].ItemArray[13].ToString());
                    mgr.desig = dt.Rows[i].ItemArray[14].ToString();
                    mgr.lastdate = Convert.ToDateTime(dt.Rows[i].ItemArray[15].ToString()).AddDays(10);
                   // mgr.lastdate = DateTime.Now.AddDays(10);

                }
            }
            return mgr;
        }
        
    }
}