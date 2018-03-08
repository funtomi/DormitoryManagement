using System;
using System.Collections.Generic;
using System.Data;
using susheSys.DAL;
using susheSys.Models;

namespace susheSys.BLL
{
    /// <summary>
    /// TbuserBusiness的摘要说明
    /// </summary>
    public static partial class TbuserBLL
    {

	/// <summary>
        /// 获取一个实体对象
        /// </summary>        
        public static TbuserInfo GetModel(object id)
	{
            return TbuserDAL.GetModel(id);	            	
	}

        /// <summary>
        /// 查询所有数据并返回数据集
        /// </summary>        
        public static List<TbuserInfo> GetTbuser()
        {
            return TbuserDAL.GetTbuser("");
        }
         /// <summary>
        /// 查询所有数据并返回数据集
        /// </summary>        
        public static DataTable GetTbuserDT(string strWhere)
        {
            return TbuserDAL.GetTbuserDT(strWhere);
        }
        
        /// <summary>
        /// 查询所有数据并返回数据集
        /// </summary>        
        public static List<TbuserInfo> GetTbuser(string strWhere)
        {
            return TbuserDAL.GetTbuser(strWhere);
        }

        /// <summary>
        /// 添加数据
        /// </summary>
        /// <param name="Tbuser">数据表实体对象</param>        
        public static Exception Add(TbuserInfo TbuserInfo)
        {
            return TbuserDAL.Add(TbuserInfo);
        }

        /// <summary>
        /// 更新数据
        /// </summary>
        /// <param name="Tbuser">数据表实体对象</param>
        public static Exception Update(TbuserInfo TbuserInfo)
        {
            return TbuserDAL.Update(TbuserInfo);
        }

        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="pkId">表主键</param>
        public static Exception Delete(object pkId)
        {
            return TbuserDAL.Delete(pkId);
        }
    }
}
