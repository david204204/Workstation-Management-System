using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;
using FinalProjectForm.InterfaceClases;

namespace testMySQLConnection
{
    //singeltone constractor
    public class DBConnection
    {
        public static string baseDatebaseName = string.Empty;
        public static string baseUserName = string.Empty;
        public static string basePassword = string.Empty;

        protected static string connString = string.Empty;

        private static DBConnection _instance = null;

        private static MySqlConnection connection = null;



        protected static DBConnection Instance()
        {
            bool result = true;

            if (_instance == null)
            {
                _instance = new DBConnection();

                result = !string.IsNullOrEmpty(baseDatebaseName);

                if(result)
                {
                    connString = string.Format("Server=localhost; database={0}; UID={1}; password={2}", baseDatebaseName, baseUserName, basePassword);
                    connection = new MySqlConnection(connString);
                }

            }
            return _instance;
        }

        public bool Connect()
        {
            bool result = true;

            try
            {
                connection.Open();
            }
            catch(Exception e)
            {
                ErrHandler.ErrShow(601, e.ToString());
                result = false;
            }

            return result;
        }

            
        
        public void Close()
        {
            connection.Close();
        }

        protected bool ExecuteSimpleQuery(MySqlCommand command)
        {
            bool result = true;

            lock (connection)
            {
                if (Connect())
                {
                    command.Connection = connection;
                    try
                    {
                        command.ExecuteNonQuery();
                    }
                    catch (Exception e)
                    {
                       
                        result = false;
                        ErrHandler.ErrShow(600, e.ToString());
                    }
                    finally
                    {
                        Close();
                    }
                }

            }

            return result;
        }

        protected int ExecutScalarIntQuery(MySqlCommand command)
        {
            int result = -1;

            lock (connection)
            {
                if (Connect())
                {
                    command.Connection = connection;
                    try
                    {
                        result = (int)command.ExecuteScalar();
                    }
                    catch (Exception e)
                    {
                        result = -1;
                        //ErrHandler.ErrShow(602, e.ToString());
                    }
                    finally
                    {
                        Close();
                    }
                }

            }

            return result;
        }

        protected DataSet GetMultipleQuery(MySqlCommand command)
        {
            DataSet dataset = new DataSet();

            lock(connection)
            {
                if(Connect())
                {
                    command.Connection = connection;
                    try
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter();
                        adapter.SelectCommand = command;
                        adapter.Fill(dataset);
                    }
                    catch(Exception e)
                    {
                        dataset = null;
                        //ErrHandler.ErrShow(603, e.ToString());
                    }
                    finally
                    {
                        Close();
                    }
                }
            }

            return dataset;
        }


    }
}
