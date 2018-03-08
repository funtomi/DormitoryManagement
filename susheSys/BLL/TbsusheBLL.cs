using System;
using System.Collections.Generic;
using System.Data;
using susheSys.DAL;
using susheSys.Models;

namespace susheSys.BLL
{
    /// <summary>
    /// TbsusheBusiness的摘要说明
    /// </summary>
    public static partial class TbsusheBLL
    {

	/// <summary>
        /// 获取一个实体对象
        /// </summary>        
        public static TbsusheInfo GetModel(object id)
	{
            return TbsusheDAL.GetModel(id);	            	
	}

        /// <summary>
        /// 查询所有数据并返回数据集
        /// </summary>        
        public static List<TbsusheInfo> GetTbsushe()
        {
            return TbsusheDAL.GetTbsushe("");
        }

        /// <summary>
        /// 查询所有数据并返回数据集
        /// </summary>        
        public static List<TbsusheInfo> GetTbsushe(string strWhere)
        {
            return TbsusheDAL.GetTbsushe(strWhere);
        }
        public static DataTable GetTbsusheDT(string strWhere)
        {
            return TbsusheDAL.GetTbsusheDT(strWhere);
        }
        public static DataTable GetTbsusheTop(int i, string strWhere)
        {
            return TbsusheDAL.GetTbsusheTop(i,strWhere);
        }
        
        /// <summary>
        /// 添加数据
        /// </summary>
        /// <param name="Tbsushe">数据表实体对象</param>        
        public static Exception Add(TbsusheInfo TbsusheInfo)
        {
            return TbsusheDAL.Add(TbsusheInfo);
        }

        /// <summary>
        /// 更新数据
        /// </summary>
        /// <param name="Tbsushe">数据表实体对象</param>
        public static Exception Update(TbsusheInfo TbsusheInfo)
        {
            return TbsusheDAL.Update(TbsusheInfo);
        }

        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="pkId">表主键</param>
        public static Exception Delete(object pkId)
        {
            return TbsusheDAL.Delete(pkId);
        }
    }
}
