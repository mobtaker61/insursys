using Insursys.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Insursys
{
    public class _LoginController : Controller
    {

        [Route("_Login")]
        public ActionResult index()
        {
            return View();
        }

        public ActionResult com_login()
        {
            RSEntities db = new RSEntities();
            string status = "";
            Commander Comer = new Commander();

            #region مقدارهای اولیه
            int User_id;
            string IP = System.Web.HttpContext.Current.Request.UserHostAddress;


            string direct_url = "";

            try
            { direct_url = Request.UrlReferrer.Host; }
            catch (Exception) { }


            string password = Request.Form["val44"];
            string username = Request.Form["val67"];
            string language = Request.Form["val89"];

            
            bool Check_Has_User = Comer.Has_Username_Login(username, password, out User_id);
            #endregion

            try
            {


                if (Check_Has_User)
                {
                    RS_Account UserInfo = db.RS_Account.Single(u => u.Account_Id == User_id);

                    ///============    دستور بهینه شده اطلاعات ورود    =============///
                    ///==============================================================///
                    account_manage user_mgr = new account_manage();
                    Response.Cookies.Add(user_mgr.Login_HttpCookie(IP, UserInfo.RS_AccountInfo.AccountInfo_FirstName, UserInfo.RS_AccountInfo.AccountInfo_LastName, UserInfo.Account_Username, User_id, 72, UserInfo.RS_Language.Language_Iso));

                    FormsAuthentication.Initialize();
                    FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(1, username, DateTime.Now, DateTime.Now.AddMonths(1), true,
                        UserInfo.Account_RoleId.ToString(), FormsAuthentication.FormsCookiePath);

                    string hash = FormsAuthentication.Encrypt(ticket);
                    HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, hash);

                    if (ticket.IsPersistent) cookie.Expires = ticket.Expiration;

                    //Navid : 2018-06-11 : Cooki Language :
                    Response.Cookies["langName"].Value = language;

                    Response.Cookies.Add(cookie);
                    string returnUrl = Request.QueryString["ReturnUrl"];
                    if (returnUrl == null) returnUrl = "/";

                    //Response.Redirect("/j-admin");
                    status = "welcome";
                }
                else
                {
                    status = "noUser";
                }
            }
            catch (Exception ex)
            {
                status = ex.Message;

            }

            ContentResult ctr_result = new ContentResult();
            bool Bl = User.Identity.IsAuthenticated;
            string str = User.Identity.Name;
            ctr_result.Content = status;
            return ctr_result;

        }

        public ActionResult com_logout()
        {
            FormsAuthentication.SignOut();
            Request.Cookies.Clear();
            Response.Redirect("/");
            return View();
        }
    }

    public class _PanelController : Controller
    {
        [Route("Home")]
        public ActionResult RS_Dashboard()
        {
            return View();
        }

        [Route("Panel")]
        public ActionResult RS_List_Customer()
        {
            return View();
        }

        public ActionResult RS_Form_Customer()
        {
            return View();
        }
    }

    public class _PanelCommanderController : Controller
    {
        public ActionResult ChangeLanguage()
        {
            string LangName = Request.Form["langName"];
            Response.Cookies["langName"].Value = LangName;
            ContentResult ctr_result = new ContentResult();
            ctr_result.Content = LangName;
            return ctr_result;

        }

    }


}