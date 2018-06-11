using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Insursys.Models.Repository
{
    public class rpt_Menu
    {
        RSEntities db = new RSEntities();

        public List<RS_Menu> GetMenu(int _ParentId = 0)
        {
            var qGetMenu = db.RS_Menu.Where(m => m.Menu_Active == true).ToList();
            if (_ParentId == 0)
            {
                qGetMenu = db.RS_Menu.Where(m => m.Menu_ParentId == null).ToList();
            }
            else
            {
                qGetMenu = db.RS_Menu.Where(m => m.Menu_ParentId == _ParentId).ToList();
            }
            return qGetMenu;
        }

        public RS_Menu GetMenuItemDetail(int _MenuId)
        {
            var qGetMenuItem = db.RS_Menu.Where(m => m.Menu_Id == _MenuId).Single();
            return qGetMenuItem;
        }
    }
}