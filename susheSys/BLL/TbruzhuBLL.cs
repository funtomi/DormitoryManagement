using System;
using System.Collections.Generic;
using System.Data;
using susheSys.DAL;
using susheSys.Models;

namespace susheSys.BLL
{
    /// <summary>
    /// TbruzhuBusiness的摘要说明
    /// </summary>
    public static partial class TbruzhuBLL
    {

	/// <summary>
        /// 获取一个实体对象
        /// </summary>        
        public static TbruzhuInfo GetModel(object id)
	{
            return TbruzhuDAL.GetModel(id);	            	
	}

        /// <summary>
        /// 查询所有数据并返回数据集
        /// </summary>        
        public static List<TbruzhuInfo> GetTbruzhu()
        {
            return TbruzhuDAL.GetTbruzhu("");
        }

        /// <summary>
        /// 查询所有数据并返回数据集
        /// </summary>        
        public static List<TbruzhuInfo> GetTbruzhu(string strWhere)
        {
            return TbruzhuDAL.GetTbruzhu(strWhere);
        }

        public static DataTable GetTbruzhuDT(string strWhere)
        {
            return TbruzhuDAL.GetTbruzhuDT(strWhere);
        }

        /// <summary>
        /// 添加数据
        /// </summary>
        /// <param name="Tbruzhu">数据表实体对象</param>        
        public static Exception Add(TbruzhuInfo TbruzhuInfo)
        {
            return TbruzhuDAL.Add(TbruzhuInfo);
        }

        /// <summary>
        /// 更新数据
        /// </summary>
        /// <param name="Tbruzhu">数据表实体对象</param>
        public static Exception Update(TbruzhuInfo TbruzhuInfo)
        {
            return TbruzhuDAL.Update(TbruzhuInfo);
        }

        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="pkId">表主键</param>
        public static Exception Delete(object pkId)
        {
            return TbruzhuDAL.Delete(pkId);
        }
    }
}
