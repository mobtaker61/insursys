using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Insursys.Models.Repository
{
    public class rpt_Costumer
    {
        RSEntities db = new RSEntities();

        public List<RS_Account> GetCostumerList(int _AccountId)
        {
            var qGetList = db.RS_Account.Where(p => p.Account_ParentId == _AccountId).ToList();
            return qGetList;
        }

        public RS_Account GetCostumerDetail(int _AccountId)
        {
            var qGetInfo = db.RS_Account.Single(c => c.Account_Id == _AccountId);
            return qGetInfo;
        }

        public RS_AccountInfo GetCostumerInfo(int _AccountId)
        {
            var qGetInfo = db.RS_AccountInfo.Single(c => c.AccountInfo_AccountId == _AccountId);
            return qGetInfo;
        }
        public List<RS_AccountAddress> GetCostumerAddress(int _AccountId)
        {
            var qGetInfo = db.RS_AccountAddress.Where(c => c.AccountAddress_AccountId == _AccountId).ToList();
            return qGetInfo;
        }

        public List<RS_AccountContact> GetCostumerContact(int _AccountId)
        {
            var qGetInfo = db.RS_AccountContact.Where(c => c.AccountContact_AccountId == _AccountId).ToList();
            return qGetInfo;
        }
    }
}