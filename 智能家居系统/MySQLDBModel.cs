using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace 智能家居系统
{

    /// <summary>
    /// MySQL数据库处理（数据库每5秒刷新，所以与数据库建立长连接）
    /// </summary>
    class MySQLDBModel
    {
        /// <summary>
        /// 数据库长连接
        /// </summary>
        public MySqlConnection DataBaseConnection;

        /// <summary>
        /// 数据库命令
        /// </summary>
        public MySqlCommand DataBaseCommand;
        
        /// <summary>
        /// 建立数据库连接.
        /// </summary>
        public bool CreateConnection()
        {
            UnityModule.DebugPrint("正在创建数据库连接...");
            try
            {
                string ConnectionString = "server=localhost;user id=root;password=987412365;database=iot";
                DataBaseConnection = new MySqlConnection(ConnectionString);
                DataBaseCommand = new MySqlCommand() { Connection=DataBaseConnection};
                DataBaseConnection.Open();
                UnityModule.DebugPrint("数据库连接创建成功！数据库状态：" + DataBaseConnection.State.ToString());
                return (DataBaseConnection.State== ConnectionState.Open);
            }
            catch (Exception ex)
            {
                //throw new Exception("创建MySql数据库连接时失败！"+ex.Message);
                UnityModule.DebugPrint("创建MySql数据库连接时失败！" + ex.Message);
                return false;
            }
        }

        /// <summary>
        /// 执行数据库命令
        /// </summary>
        /// <param name="SQLCommand">数据库读取命令</param>
        /// <param name="SQLValue">数据库命令内包含的值</param>
        /// <returns>读取结果</returns>
        public bool ExecuteNonQuery(string SQLCommand, params object[] SQLValue)
        {
            return ExecuteNonQuery(string.Format(SQLCommand, SQLValue));
        }

        /// <summary>
        /// 执行数据库命令
        /// </summary>
        /// <param name="SQLCommand">数据库命令</param>
        /// <returns>执行结果</returns>
        public bool ExecuteNonQuery(string SQLCommand)
         {
            if (DataBaseConnection == null)
            {
                UnityModule.DebugPrint("数据库连接未创建，无法执行SQL:" + SQLCommand);
                return false;
            }
            if (DataBaseConnection.State != ConnectionState.Open)
            {
                UnityModule.DebugPrint("数据库状态为：" + DataBaseConnection.State.ToString()+"；无法执行SQL:" + SQLCommand);
                return false;
            }

            try
            {
                DataBaseCommand.CommandText = SQLCommand;
                DataBaseCommand.ExecuteNonQuery();
                UnityModule.DebugPrint("命令执行成功：" + SQLCommand);
                return true;
            }
            catch (Exception ex)
            {
                UnityModule.DebugPrint("执行SQL遇到错误：\n\t" + SQLCommand + "\n\t" + ex.Message);
                return false;
            }
         }

        /// <summary>
        /// 读取数据库
        /// </summary>
        /// <param name="SQLCommand">数据库读取命令</param>
        /// <param name="SQLValue">数据库命令内包含的值</param>
        /// <returns>读取结果</returns>
        public MySqlDataReader ExecuteReader(string SQLCommand, params object[] SQLValue)
        {
            return ExecuteReader(string.Format(SQLCommand, SQLValue));
        }

        /// <summary>
        /// 读取数据库
        /// </summary>
        /// <param name="SQLCommand">数据库读取命令</param>
        /// <returns>读取结果</returns>
        public MySqlDataReader ExecuteReader(string SQLCommand)
        {
            if (DataBaseConnection == null)
            {
                UnityModule.DebugPrint("数据库连接未创建，无法读取SQL:" + SQLCommand);
                return null;
            }
            if (DataBaseConnection.State != ConnectionState.Open)
            {
                UnityModule.DebugPrint("数据库状态为：" + DataBaseConnection.State.ToString() + "；无法读取SQL:" + SQLCommand);
                return null;
            }

            try
            {
                DataBaseCommand.CommandText = SQLCommand;
                MySqlDataReader DataReader=DataBaseCommand.ExecuteReader();
                UnityModule.DebugPrint("命令执行成功：" + SQLCommand);
                return DataReader;
            }
            catch (Exception ex)
            {
                UnityModule.DebugPrint("读取SQL遇到错误：\n\t" + SQLCommand + "\n\t" + ex.Message);
                return null;
            }
        }

        /// <summary>
        /// 读取数据库返回值第一列第一行
        /// </summary>
        /// <param name="SQLCommand">数据库读取命令</param>
        /// <param name="SQLValue">数据库命令内包含的值</param>
        /// <returns>读取结果</returns>
        public object ExecuteScalar(string SQLCommand,params object[] SQLValue)
        {
            return ExecuteScalar(string.Format(SQLCommand, SQLValue));
        }

        /// <summary>
        /// 读取数据库返回值第一列第一行
        /// </summary>
        /// <param name="SQLCommand">数据库读取命令</param>
        /// <returns>读取结果</returns>
        public object ExecuteScalar(string SQLCommand)
        {
            if (DataBaseConnection == null)
            {
                UnityModule.DebugPrint("数据库连接未创建，无法读取SQL:" + SQLCommand);
                return null;
            }
            if (DataBaseConnection.State != ConnectionState.Open)
            {
                UnityModule.DebugPrint("数据库状态为：" + DataBaseConnection.State.ToString() + "；无法读取SQL:" + SQLCommand);
                return null;
            }

            try
            {
                DataBaseCommand.CommandText = SQLCommand;
                object DataValue = DataBaseCommand.ExecuteScalar();
                UnityModule.DebugPrint("命令执行成功：" + SQLCommand);
                return DataValue;
            }
            catch (Exception ex)
            {
                UnityModule.DebugPrint("读取SQL遇到错误：\n\t\t\t" + SQLCommand + "\n\t\t\t" + ex.Message);
                return null;
            }
        }

        public void CloseConnection()
        {
            UnityModule.DebugPrint("正在关闭数据库连接...");
            if (DataBaseConnection == null) return;
            if (DataBaseConnection.State == ConnectionState.Open)
                DataBaseConnection.Close();
            DataBaseConnection = null;
            UnityModule.DebugPrint("已经关闭数据库连接");
        }

    }

}
