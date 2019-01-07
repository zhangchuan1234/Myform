using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DbBase
    {
        public static string strCon = System.Configuration.ConfigurationManager.ConnectionStrings["dbConnection"].ConnectionString;
        //实例化连接对象 con
        SqlConnection con = new SqlConnection(strCon);

        //检测连接是否打开
        public void chkConnection()
        {
            if (this.con.State == ConnectionState.Closed)
            {
                this.con.Open();
            }
        }

        //执行语句，返回该语句查询的数据行的总数
        public int returnRowCount(string strSQL)
        {
            chkConnection();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(strSQL, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds.Tables[0].Rows.Count;
            }
            catch
            {
                return 0;
            }
        }
        public DataSet Query(string strSQL)
        {
            chkConnection();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(strSQL, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
            catch
            {
                return null;
            }
        }
    }
}
