using System;
using System.Data;
using System.Collections.Generic;
using susheSys.Models;

namespace susheSys.DAL
{
    /// <summary>
    /// TbchuangDAO的摘要说明    
    /// </summary>
  public static partial class TbchuangDAL
    {
	/// <summary>
        /// 获取一个实体对象
        /// </summary>        
        public static TbchuangInfo GetModel(object id)
        {
            string strWhere = "id =" + id.ToString();
            List<TbchuangInfo> list = GetTbchuang(strWhere);
            if (list.Count > 0)
                return list[0];
            return null;
        }
        /// <summary>
        /// 查询所有数据并返回数据集
        /// </summary>
	public static List<TbchuangInfo> GetTbchuang(string strWhere)
	{
            string sql = "select * from [Tbchuang]";
            sql = (strWhere.Length > 0) ? sql += " where " + strWhere : sql;
            DataTable dt = DBM.getTable(sql);
            List<TbchuangInfo> list = new List<TbchuangInfo>();
            foreach (DataRow dr in dt.Rows)
            {
            	TbchuangInfo model=new TbchuangInfo();
            	model.Id = int.Parse(dr["Id"].ToString());
            	model.Chuangnum = dr["Chuangnum"].ToString();
            	model.Susheid = int.Parse(dr["Susheid"].ToString());
            	model.Remark = dr["Remark"].ToString();
                model.Pic = "Upload/" + dr["Pic"].ToString();
            	list.Add(model);
            }
            return list;
        }
    public static DataTable  GetTbchuangDT(string strWhere)
    {
        string sql = "select * from [Tbchuang]";
        sql = (strWhere.Length > 0) ? sql += " where " + strWhere : sql;
        DataTable dt = DBM.getTable(sql);
        return dt;
    }
        /// <summary>
        /// 添加数据
        /// </summary>
        /// <param name="Tbchuang">数据表实体对象</param>        
        public static Exception Add(TbchuangInfo Tbchuang)
        {
            string sql = string.Format("insert into [Tbchuang] values ('{0}','{1}','{2}','{3}')", Tbchuang.Chuangnum, Tbchuang.Susheid, Tbchuang.Remark, Tbchuang.Pic);
            return DBM.Execute(sql);
        }
        ///GetPK
        /// <summary>
        /// 根据数据表主键更新数据
        /// </summary>
        /// <param name="Tbchuang">数据表实体对象</param>
        public static Exception Update(TbchuangInfo Tbchuang)
        {
            string sql = string.Format("update [Tbchuang] set[chuangNum]='{0}',[susheid]='{1}',[remark]='{2}',[pic]='{3}' where[id]='{4}'", Tbchuang.Chuangnum, Tbchuang.Susheid, Tbchuang.Remark, Tbchuang.Pic, Tbchuang.Id);
            return DBM.Execute(sql);
        }

        /// <summary>
        /// 根据数据表主键删除数据
        /// </summary>
        /// <param name="pkId">数据表实体对象</param>
        public static Exception Delete(object pkId)
        {
            string sql="delete from [Tbchuang]  where [id]="+pkId.ToString();
            return DBM.Execute(sql);
        }
    }
}
