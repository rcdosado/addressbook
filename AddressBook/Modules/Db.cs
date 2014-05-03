using System;
using System.Collections.Generic;
using AddressBook.Properties;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace AddressBook.Modules
{
    class Db
    {
        //
        private MySqlConnection _connect;

        //
        private MySqlCommand _command;

        //
        private MySqlDataReader _reader;

        //
        private string _connectiondetails = Settings.Default["connectionstring"].ToString();

        //
        private bool _bConnected = false;

        //
        private DataTable _table;

        //
        private int _affectedRows;

        //
        private string _squery;

        //;
        private readonly List<string> _parameters;

        public String ConString
        {
            get { return _connectiondetails; }
            set { _connectiondetails = value; }
        }

        public string LastError { get; private set; }

        public Db()
        {
            
            _table = _table = new DataTable();
            _parameters = new List<string>();
        }
        public bool Create(string dbname,bool dropIfExists)
        {
            if(dropIfExists)
               Init("Create Database if not exists "+dbname);
            return _affectedRows > 0 ? true : false;
        }
        public bool Drop(string dbname)
        {
                Init("drop Database if exists " + dbname);
            return _affectedRows > 0 ? true : false;
        }

        public void Connect()
        {
            
            try
            {
                var connection = new MySqlConnection(ConString);
                connection.Open();
                _connect = connection;
                _bConnected = true;
            }
            catch (MySqlException ex)
            {
                LastError = ex.Message;
                //string exception = "Exception : " + ex.Message.ToString() + "\n\rApplication will close now. \n\r" + squery;
                //  MessageBox.Show(exception, "Uncaught MYSQL Exception");
                // Debug(exception);

                //Environment.Exit(1);
            }
        }

        public void CloseConn()
        {
            _bConnected = false;
            _connect.Close();
            _connect.Dispose();
        }

        private void Init(string query, string[] bindings = null)
        {
            if (query == null) throw new ArgumentNullException("query");
            // No connection with database? make connection
            if (_bConnected == false)
            {
                Connect();
            }

            // Automatically disposes the MySQLcommand instance
            using (_command = new MySqlCommand(query, _connect))
            {
                // 
                bind(bindings);

                // Prevents SQL injection
                if (_parameters.Count > 0)
                {
                    _parameters.ForEach(delegate(string parameter)
                    {
                        string[] sparameters = parameter.Split('\x7F');
                        _command.Parameters.AddWithValue(sparameters[0], sparameters[1]);
                    });
                }

                _squery = query.ToLower();

                if (_squery.Contains("select"))
                {
                    _table = execDatatable();
                }
                if (_squery.Contains("delete") || 
                    _squery.Contains("update") || 
                    _squery.Contains("insert") ||
                    _squery.Contains("create") ||
                    _squery.Contains("drop"))
                {
                    _affectedRows = execNonquery();
                }

                // Clear de parameters, 
                _parameters.Clear();
            }
        }

        public void bind(string field, string value)
        {
            _parameters.Add("@" + field + "\x7F" + value);
        }

        public void bind(string[] fields)
        {
            if (fields != null)
            {
                for (int i = 0; i < fields.Length; i++)
                {
                    bind(fields[i], fields[i + 1]);
                    i += 1;
                }
            }
        }

        private DataTable execDatatable()
        {
            DataTable dt = new DataTable();
            try
            {
                _reader = _command.ExecuteReader();
                dt.Load(_reader);
            }
            catch (MySqlException my)
            {
                string exception = "Exception : " + my.Message.ToString() + "\n\r SQL Query : \n\r" + _squery;

                MessageBox.Show(exception, "Uncaught MYSQL Exception");

                Debug(exception);
            }

            return dt;
        }

        private int execNonquery()
        {

            int affected = 0;

            try
            {
                affected = _command.ExecuteNonQuery();
            }
            catch (MySqlException my)
            {
                string exception = "Exception : " + my.Message.ToString() + "\n\r SQL Query : \n\r" + _squery;

                MessageBox.Show(exception, "Uncaught MYSQL Exception");

                Debug(exception);
            }

            return affected;
        }

        public DataTable table(string table, string[] bindings = null)
        {
            Init("SELECT * FROM " + table, bindings);
            return _table;
        }

        public List<object> table(string table, Type t)
        {
            return new List<object>();
        }

        public DataTable query(string query, string[] bindings = null)
        {
            Init(query, bindings);
            return _table;
        }

        public int nQuery(string query, string[] bindings = null)
        {
            Init(query, bindings);
            return _affectedRows;
        }

        public string single(string query, string[] bindings = null)
        {
            Init(query, bindings);

            if (_table.Rows.Count > 0)
            {
                return _table.Rows[0][0].ToString();
            }

            return string.Empty;
        }

        public string[] row(string query, string[] bindings = null)
        {
            Init(query, bindings);

            string[] row = new string[_table.Columns.Count];

            if (_table.Rows.Count > 0)
                for (int i = 0; i++ < _table.Columns.Count; row[i - 1] = _table.Rows[0][i - 1].ToString()) ;

            return row;
        }

        public List<string> column(string query, string[] bindings = null)
        {
            Init(query, bindings);

            List<string> column = new List<string>();

            for (int i = 0; i++ < _table.Rows.Count; column.Add(_table.Rows[i - 1][0].ToString())) ;

            return column;
        }

        public void Debug(string error)
        {
            Console.WriteLine(error + "/n/r");
        }
        public bool IsConnected()
        {
            return _bConnected;
        }
    }

}
