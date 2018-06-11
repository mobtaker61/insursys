using System;
using System.Collections.Generic;
using System.Web;

/// <summary>
/// Summary description for user_manage
/// </summary>
public class account_manage
{
    public HttpCookie Login_HttpCookie(object ip, object fname, object lname, object Username, object AccountId, int Expires_By_Hours, object langName)
    {
        HttpCookie UserInfo = new HttpCookie("AccountInfo"); UserInfo.HttpOnly = true;
        UserInfo["ip"] = (string)ip;
        UserInfo["fname"] = HttpUtility.UrlEncode((string)fname);
        UserInfo["lname"] = HttpUtility.UrlEncode((string)lname);
        UserInfo["Username"] = HttpUtility.UrlEncode((string)Username);
        UserInfo["AccountId"] = AccountId.ToString();
        UserInfo.Expires = DateTime.Now.AddHours(Expires_By_Hours);

        HttpCookie Lang = new HttpCookie("langName", langName.ToString());
        return UserInfo;
    }
}