using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CustInfoLogMethods
    {
        CustUserinfo1Entities context = null;
        public CustInfoLogMethods()
        {
            context = new CustUserinfo1Entities();
        }
        public List<CustLoginfo> GetCustLoginfos()
        {
            return context.CustLoginfoes.ToList();
        }
        public bool SaveCustLog(CustLoginfo t)
        {
            try
            {
                context.CustLoginfoes.Add(t);
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
    public class UserInfoMethods
    {
        CustUserinfo1Entities user = null;
        public UserInfoMethods()
        {
            user = new CustUserinfo1Entities();
        }
        public Userinfo Checklogin(int kp,string p)
        {
            Userinfo k = null;
            foreach(var item in user.Userinfoes.ToList())
            {
                if(kp==item.Userid && p == item.Password)
                {
                    k = item;
                }
            }
            return k;
        }
    }
}
