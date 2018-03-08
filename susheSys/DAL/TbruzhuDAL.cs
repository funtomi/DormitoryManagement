using System;
using System.Data;
using System.Collections.Generic;
using susheSys.Models;

namespace susheSys.DAL
{
    /// <summary>
    /// TbruzhuDAO的摘要说明    
    /// </summary>
  public static partial class TbruzhuDAL
    {
	/// <summary>
        /// 获取一个实体对象
        /// </summary>        
        public static TbruzhuInfo GetModel(object id)
        {
            string strWhere = "id =" + id.ToString();
            List<TbruzhuInfo> list = GetTbruzhu(strWhere);
            if (list.Count > 0)
                return list[0];
            return null;
        }
        /// <summary>
        /// 查询所有数据并返回数据集
        /// </summary>
	public static List<TbruzhuInfo> GetTbruzhu(string strWhere)
	{
            string sql = "select * from [Tbruzhu]";
            sql = (strWhere.Length > 0) ? sql += " where " + strWhere : sql;
            DataTable dt = DBM.getTable(sql);
            List<TbruzhuInfo> list = new List<TbruzhuInfo>();
            foreach (DataRow dr in dt.Rows)
            {
            	TbruzhuInfo model=new TbruzhuInfo();
            	model.Id = int.Parse(dr["Id"].ToString());
            	model.Chuangid = int.Parse(dr["Chuangid"].ToString());
            	model.Userid = int.Parse(dr["Userid"].ToString());
            	model.Ruzhudate = dr["Ruzhudate"].ToString();
            	model.Tuchudate = dr["Tuchudate"].ToString();
            	model.State = int.Parse(dr["State"].ToString());
            	list.Add(model);
            }
            return list;
        }

    public static DataTable GetTbruzhuDT(string strWhere)
    {
        string sql = "select * from [Tbruzhu]";
        sql = (strWhere.Length > 0) ? sql += " where " + strWhere : sql;
        DataTable dt = DBM.getTable(sql);
         
        return dt;
    }

        /// <summary>
        /// 添加数据
        /// </summary>
        /// <param name="Tbruzhu">数据表实体对象</param>        
        public static Exception Add(TbruzhuInfo Tbruzhu)
        {
            string sql=string.Format("insert into [Tbruzhu] values ('{0}','{1}','{2}','{3}','{4}')",Tbruzhu.Chuangid,Tbruzhu.Userid,Tbruzhu.Ruzhudate,Tbruzhu.Tuchudate,Tbruzhu.State);
            return DBM.Execute(sql);
        }
        ///GetPK
        /// <summary>
        /// 根据数据表主键更新数据
        /// </summary>
        /// <param name="Tbruzhu">数据表实体对象</param>
        public static Exception Update(TbruzhuInfo Tbruzhu)
        {
            string sql=string.Format("update [Tbruzhu] set[chuangid]='{0}',[userid]='{1}',[ruzhudate]='{2}',[tuchudate]='{3}',[state]='{4}' where[id]='{5}'",Tbruzhu.Chuangid,Tbruzhu.Userid,Tbruzhu.Ruzhudate,Tbruzhu.Tuchudate,Tbruzhu.State,Tbruzhu.Id);
            return DBM.Execute(sql);
        }

        /// <summary>
        /// 根据数据表主键删除数据
        /// </summary>
        /// <param name="pkId">数据表实体对象</param>
        public static Exception Delete(object pkId)
        {
            string sql="delete from [Tbruzhu]  where [id]="+pkId.ToString();
            return DBM.Execute(sql);
        }
    }
}
