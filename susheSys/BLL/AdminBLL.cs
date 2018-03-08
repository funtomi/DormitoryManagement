using System;
using System.Collections.Generic;
using System.Data;
using susheSys.DAL;
using susheSys.Models;

namespace susheSys.BLL
{
    /// <summary>
    /// AdminBusiness的摘要说明
    /// </summary>
    public static partial class AdminBLL
    {

	/// <summary>
        /// 获取一个实体对象
        /// </summary>        
        public static AdminInfo GetModel(object id)
	{
            return AdminDAL.GetModel(id);	            	
	}

        /// <summary>
        /// 查询所有数据并返回数据集
        /// </summary>        
        public static List<AdminInfo> GetAdmin()
        {
            return AdminDAL.GetAdmin("");
        }

        /// <summary>
        /// 查询所有数据并返回数据集
        /// </summary>        
        public static List<AdminInfo> GetAdmin(string strWhere)
        {
            return AdminDAL.GetAdmin(strWhere);
        }
        public static DataTable GetAdminDT(string strWhere)
        {
            return AdminDAL.GetAdminDT(strWhere);
        }
        /// <summary>
        /// 添加数据
        /// </summary>
        /// <param name="Admin">数据表实体对象</param>        
        public static Exception Add(AdminInfo AdminInfo)
        {
            return AdminDAL.Add(AdminInfo);
        }

        /// <summary>
        /// 更新数据
        /// </summary>
        /// <param name="Admin">数据表实体对象</param>
        public static Exception Update(AdminInfo AdminInfo)
        {
            return AdminDAL.Update(AdminInfo);
        }

        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="pkId">表主键</param>
        public static Exception Delete(object pkId)
        {
            return AdminDAL.Delete(pkId);
        }
    }
}
