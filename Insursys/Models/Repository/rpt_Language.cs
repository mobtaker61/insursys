using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Insursys.Models.Repository
{
    public class rpt_Language
    {
        RSEntities db = new RSEntities();

        public RS_Language GetLangDetail(int langid)
        {
            var qGetLang = db.RS_Language.Where(l => l.Language_Active == true).Single(l => l.Language_Id == langid);
            return qGetLang;
        }

        public List<RS_Language> GetLangList(string _curLang = null)
        {
            var qGetList = db.RS_Language.Where(l => l.Language_Active == true).ToList();
            if (_curLang != null)
            {
                qGetList = db.RS_Language.Where(l => l.Language_Iso != _curLang).ToList();
            }
            return qGetList;
        }
    }
}