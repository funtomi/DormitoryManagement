using System;
using System.Data;
using System.Collections.Generic;
using susheSys.Models;

namespace susheSys.DAL
{
    /// <summary>
    /// TbsusheDAO的摘要说明    
    /// </summary>
  public static partial class TbsusheDAL
    {
	/// <summary>
        /// 获取一个实体对象
        /// </summary>        
        public static TbsusheInfo GetModel(object id)
        {
            string strWhere = "id =" + id.ToString();
            List<TbsusheInfo> list = GetTbsushe(strWhere);
            if (list.Count > 0)
                return list[0];
            return null;
        }
        /// <summary>
        /// 查询所有数据并返回数据集
        /// </summary>
	public static List<TbsusheInfo> GetTbsushe(string strWhere)
	{
            string sql = "select * from [Tbsushe]";
            sql = (strWhere.Length > 0) ? sql += " where " + strWhere : sql;
            DataTable dt = DBM.getTable(sql);
            List<TbsusheInfo> list = new List<TbsusheInfo>();
            foreach (DataRow dr in dt.Rows)
            {
            	TbsusheInfo model=new TbsusheInfo();
            	model.Id = int.Parse(dr["Id"].ToString());
            	model.Ssname = dr["Ssname"].ToString();
            	model.Remark = dr["Remark"].ToString();
                model.Pic = "Upload/"+dr["Pic"].ToString();
            	list.Add(model);
            }
            return list;
        }
    /// <summary>
    /// 查询所有数据并返回数据集
    /// </summary>
    public static DataTable  GetTbsusheDT(string strWhere)
    {
        string sql = "select * from [Tbsushe]";
        sql = (strWhere.Length > 0) ? sql += " where " + strWhere : sql;
        DataTable dt = DBM.getTable(sql);
        
        return dt;
    }
    /// <summary>
    /// 查询所有数据并返回数据集
    /// </summary>
    public static DataTable GetTbsusheTop(int i,string strWhere)
    {
        string sql = "select top " + i + "  [id],[ssname],'~/Upload/'+[pic] as pic  from [Tbsushe]";
        sql = (strWhere.Length > 0) ? sql += " where " + strWhere : sql;
        sql += " order by id desc ";
        DataTable dt = DBM.getTable(sql);

        return dt;
    }
        /// <summary>
        /// 添加数据
        /// </summary>
        /// <param name="Tbsushe">数据表实体对象</param>        
        public static Exception Add(TbsusheInfo Tbsushe)
        {
            string sql = string.Format("insert into [Tbsushe] values ('{0}','{1}','{2}')", Tbsushe.Ssname, Tbsushe.Remark, Tbsushe.Pic);
            return DBM.Execute(sql);
        }
        ///GetPK
        /// <summary>
        /// 根据数据表主键更新数据
        /// </summary>
        /// <param name="Tbsushe">数据表实体对象</param>
        public static Exception Update(TbsusheInfo Tbsushe)
        {
            string sql = string.Format("update [Tbsushe] set[ssname]='{0}',[remark]='{1}',[pic]='{2}' where[id]='{3}'", Tbsushe.Ssname, Tbsushe.Remark, Tbsushe.Pic, Tbsushe.Id);
            return DBM.Execute(sql);
        }

        /// <summary>
        /// 根据数据表主键删除数据
        /// </summary>
        /// <param name="pkId">数据表实体对象</param>
        public static Exception Delete(object pkId)
        {
            string sql="delete from [Tbsushe]  where [id]="+pkId.ToString();
            return DBM.Execute(sql);
        }
    }
}
