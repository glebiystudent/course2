using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CourseProject
{
    internal class Database
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;user=root;password=root;database=diabeteshelp");
        public Database() { 
        
        }

        public void openConnection()
        {
            if(connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }

        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }

        public MySqlConnection getConnection()
        {
            return this.connection;
        }

        private MySqlCommand format(string query, string args_)
        {
            MySqlCommand command = new MySqlCommand(query, this.connection);

            if (args_ != "")
            {
                Dictionary<string, string> args = JsonSerializer.Deserialize<Dictionary<string, string>>(args_);

                foreach (var arg in args)
                {
                    command.Parameters.Add(arg.Key, MySqlDbType.VarChar).Value = arg.Value;
                }
            }

            return command;
        }

        public DataTable query_get(string query, string args_)
        {
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = this.format(query, args_);

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }

        public int query_send(string query, string args_)
        {
            int code;

            this.openConnection();
            MySqlCommand command = this.format(query, args_);
            code = command.ExecuteNonQuery();
            this.closeConnection();

            return code;
        }

        public static string tabletostr(DataTable table)
        {
            string data = "";
            foreach (DataRow dataRow in table.Rows)
            {
                foreach (var item in dataRow.ItemArray)
                {
                    data += (item + " ");
                }
                data += "\n";
            }
            return data;
        }
    }
}
