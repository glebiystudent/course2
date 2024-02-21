namespace CourseProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label_sign = new Label();
            checkbox_alreadywithus = new CheckBox();
            label_firstname = new Label();
            label_surname = new Label();
            label_age = new Label();
            label_height = new Label();
            label_weight = new Label();
            textbox_firstname = new TextBox();
            textbox_surname = new TextBox();
            textbox_height = new TextBox();
            textbox_weight = new TextBox();
            textbox_age = new TextBox();
            textbox_code = new TextBox();
            label_code = new Label();
            button_login = new Button();
            button_deleteaccount = new Button();
            label1 = new Label();
            label_dosing = new Label();
            combobox_products = new ComboBox();
            label2 = new Label();
            label_calories = new Label();
            label_carbohydrates = new Label();
            label_proteins = new Label();
            label_fats = new Label();
            label_sugar = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label_loginamount = new Label();
            label9 = new Label();
            label_dp = new Label();
            SuspendLayout();
            // 
            // label_sign
            // 
            label_sign.AutoSize = true;
            label_sign.Font = new Font("Segoe UI Light", 40F, FontStyle.Regular, GraphicsUnit.Point);
            label_sign.Location = new Point(70, 9);
            label_sign.Margin = new Padding(6, 0, 6, 0);
            label_sign.Name = "label_sign";
            label_sign.Size = new Size(258, 89);
            label_sign.TabIndex = 0;
            label_sign.Text = "Sign Up";
            // 
            // checkbox_alreadywithus
            // 
            checkbox_alreadywithus.AutoSize = true;
            checkbox_alreadywithus.Font = new Font("Segoe UI Light", 8F, FontStyle.Regular, GraphicsUnit.Point);
            checkbox_alreadywithus.Location = new Point(125, 104);
            checkbox_alreadywithus.Margin = new Padding(6);
            checkbox_alreadywithus.Name = "checkbox_alreadywithus";
            checkbox_alreadywithus.Size = new Size(123, 23);
            checkbox_alreadywithus.TabIndex = 1;
            checkbox_alreadywithus.Text = "already with us?";
            checkbox_alreadywithus.UseVisualStyleBackColor = true;
            checkbox_alreadywithus.CheckedChanged += checkbox_alreadywithus_CheckedChanged;
            // 
            // label_firstname
            // 
            label_firstname.AutoSize = true;
            label_firstname.Font = new Font("Segoe UI Light", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label_firstname.Location = new Point(90, 145);
            label_firstname.Margin = new Padding(6, 0, 6, 0);
            label_firstname.Name = "label_firstname";
            label_firstname.Size = new Size(215, 57);
            label_firstname.TabIndex = 2;
            label_firstname.Text = "First Name";
            // 
            // label_surname
            // 
            label_surname.AutoSize = true;
            label_surname.Font = new Font("Segoe UI Light", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label_surname.Location = new Point(111, 249);
            label_surname.Margin = new Padding(6, 0, 6, 0);
            label_surname.Name = "label_surname";
            label_surname.Size = new Size(181, 57);
            label_surname.TabIndex = 3;
            label_surname.Text = "Surname";
            // 
            // label_age
            // 
            label_age.AutoSize = true;
            label_age.Font = new Font("Segoe UI Light", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label_age.Location = new Point(392, 249);
            label_age.Margin = new Padding(6, 0, 6, 0);
            label_age.Name = "label_age";
            label_age.Size = new Size(96, 57);
            label_age.TabIndex = 4;
            label_age.Text = "Age";
            // 
            // label_height
            // 
            label_height.AutoSize = true;
            label_height.Font = new Font("Segoe UI Light", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label_height.Location = new Point(385, 35);
            label_height.Margin = new Padding(6, 0, 6, 0);
            label_height.Name = "label_height";
            label_height.Size = new Size(141, 57);
            label_height.TabIndex = 5;
            label_height.Text = "Height";
            // 
            // label_weight
            // 
            label_weight.AutoSize = true;
            label_weight.Font = new Font("Segoe UI Light", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label_weight.Location = new Point(385, 139);
            label_weight.Margin = new Padding(6, 0, 6, 0);
            label_weight.Name = "label_weight";
            label_weight.Size = new Size(149, 57);
            label_weight.TabIndex = 6;
            label_weight.Text = "Weight";
            // 
            // textbox_firstname
            // 
            textbox_firstname.Font = new Font("Segoe UI Light", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textbox_firstname.Location = new Point(111, 205);
            textbox_firstname.Name = "textbox_firstname";
            textbox_firstname.Size = new Size(164, 41);
            textbox_firstname.TabIndex = 7;
            // 
            // textbox_surname
            // 
            textbox_surname.Font = new Font("Segoe UI Light", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textbox_surname.Location = new Point(111, 309);
            textbox_surname.Name = "textbox_surname";
            textbox_surname.Size = new Size(164, 41);
            textbox_surname.TabIndex = 8;
            // 
            // textbox_height
            // 
            textbox_height.Font = new Font("Segoe UI Light", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textbox_height.Location = new Point(392, 95);
            textbox_height.Name = "textbox_height";
            textbox_height.Size = new Size(134, 41);
            textbox_height.TabIndex = 9;
            textbox_height.TextChanged += textbox_height_TextChanged;
            // 
            // textbox_weight
            // 
            textbox_weight.Font = new Font("Segoe UI Light", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textbox_weight.Location = new Point(392, 199);
            textbox_weight.Name = "textbox_weight";
            textbox_weight.Size = new Size(134, 41);
            textbox_weight.TabIndex = 10;
            textbox_weight.TextChanged += textbox_weight_TextChanged;
            // 
            // textbox_age
            // 
            textbox_age.Font = new Font("Segoe UI Light", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textbox_age.Location = new Point(392, 309);
            textbox_age.Name = "textbox_age";
            textbox_age.Size = new Size(134, 41);
            textbox_age.TabIndex = 11;
            textbox_age.TextChanged += textbox_age_TextChanged;
            // 
            // textbox_code
            // 
            textbox_code.Font = new Font("Segoe UI Light", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textbox_code.Location = new Point(111, 413);
            textbox_code.Name = "textbox_code";
            textbox_code.Size = new Size(164, 41);
            textbox_code.TabIndex = 13;
            textbox_code.Visible = false;
            // 
            // label_code
            // 
            label_code.AutoSize = true;
            label_code.Font = new Font("Segoe UI Light", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label_code.Location = new Point(137, 353);
            label_code.Margin = new Padding(6, 0, 6, 0);
            label_code.Name = "label_code";
            label_code.Size = new Size(120, 57);
            label_code.TabIndex = 12;
            label_code.Text = "Code";
            label_code.Visible = false;
            // 
            // button_login
            // 
            button_login.Anchor = AnchorStyles.Bottom;
            button_login.Location = new Point(387, 375);
            button_login.Name = "button_login";
            button_login.Size = new Size(283, 57);
            button_login.TabIndex = 14;
            button_login.Text = "Register";
            button_login.UseVisualStyleBackColor = true;
            button_login.Click += button_login_Click;
            // 
            // button_deleteaccount
            // 
            button_deleteaccount.Anchor = AnchorStyles.Bottom;
            button_deleteaccount.Location = new Point(387, 375);
            button_deleteaccount.Name = "button_deleteaccount";
            button_deleteaccount.Size = new Size(217, 57);
            button_deleteaccount.TabIndex = 16;
            button_deleteaccount.Text = "Delete Account";
            button_deleteaccount.UseVisualStyleBackColor = true;
            button_deleteaccount.Visible = false;
            button_deleteaccount.Click += button_deleteaccount_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Light", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(557, 35);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(157, 57);
            label1.TabIndex = 17;
            label1.Text = "Dosing:";
            // 
            // label_dosing
            // 
            label_dosing.AutoSize = true;
            label_dosing.Font = new Font("Segoe UI Light", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label_dosing.Location = new Point(575, 95);
            label_dosing.Margin = new Padding(6, 0, 6, 0);
            label_dosing.Name = "label_dosing";
            label_dosing.Size = new Size(0, 35);
            label_dosing.TabIndex = 18;
            // 
            // combobox_products
            // 
            combobox_products.Font = new Font("Segoe UI Light", 15F, FontStyle.Regular, GraphicsUnit.Point);
            combobox_products.FormattingEnabled = true;
            combobox_products.Location = new Point(780, 93);
            combobox_products.Name = "combobox_products";
            combobox_products.Size = new Size(151, 43);
            combobox_products.TabIndex = 19;
            combobox_products.SelectedIndexChanged += combobox_products_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Light", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(770, 33);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(187, 57);
            label2.TabIndex = 20;
            label2.Text = "Products:";
            // 
            // label_calories
            // 
            label_calories.AutoSize = true;
            label_calories.Font = new Font("Segoe UI Light", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label_calories.Location = new Point(925, 163);
            label_calories.Name = "label_calories";
            label_calories.Size = new Size(0, 35);
            label_calories.TabIndex = 21;
            // 
            // label_carbohydrates
            // 
            label_carbohydrates.AutoSize = true;
            label_carbohydrates.Font = new Font("Segoe UI Light", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label_carbohydrates.Location = new Point(925, 208);
            label_carbohydrates.Name = "label_carbohydrates";
            label_carbohydrates.Size = new Size(0, 35);
            label_carbohydrates.TabIndex = 22;
            // 
            // label_proteins
            // 
            label_proteins.AutoSize = true;
            label_proteins.Font = new Font("Segoe UI Light", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label_proteins.Location = new Point(925, 249);
            label_proteins.Name = "label_proteins";
            label_proteins.Size = new Size(0, 35);
            label_proteins.TabIndex = 23;
            // 
            // label_fats
            // 
            label_fats.AutoSize = true;
            label_fats.Font = new Font("Segoe UI Light", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label_fats.Location = new Point(925, 291);
            label_fats.Name = "label_fats";
            label_fats.Size = new Size(0, 35);
            label_fats.TabIndex = 24;
            // 
            // label_sugar
            // 
            label_sugar.AutoSize = true;
            label_sugar.Font = new Font("Segoe UI Light", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label_sugar.Location = new Point(925, 341);
            label_sugar.Name = "label_sugar";
            label_sugar.Size = new Size(0, 35);
            label_sugar.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Light", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(746, 341);
            label3.Name = "label3";
            label3.Size = new Size(82, 35);
            label3.TabIndex = 30;
            label3.Text = "Sugar:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Light", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(746, 291);
            label4.Name = "label4";
            label4.Size = new Size(61, 35);
            label4.TabIndex = 29;
            label4.Text = "Fats:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Light", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(746, 249);
            label5.Name = "label5";
            label5.Size = new Size(104, 35);
            label5.TabIndex = 28;
            label5.Text = "Proteins:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Light", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(746, 208);
            label6.Name = "label6";
            label6.Size = new Size(173, 35);
            label6.TabIndex = 27;
            label6.Text = "Carbohydrates:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Light", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(746, 163);
            label7.Name = "label7";
            label7.Size = new Size(104, 35);
            label7.TabIndex = 26;
            label7.Text = "Calories:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Light", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(746, 391);
            label8.Name = "label8";
            label8.Size = new Size(120, 46);
            label8.TabIndex = 31;
            label8.Text = "Logins:";
            // 
            // label_loginamount
            // 
            label_loginamount.AutoSize = true;
            label_loginamount.Location = new Point(865, 396);
            label_loginamount.Name = "label_loginamount";
            label_loginamount.Size = new Size(0, 41);
            label_loginamount.TabIndex = 32;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(906, 341);
            label9.Name = "label9";
            label9.Size = new Size(61, 41);
            label9.TabIndex = 33;
            label9.Text = "DP:";
            // 
            // label_dp
            // 
            label_dp.AutoSize = true;
            label_dp.Location = new Point(963, 341);
            label_dp.Name = "label_dp";
            label_dp.Size = new Size(0, 41);
            label_dp.TabIndex = 34;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(16F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1046, 453);
            Controls.Add(label_dp);
            Controls.Add(label9);
            Controls.Add(label_loginamount);
            Controls.Add(label8);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label_sugar);
            Controls.Add(label_fats);
            Controls.Add(label_proteins);
            Controls.Add(label_carbohydrates);
            Controls.Add(label_calories);
            Controls.Add(label2);
            Controls.Add(combobox_products);
            Controls.Add(label_dosing);
            Controls.Add(label1);
            Controls.Add(button_deleteaccount);
            Controls.Add(button_login);
            Controls.Add(textbox_code);
            Controls.Add(label_code);
            Controls.Add(textbox_age);
            Controls.Add(textbox_weight);
            Controls.Add(textbox_height);
            Controls.Add(textbox_surname);
            Controls.Add(textbox_firstname);
            Controls.Add(label_weight);
            Controls.Add(label_height);
            Controls.Add(label_age);
            Controls.Add(label_surname);
            Controls.Add(label_firstname);
            Controls.Add(checkbox_alreadywithus);
            Controls.Add(label_sign);
            Font = new Font("Segoe UI Light", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(6);
            Name = "Form1";
            Text = "Diabetes Help";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_sign;
        private CheckBox checkbox_alreadywithus;
        private Label label_firstname;
        private Label label_surname;
        private Label label_age;
        private Label label_height;
        private Label label_weight;
        private TextBox textbox_firstname;
        private TextBox textbox_surname;
        private TextBox textbox_height;
        private TextBox textbox_weight;
        private TextBox textbox_age;
        private TextBox textbox_code;
        private Label label_code;
        private Button button_login;
        private Button button_deleteaccount;
        private Label label1;
        private Label label_dosing;
        private ComboBox combobox_products;
        private Label label2;
        private Label label_calories;
        private Label label_carbohydrates;
        private Label label_proteins;
        private Label label_fats;
        private Label label_sugar;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label_loginamount;
        private Label label9;
        private Label label_dp;
    }
}