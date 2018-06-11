using System.Data.SqlClient;
using Insursys.Models;
using System.Linq;

/// <summary>
/// Login For ALL Panel
/// </summary>
public class Commander
{
    RSEntities db = new RSEntities();

    #region Check Login:
    public bool Has_Username_Login(string _Username, string _Password,out int userId)
    {
        userId = 0;
        bool Has_Username_ = false;
        try
        {
            var qGetUser = db.RS_Account.Where(i => i.Account_Username == _Username).Where(i => i.Account_Password == _Password).Single();
            userId = qGetUser.Account_Id;
            Has_Username_ = true;
        }
        catch (System.Exception){}
        return Has_Username_;

    }
    #endregion

}