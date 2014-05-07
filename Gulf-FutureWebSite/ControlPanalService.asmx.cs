using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using DataLayer;
namespace Gulf_FutureWebSite
{
    /// <summary>
    /// Summary description for ControlPanalService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class ControlPanalService : System.Web.Services.WebService
    {
        private dbDataContext db = new dbDataContext();
        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        #region"Users"

        [WebMethod]
        public bool CreateUser(string User, string pwd, string email, string fullName)
        {
            var q = new sysUser() { FullName = fullName, Email = email, Pwd = pwd, UserName = User };
            db.sysUsers.InsertOnSubmit(q);
            return true;
        }

        [WebMethod]
        public bool EditUser(int id, string User, string pwd, string email, string fullName)
        {
            var q = (db.sysUsers.Where(p => p.id = id)).SingleOrDefault();
            q.FullName = fullName;
            q.UserName = User;
            q.Pwd = pwd;
            q.Email = email;
            db.SubmitChanges();
            return true;
        }

        [WebMethod]
        public bool DeleteUser(int id)
        {
            var q = (db.sysUsers.Where(p => p.id = id)).SingleOrDefault();
            db.sysUsers.DeleteOnSubmit(q);
            db.SubmitChanges();
            return true;
        }
        [WebMethod]
        public List<sysUser> GetAllUser()
        {
            return db.sysUsers.ToList();
        }

       
        #endregion
        #region"AboutUs"
          [WebMethod]
        public bool UpdateAbout(string AboutAr, string AboutEn)
        {
            db.AboutUs.InsertOnSubmit(new AboutUs() { AboutEn = AboutAr, AboutEn = AboutEn });
            db.SubmitChanges();
            return true;
        }
           [WebMethod]
          public AboutUs LoadAbout()
          {
              return db.AboutUs.SingleOrDefault();
          }


        #endregion
        #region"ContactUs"
        [WebMethod]
           public bool UpdateContactUs(string boxBox, string postKey, string addressAr, string AddressEn, string DefaultEmail)
           {
            db.ContactUs.
           }

        #endregion
    }
}
