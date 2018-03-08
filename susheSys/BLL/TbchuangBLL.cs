using System;
using System.Collections.Generic;
using System.Data;
using susheSys.DAL;
using susheSys.Models;

namespace susheSys.BLL
{
    /// <summary>
    /// TbchuangBusiness的摘要说明
    /// </summary>
    public static partial class TbchuangBLL
    {

	/// <summary>
        /// 获取一个实体对象
        /// </summary>        
        public static TbchuangInfo GetModel(object id)
	{
            return TbchuangDAL.GetModel(id);	            	
	}

        /// <summary>
        /// 查询所有数据并返回数据集
        /// </summary>        
        public static List<TbchuangInfo> GetTbchuang()
        {
            return TbchuangDAL.GetTbchuang("");
        }
        public static DataTable GetTbchuangDT(string strwhere)
        {
            return TbchuangDAL.GetTbchuangDT(strwhere);
        }

        /// <summary>
        /// 查询所有数据并返回数据集
        /// </summary>        
        public static List<TbchuangInfo> GetTbchuang(string strWhere)
        {
            return TbchuangDAL.GetTbchuang(strWhere);
        }

        /// <summary>
        /// 添加数据
        /// </summary>
        /// <param name="Tbchuang">数据表实体对象</param>        
        public static Exception Add(TbchuangInfo TbchuangInfo)
        {
            return TbchuangDAL.Add(TbchuangInfo);
        }

        /// <summary>
        /// 更新数据
        /// </summary>
        /// <param name="Tbchuang">数据表实体对象</param>
        public static Exception Update(TbchuangInfo TbchuangInfo)
        {
            return TbchuangDAL.Update(TbchuangInfo);
        }

        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="pkId">表主键</param>
        public static Exception Delete(object pkId)
        {
            return TbchuangDAL.Delete(pkId);
        }
    }
}
