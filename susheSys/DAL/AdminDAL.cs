using System;
using System.Data;
using System.Collections.Generic;
using susheSys.Models;

namespace susheSys.DAL
{
    /// <summary>
    /// AdminDAO的摘要说明    
    /// </summary>
  public static partial class AdminDAL
    {
	/// <summary>
        /// 获取一个实体对象
        /// </summary>        
        public static AdminInfo GetModel(object id)
        {
            string strWhere = "ID =" + id.ToString();
            List<AdminInfo> list = GetAdmin(strWhere);
            if (list.Count > 0)
                return list[0];
            return null;
        }
        /// <summary>
        /// 查询所有数据并返回数据集
        /// </summary>
	public static List<AdminInfo> GetAdmin(string strWhere)
	{
            string sql = "select * from [Admin]";
            sql = (strWhere.Length > 0) ? sql += " where " + strWhere : sql;
            DataTable dt = DBM.getTable(sql);
            List<AdminInfo> list = new List<AdminInfo>();
            foreach (DataRow dr in dt.Rows)
            {
            	AdminInfo model=new AdminInfo();
            	model.Id = int.Parse(dr["Id"].ToString());
            	model.Name = dr["Name"].ToString();
            	model.Pass = dr["Pass"].ToString();
            	list.Add(model);
            }
            return list;
        }
    public static DataTable GetAdminDT(string strWhere)
    {
        string sql = "select * from [Admin]";
        sql = (strWhere.Length > 0) ? sql += " where " + strWhere : sql;
        DataTable dt = DBM.getTable(sql);

        return dt;
    }
        /// <summary>
        /// 添加数据
        /// </summary>
        /// <param name="Admin">数据表实体对象</param>        
        public static Exception Add(AdminInfo Admin)
        {
            string sql=string.Format("insert into [Admin] values ('{0}','{1}')",Admin.Name,Admin.Pass);
            return DBM.Execute(sql);
        }
        ///GetPK
        /// <summary>
        /// 根据数据表主键更新数据
        /// </summary>
        /// <param name="Admin">数据表实体对象</param>
        public static Exception Update(AdminInfo Admin)
        {
            string sql=string.Format("update [Admin] set[Name]='{0}',[pass]='{1}' where[ID]='{2}'",Admin.Name,Admin.Pass,Admin.Id);
            return DBM.Execute(sql);
        }

        /// <summary>
        /// 根据数据表主键删除数据
        /// </summary>
        /// <param name="pkId">数据表实体对象</param>
        public static Exception Delete(object pkId)
        {
            string sql="delete from [Admin]  where [ID]="+pkId.ToString();
            return DBM.Execute(sql);
        }
    }
}
