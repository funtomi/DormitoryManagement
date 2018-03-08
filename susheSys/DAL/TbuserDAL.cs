using System;
using System.Data;
using System.Collections.Generic;
using susheSys.Models;

namespace susheSys.DAL
{
    /// <summary>
    /// TbuserDAO的摘要说明    
    /// </summary>
  public static partial class TbuserDAL
    {
	/// <summary>
        /// 获取一个实体对象
        /// </summary>        
        public static TbuserInfo GetModel(object id)
        {
            string strWhere = "id =" + id.ToString();
            List<TbuserInfo> list = GetTbuser(strWhere);
            if (list.Count > 0)
                return list[0];
            return null;
        }
        /// <summary>
        /// 查询所有数据并返回数据集
        /// </summary>
	public static List<TbuserInfo> GetTbuser(string strWhere)
	{
            string sql = "select * from [Tbuser]";
            sql = (strWhere.Length > 0) ? sql += " where " + strWhere : sql;
            DataTable dt = DBM.getTable(sql);
            List<TbuserInfo> list = new List<TbuserInfo>();
            foreach (DataRow dr in dt.Rows)
            {
            	TbuserInfo model=new TbuserInfo();
            	model.Id = int.Parse(dr["Id"].ToString());
            	model.Name = dr["Name"].ToString();
            	model.Pwd = dr["Pwd"].ToString();
            	model.Sex = dr["Sex"].ToString();
            	model.Phone = dr["Phone"].ToString();
            	model.Address = dr["Address"].ToString();
            	model.Email = dr["Email"].ToString();
            	model.Remark = dr["Remark"].ToString();
            	model.Uname = dr["Uname"].ToString();
            	list.Add(model);
            }
            return list;
        }

    /// <summary>
    /// 查询所有数据并返回数据集
    /// </summary>
    public static DataTable GetTbuserDT(string strWhere)
    {
        string sql = "select * from [Tbuser]";
        sql = (strWhere.Length > 0) ? sql += " where " + strWhere : sql;
        DataTable dt = DBM.getTable(sql);
        return dt;
    }

        /// <summary>
        /// 添加数据
        /// </summary>
        /// <param name="Tbuser">数据表实体对象</param>        
        public static Exception Add(TbuserInfo Tbuser)
        {
            string sql=string.Format("insert into [Tbuser] values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')",Tbuser.Name,Tbuser.Pwd,Tbuser.Sex,Tbuser.Phone,Tbuser.Address,Tbuser.Email,Tbuser.Remark,Tbuser.Uname);
            return DBM.Execute(sql);
        }
        ///GetPK
        /// <summary>
        /// 根据数据表主键更新数据
        /// </summary>
        /// <param name="Tbuser">数据表实体对象</param>
        public static Exception Update(TbuserInfo Tbuser)
        {
            string sql=string.Format("update [Tbuser] set[name]='{0}',[pwd]='{1}',[sex]='{2}',[phone]='{3}',[address]='{4}',[email]='{5}',[remark]='{6}',[uname]='{7}' where[id]='{8}'",Tbuser.Name,Tbuser.Pwd,Tbuser.Sex,Tbuser.Phone,Tbuser.Address,Tbuser.Email,Tbuser.Remark,Tbuser.Uname,Tbuser.Id);
            return DBM.Execute(sql);
        }

        /// <summary>
        /// 根据数据表主键删除数据
        /// </summary>
        /// <param name="pkId">数据表实体对象</param>
        public static Exception Delete(object pkId)
        {
            string sql="delete from [Tbuser]  where [id]="+pkId.ToString();
            return DBM.Execute(sql);
        }
    }
}
