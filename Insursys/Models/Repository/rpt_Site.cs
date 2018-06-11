using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Insursys.Models.Repository
{
    public class rpt_Site
    {
        RSEntities db = new RSEntities();

        public int GetSiteByHost(string _host = null)
        {
            var qGetSiteId = db.RS_Site.Single(s => s.Site_Hosts.Contains(_host)).Site_Id;
            return qGetSiteId;
        }

        public RS_Site GetSiteInfo(string _host = null)
        {
            var qGetList = db.RS_Site.Single(s => s.Site_Hosts.Contains(_host));
            return qGetList;
        }
    }
}