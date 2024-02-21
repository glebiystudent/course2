using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject
{
    internal class LoginSystem
    { 
        public LoginSystem() { }

        public string firstname = "";
        public string surname = "";
        public string code = "";


        public bool IsValidCode()
        {
            return !string.IsNullOrEmpty(this.code) && this.code.Length >= 4;
        }

        public bool IsValidBasicData()
        {
            return !string.IsNullOrEmpty(this.firstname)
                && !string.IsNullOrEmpty(this.surname);
        }

        public bool Register(string firstname, string surname)
        {
            this.firstname = firstname;
            this.surname = surname;

            if (!this.IsValidBasicData())
            {
                MessageBox.Show("Invalid register data!", "No data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            bool state = DatabaseRegister();
            if (!state)
                MessageBox.Show("Couldn't register the account!", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return state;
        }


        public bool Login(string firstname, string surname, string code)
        {
            this.firstname = firstname;
            this.surname = surname;
            this.code = code;

            if (!this.IsValidBasicData())
            {
                MessageBox.Show("Invalid login data!", "No data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (!this.IsValidCode())
            {
                MessageBox.Show("Enter a valid code!", "Wrong code", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            bool state = DatabaseLogin();
            if (!state)
                MessageBox.Show("Couldn't login!", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return state;
        }

        Database db = new Database();

        public int UpdateLoginAmount()
        {
            string id_arg = "{\"@id\":\"" + this.code + "\"}";
            DataTable table = db.query_get("SELECT * FROM loginamount WHERE `id` = @id", id_arg);

            if(table.Rows.Count == 0)
            {
                db.query_send("INSERT INTO `loginamount` (`id`, `amount`) VALUES (@id, 1)", id_arg);
                return 1;
            }
            else
            {
                int amount = (int)table.Rows[0][1];
                string arguments = "{\"@id\":\"" + this.code + "\", \"@amount\":\"" + (amount + 1) + "\"}";
                db.query_send("UPDATE loginamount SET `amount` = @amount WHERE `id` = @id", arguments);
                return amount + 1;
            }
        }

        public bool DatabaseRegister()
        {
            string arguments = "{\"@firstname\":\"" + this.firstname + "\", \"@surname\":\"" + this.surname + "\"}";
            int statecode = db.query_send("INSERT INTO `users` (`firstname`, `surname`) VALUES (@firstname, @surname)", arguments);

            string[] data = Database.tabletostr(db.query_get("SELECT * FROM `users` ORDER BY `users`.`code` DESC LIMIT 1", "")).Split(" ");
            this.code = data[0];
            MessageBox.Show("Your code is " + data[0], "Remember it!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            return statecode == 1;
        }

        public string[] GetProducts()
        {
            string[] data = Database.tabletostr(db.query_get("SELECT name FROM products ", "")).Split(" ");
            return data;
        }

        public string[] GetProductData(int idx)
        {
            string arguments = "{\"@id\":\"" + idx + "\"}";
            string[] data = Database.tabletostr(db.query_get("SELECT * FROM productdata WHERE `id` = @id", arguments)).Split(" ");
            return data;
        }

        public bool DatabaseLogin()
        {
            string arguments = "{\"@firstname\":\"" + this.firstname + "\", \"@surname\":\"" + this.surname + "\", \"@code\":\"" + this.code + "\"}";
            string data = Database.tabletostr(db.query_get("SELECT * FROM `users` WHERE `firstname` = @firstname AND `surname` = @surname AND `code` = @code", arguments));

            return data != "";
        }

        public void Delete()
        {
            DatabaseDelete();

            this.firstname = "";
            this.surname = "";
            this.code = "";

        }
        public void DatabaseDelete()
        {
            string arguments = "{\"@firstname\":\"" + this.firstname + "\", \"@surname\":\"" + this.surname + "\", \"@code\":\"" + this.code + "\"}";
            db.query_send("DELETE FROM users WHERE `firstname` = @firstname AND `surname` = @surname AND `code` = @code", arguments);

            string arguments_ = "{\"@code\":\"" + this.code + "\"}";
            db.query_send("DELETE FROM bodydata WHERE `userid` = @code", arguments);
            db.query_send("DELETE FROM loginamount WHERE `id` = @code", arguments);
        }
    
        public DataTable LoadBodydata()
        {
            DataTable table;

            string arguments = "{\"@code\":\"" + this.code + "\"}";
            table = db.query_get("SELECT * FROM `bodydata` WHERE `userid` = @code", arguments);

            return table;
        }

        public void InitBodydata()
        {
            string arguments = "{\"@userid\":\"" + this.code + "\"}";
            db.query_send("INSERT INTO `bodydata` (`userid`, `height`, `weight`, `age`) VALUES (@userid, '0', '0', '0');", arguments);
        }

        public bool IsNumber(string str)
        {
            int __;
            return int.TryParse(str, out __);
        }

        public int ParseNumber(string str)
        {
            int __;
            int.TryParse(str, out __);
            return __;
        }

        public bool SaveHeight(string height)
        {
            if (!IsNumber(height))
                return false;

            string arguments = "{\"@code\":\"" + this.code + "\", \"@height\":\"" + height + "\"}";
            db.query_send("UPDATE bodydata SET `height` = @height WHERE `userid` = @code", arguments);
            return true;
        }

        public bool SaveWeight(string weight)
        {
            if (!IsNumber(weight))
                return false;

            string arguments = "{\"@code\":\"" + this.code + "\", \"@weight\":\"" + weight + "\"}";
            db.query_send("UPDATE bodydata SET `weight` = @weight WHERE `userid` = @code", arguments);
            return true;
        }

        public bool SaveAge(string age)
        {
            if (!IsNumber(age))
                return false;

            string arguments = "{\"@code\":\"" + this.code + "\", \"@age\":\"" + age + "\"}";
            db.query_send("UPDATE bodydata SET `age` = @age WHERE `userid` = @code", arguments);
            return true;
        }
    }
}
