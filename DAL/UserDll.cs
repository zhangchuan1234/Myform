using DAL.Base;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UserDll
    {
        DbBase db = new DbBase();
        //用户登录的方法
        public int userLogin(string name, string psw)
        {
            string strsql = "select * from UserInfo where UserName = '" + name + "' and PassWord = '" + psw + "'";
            return db.returnRowCount(strsql);
        }
        public DataSet GetUserList()
        {            
            string sql = @"select * from UserInfo";
            return DbHelper.Query(sql);
        }        
    }
}
