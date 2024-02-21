using System.Data;

namespace CourseProject
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private LoginSystem account = new LoginSystem();
        private bool logged_in = false;

        private void checkbox_alreadywithus_CheckedChanged(object sender, EventArgs e)
        {
            if (logged_in)
                return;

            if (checkbox_alreadywithus.Checked)
            {
                label_sign.Text = "Sign In";
                textbox_code.Visible = true;
                label_code.Visible = true;
                this.Size = new Size(400, 600);
                button_login.Text = "Authenticate";
            }
            else
            {
                label_sign.Text = "Sign Up";
                textbox_code.Visible = false;
                label_code.Visible = false;
                this.Size = new Size(400, 500);
                button_login.Text = "Register";
            }
        }



        private void button_login_Click(object sender, EventArgs e)
        {
            bool state = false;
            if (button_login.Text == "Authenticate")
            {
                state = account.Login(textbox_firstname.Text, textbox_surname.Text, textbox_code.Text);
            }
            else
            {
                state = account.Register(textbox_firstname.Text, textbox_surname.Text);
            }

            if (state)
            {
                this.Size = new Size(1100, 525);
                button_login.Visible = false;
                button_deleteaccount.Visible = true;
                logged_in = true;

                this.load_bodydata();
                int amount = account.UpdateLoginAmount();
                this.label_loginamount.Text = amount.ToString();
            }
        }

        private void update_sugarmetrics()
        {
            label_dosing.Text = (int.Parse(textbox_weight.Text) * 0.2).ToString() + " units";
        }


        private void load_bodydata()
        {
            DataTable table = account.LoadBodydata();
            if (table.Rows.Count == 0)
                account.InitBodydata();

            string[] data = Database.tabletostr(table).Split(" ");

            if (data.Length < 4)
                return;

            textbox_height.Text = data[1];
            textbox_weight.Text = data[2];
            textbox_age.Text = data[3];
            this.update_sugarmetrics();
        }

        private void button_deleteaccount_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                account.Delete();

                this.Size = new Size(400, 600);
                button_login.Visible = true;
                button_deleteaccount.Visible = false;
                logged_in = false;
            }
        }

        private void textbox_height_TextChanged(object sender, EventArgs e)
        {
            account.SaveHeight(textbox_height.Text);
        }

        private void textbox_weight_TextChanged(object sender, EventArgs e)
        {
            if (account.SaveWeight(textbox_weight.Text))
            {
                this.update_sugarmetrics();
            }

        }

        private void textbox_age_TextChanged(object sender, EventArgs e)
        {
            account.SaveAge(textbox_age.Text);

        }


        private double calculate_limit(int sugar)
        {
            double limit = 0;
            double weight = account.ParseNumber(textbox_weight.Text);

            limit = sugar / (weight);
            return limit;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] data = account.GetProducts();
            for (int i = 0; i < data.Length; ++i)
            {
                this.combobox_products.Items.Add(data[i]);
            }
        }

        private void combobox_products_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idx = combobox_products.SelectedIndex + 1;
            
            string[] data = account.GetProductData(idx);
            if (data.Length >= 5)
            {
                label_calories.Text = data[1] + "g.";
                label_carbohydrates.Text = data[2] + "g.";
                label_proteins.Text = data[3] + "g.";
                label_fats.Text = data[4] + "g.";
                label_sugar.Text = data[5] + "g.";
                label_dp.Text = Math.Round((calculate_limit(int.Parse(data[5])) * 100)).ToString() + "%";
            }
        }
    }
}