using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using NUnit.Framework;

namespace DALTest
{
    [TestFixture]
    public class CustInfoLogtest
    {
        CustUserinfo1Entities context = new CustUserinfo1Entities();

        [Test]
        public void GetallLogininfoesTest()
        {
            bool k = true;
            List<CustLoginfo> m = context.CustLoginfoes.ToList();
            if (m != null)
            {
                k = true;
            }
            else
            {
                k = false;
            }
            Assert.IsTrue(k);
        }
        [TestCase]
        public void SaveCustLogInfoTest()
        {
            bool k = true;
            try
            {
                context.SaveChanges();
                k = true;
            }
            catch
            {
                k = false;

            }
            Assert.IsTrue(k);
        }
    }
        [TestFixture]
    public class UserinfoLogTest
    {
        CustUserinfo1Entities context = null;
        public UserinfoLogTest()
        {
            context = new CustUserinfo1Entities();
        }
        [TestCase(1,"siva@123",ExpectedResult =true)]
        public bool Logintest(object ans1,object ans2)
        {
            bool k = false;
            foreach(var item in context.Userinfoes.ToList())
            {
                if(item.Userid==(int)ans1 && item.Password == ans2.ToString())
                {
                    k = true;
                }
            }
            return k;
        }
    }


}
