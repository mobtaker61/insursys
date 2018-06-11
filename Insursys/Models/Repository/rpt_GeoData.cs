using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Insursys.Models.Repository
{
    public class rpt_GeoData
    {
        RSEntities db = new RSEntities();

        public List<RS_Loc_Country> GetCoutryList()
        {
            var qGetList = db.RS_Loc_Country.OrderBy(p => p.Country_Name).ToList();
            return qGetList;
        }


    }
}