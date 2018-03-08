using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections;

namespace susheSys.DAL
{
    /// <summary>
    /// DBM 的摘要说明。
    /// </summary>
    public class DBM
    {
        /// <summary>
        /// 返回连接
        /// </summary>
        public static SqlConnection Conn
        {
            get
            {
                string str = System.Configuration.ConfigurationManager.ConnectionStrings["susheString"].ConnectionString;
                return new SqlConnection(str);
            }
        }

        /// <summary>
        /// 单表查询操作
        /// </summary>
        /// <param name="sql">Select语句</param>
        /// <returns></returns>
        public static DataTable getTable(string sql)
        {
            SqlDataAdapter dap = new SqlDataAdapter(sql, DBM.Conn);
            DataTable dt = new DataTable();
            dap.Fill(dt);
            return dt;
        }


        /// <summary>
        /// 多表查询操作
        /// </summary>
        /// <param name="sql">Select语句</param>
        /// <returns></returns>
        public static DataSet getDataSet(string sql)
        {

            SqlDataAdapter dap = new SqlDataAdapter(sql, DBM.Conn);
            DataSet ds = new DataSet();
            dap.Fill(ds);
            return ds;
        }

        /// <summary>
        /// 单表分页查询
        /// </summary>
        /// <param name="sql">Select语句</param>
        /// <param name="start">开始</param>
        /// <param name="size">个数</param>
        /// <returns></returns>
        public static DataTable getTable(string sql, int start, int size)
        {

            SqlDataAdapter dap = new SqlDataAdapter(sql, DBM.Conn);
            DataSet ds = new DataSet();
            dap.Fill(ds, start, size, "tmp");
            return ds.Tables["tmp"];
        }


        /// <summary>
        /// 执行命令
        /// </summary>
        /// <param name="sql">Insert Update Delete语句</param>
        /// <returns></returns>
        public static Exception Execute(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, DBM.Conn);
            cmd.Connection.Open();
            SqlTransaction tran = cmd.Connection.BeginTransaction();
            cmd.Transaction = tran;
            Exception exret = null;
            try
            {
                cmd.ExecuteNonQuery();
                tran.Commit();
            }
            catch (Exception ex)
            {
                tran.Rollback();
                exret = ex;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return exret;
        }

        /// <summary>
        /// 调用存储过程(无结果集)
        /// </summary>
        /// <param name="mp"></param>
        /// <returns></returns>
        public static Exception CallProc(MakeParameter mp)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = mp.ProcName;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = DBM.Conn;

            for (int i = 0; i < mp.List.Count; i++)
            {
                cmd.Parameters.Add(mp.List[i]);
            }
            foreach (object key in mp.Table.Keys)
            {
                cmd.Parameters.Add(mp.Table[key]);
            }

            cmd.Connection.Open();
            SqlTransaction tran = cmd.Connection.BeginTransaction();
            cmd.Transaction = tran;
            try
            {
                cmd.ExecuteNonQuery();
                tran.Commit();
            }
            catch (Exception ex)
            {
                tran.Rollback();
                return ex;
            }
            finally
            {
                cmd.Connection.Close();
            }

            return null;
        }

        /// <summary>
        /// 调用存储过程(有结果集)
        /// </summary>
        /// <param name="mp"></param>
        /// <returns></returns>
        public static DataSet CallProcWithDataSet(MakeParameter mp)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = mp.ProcName;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = DBM.Conn;

            for (int i = 0; i < mp.List.Count; i++)
            {
                cmd.Parameters.Add(mp.List[i]);
            }
            foreach (object key in mp.Table.Keys)
            {
                cmd.Parameters.Add(mp.Table[key]);
            }

            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            try
            {

                dap.Fill(ds);

            }
            catch
            {


            }
            finally
            {
                if (cmd.Connection.State != ConnectionState.Closed)
                    cmd.Connection.Close();
            }

            return ds;
        }

    }


public class MakeParameter
    {
        private ArrayList list;
        private Hashtable table;
        private string procname;
        
        //DAO写DBM读
        /// <summary>
        /// 存储过程名
        /// </summary>
        public string ProcName
        {
            get
            {
                return procname;
            }
            set
            {
                procname = value;
            }
        }

        public MakeParameter(string procName):this()
        {
            this.procname = procName;
        }
        public MakeParameter()
        {
            list = new ArrayList();
            table = new Hashtable();
            SqlParameter para = new SqlParameter("@tmp", SqlDbType.Int);
            para.Direction = ParameterDirection.ReturnValue;
            list.Add(para);
        }

        //DAO写
        /// <summary>
        /// 增加输入参数
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        public void addInputParameter(string name, object value)
        {
            SqlParameter para = new SqlParameter(name, value);
            list.Add(para);
        }


        /// <summary>
        /// 增加输出参数
        /// </summary>
        /// <param name="name"></param>
        /// <param name="type"></param>
        /// <param name="size"></param>
        public void addOutputParameter(string name, SqlDbType type, int size)
        {
            SqlParameter para = new SqlParameter(name, type, size);
            para.Direction = ParameterDirection.Output;
            table.Add(name, para);
        }
        //DBM读
        /// <summary>
        /// 得到参数据列表
        /// </summary>
        public ArrayList List
        {
            get
            {
                return list;
            }
        }


        /// <summary>
        /// 得到输出参数 DBM用
        /// </summary>
        public Hashtable Table
        {
            get
            {
                return table;
            }
        }
        //DAO读
        /// <summary>
        /// 获得返回值
        /// </summary>
        /// <returns></returns>
        public object getReturnValue()
        {
            SqlParameter para = (SqlParameter)list[0];
            return para.Value;
        }


        /// <summary>
        /// 获得输出值 DAO读取
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public object getOutputValue(string name)
        {
            SqlParameter para = (SqlParameter)table[name];
            return para.Value;
        }
             
        //执行调用 DAO调用
        public Exception Execute()
        {
            
            return DBM.CallProc(this);
        }

        public DataSet ExecuteWithDataSet()
        {
            
            return DBM.CallProcWithDataSet(this);
        }
    }
}
