using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UserBll
    {
        UserDll dal = new UserDll();
        public bool userLogin(UserInfo model)
        {
            return dal.userLogin(model.Name, model.PassWord)>0;
        }
        public DataSet GetUserList()
        {
            return dal.GetUserList();
        }
    }
}
