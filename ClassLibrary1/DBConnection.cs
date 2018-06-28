using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace UgcClassLibrary
{
    public class DBConnetion
    {
        private DBConnetion()
        {
        }
        private string databaseName = string.Empty;

        public string DatabaseName
        {
            get { return databaseName; }
            set { databaseName = value; }
        }

        public string Password { get; set; }
        private MySqlConnection connection = null;

        public MySqlConnection Connection
        {
            get { return connection; }
        }

        private static DBConnetion _instance = null;

        public static DBConnetion Instance()
        {
            if (_instance == null)
                _instance = new DBConnetion();
            return _instance;
        }

        public bool IsConnect()
        {
            if (Connection == null)
            {
                if (String.IsNullOrEmpty(databaseName)) return false;
                //server ={ 0}; user id = { 1 }; password ={ 2}; persistsecurityinfo = True; port ={ 3}; database ={ 4}; SslMode = none
                string connstr = string.Format("server=localhost; database={0}; Uid=root;SslMode = none; password=kdaa4fp", databaseName);
                connection = new MySqlConnection(connstr);
                connection.Open();
            }
            return true;
        }
        public void Close()
        {
            connection.Close();
        }
    }
}
