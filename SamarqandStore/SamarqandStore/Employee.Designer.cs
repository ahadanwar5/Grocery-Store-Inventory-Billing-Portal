
namespace SamarqandStore
{
    partial class Employee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button_customer = new System.Windows.Forms.Button();
            this.dataGridView_employee = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.button_update = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.TextBox_address = new Guna.UI2.WinForms.Guna2TextBox();
            this.button_selling = new System.Windows.Forms.Button();
            this.button_category = new System.Windows.Forms.Button();
            this.button_product = new System.Windows.Forms.Button();
            this.label_exit = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBox_phone = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBox_name = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBox_id = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_logout = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.TextBox_username = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TextBox_password = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_employee)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_customer
            // 
            this.button_customer.Location = new System.Drawing.Point(25, 311);
            this.button_customer.Name = "button_customer";
            this.button_customer.Size = new System.Drawing.Size(88, 38);
            this.button_customer.TabIndex = 27;
            this.button_customer.Text = "Customers";
            this.button_customer.UseVisualStyleBackColor = true;
            this.button_customer.Click += new System.EventHandler(this.button_customer_Click);
            // 
            // dataGridView_employee
            // 
            dataGridViewCellStyle28.BackColor = System.Drawing.Color.White;
            this.dataGridView_employee.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle28;
            this.dataGridView_employee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_employee.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_employee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_employee.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView_employee.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_employee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle29;
            this.dataGridView_employee.ColumnHeadersHeight = 24;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle30.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_employee.DefaultCellStyle = dataGridViewCellStyle30;
            this.dataGridView_employee.EnableHeadersVisualStyles = false;
            this.dataGridView_employee.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_employee.Location = new System.Drawing.Point(339, 100);
            this.dataGridView_employee.Name = "dataGridView_employee";
            this.dataGridView_employee.RowHeadersVisible = false;
            this.dataGridView_employee.RowHeadersWidth = 24;
            this.dataGridView_employee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_employee.Size = new System.Drawing.Size(564, 488);
            this.dataGridView_employee.TabIndex = 16;
            this.dataGridView_employee.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_employee.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridView_employee.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridView_employee.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridView_employee.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridView_employee.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_employee.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_employee.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridView_employee.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView_employee.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView_employee.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView_employee.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridView_employee.ThemeStyle.HeaderStyle.Height = 24;
            this.dataGridView_employee.ThemeStyle.ReadOnly = false;
            this.dataGridView_employee.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_employee.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView_employee.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView_employee.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView_employee.ThemeStyle.RowsStyle.Height = 22;
            this.dataGridView_employee.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_employee.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView_employee.Click += new System.EventHandler(this.dataGridView_employee_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(380, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(211, 30);
            this.label6.TabIndex = 14;
            this.label6.Text = "MANAGE EMPLOYEES";
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(188, 424);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(88, 38);
            this.button_update.TabIndex = 11;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(83, 424);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(88, 38);
            this.button_add.TabIndex = 10;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // TextBox_address
            // 
            this.TextBox_address.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_address.DefaultText = "";
            this.TextBox_address.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_address.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_address.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_address.DisabledState.Parent = this.TextBox_address;
            this.TextBox_address.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_address.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_address.FocusedState.Parent = this.TextBox_address;
            this.TextBox_address.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_address.ForeColor = System.Drawing.Color.Black;
            this.TextBox_address.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_address.HoverState.Parent = this.TextBox_address;
            this.TextBox_address.Location = new System.Drawing.Point(132, 206);
            this.TextBox_address.Name = "TextBox_address";
            this.TextBox_address.PasswordChar = '\0';
            this.TextBox_address.PlaceholderText = "";
            this.TextBox_address.SelectedText = "";
            this.TextBox_address.ShadowDecoration.Parent = this.TextBox_address;
            this.TextBox_address.Size = new System.Drawing.Size(200, 101);
            this.TextBox_address.TabIndex = 7;
            // 
            // button_selling
            // 
            this.button_selling.Location = new System.Drawing.Point(25, 245);
            this.button_selling.Name = "button_selling";
            this.button_selling.Size = new System.Drawing.Size(88, 38);
            this.button_selling.TabIndex = 25;
            this.button_selling.Text = "Selling";
            this.button_selling.UseVisualStyleBackColor = true;
            this.button_selling.Click += new System.EventHandler(this.button_selling_Click);
            // 
            // button_category
            // 
            this.button_category.Location = new System.Drawing.Point(25, 178);
            this.button_category.Name = "button_category";
            this.button_category.Size = new System.Drawing.Size(88, 38);
            this.button_category.TabIndex = 24;
            this.button_category.Text = "Category";
            this.button_category.UseVisualStyleBackColor = true;
            this.button_category.Click += new System.EventHandler(this.button_category_Click);
            // 
            // button_product
            // 
            this.button_product.Location = new System.Drawing.Point(25, 108);
            this.button_product.Name = "button_product";
            this.button_product.Size = new System.Drawing.Size(88, 38);
            this.button_product.TabIndex = 23;
            this.button_product.Text = "Product";
            this.button_product.UseVisualStyleBackColor = true;
            this.button_product.Click += new System.EventHandler(this.button_product_Click);
            // 
            // label_exit
            // 
            this.label_exit.AutoSize = true;
            this.label_exit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_exit.ForeColor = System.Drawing.Color.Gold;
            this.label_exit.Location = new System.Drawing.Point(1035, 8);
            this.label_exit.Name = "label_exit";
            this.label_exit.Size = new System.Drawing.Size(24, 25);
            this.label_exit.TabIndex = 22;
            this.label_exit.Text = "X";
            this.label_exit.Click += new System.EventHandler(this.label_exit_Click);
            this.label_exit.MouseEnter += new System.EventHandler(this.label_exit_MouseEnter);
            this.label_exit.MouseLeave += new System.EventHandler(this.label_exit_MouseLeave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(31, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 30);
            this.label4.TabIndex = 6;
            this.label4.Text = "Phone";
            // 
            // TextBox_phone
            // 
            this.TextBox_phone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_phone.DefaultText = "";
            this.TextBox_phone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_phone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_phone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_phone.DisabledState.Parent = this.TextBox_phone;
            this.TextBox_phone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_phone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_phone.FocusedState.Parent = this.TextBox_phone;
            this.TextBox_phone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_phone.ForeColor = System.Drawing.Color.Black;
            this.TextBox_phone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_phone.HoverState.Parent = this.TextBox_phone;
            this.TextBox_phone.Location = new System.Drawing.Point(132, 171);
            this.TextBox_phone.Name = "TextBox_phone";
            this.TextBox_phone.PasswordChar = '\0';
            this.TextBox_phone.PlaceholderText = "";
            this.TextBox_phone.SelectedText = "";
            this.TextBox_phone.ShadowDecoration.Parent = this.TextBox_phone;
            this.TextBox_phone.Size = new System.Drawing.Size(200, 29);
            this.TextBox_phone.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(31, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "Address";
            // 
            // TextBox_name
            // 
            this.TextBox_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_name.DefaultText = "";
            this.TextBox_name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_name.DisabledState.Parent = this.TextBox_name;
            this.TextBox_name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_name.FocusedState.Parent = this.TextBox_name;
            this.TextBox_name.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_name.ForeColor = System.Drawing.Color.Black;
            this.TextBox_name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_name.HoverState.Parent = this.TextBox_name;
            this.TextBox_name.Location = new System.Drawing.Point(132, 136);
            this.TextBox_name.Name = "TextBox_name";
            this.TextBox_name.PasswordChar = '\0';
            this.TextBox_name.PlaceholderText = "";
            this.TextBox_name.SelectedText = "";
            this.TextBox_name.ShadowDecoration.Parent = this.TextBox_name;
            this.TextBox_name.Size = new System.Drawing.Size(200, 29);
            this.TextBox_name.TabIndex = 3;
            // 
            // TextBox_id
            // 
            this.TextBox_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_id.DefaultText = "";
            this.TextBox_id.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_id.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_id.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_id.DisabledState.Parent = this.TextBox_id;
            this.TextBox_id.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_id.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_id.FocusedState.Parent = this.TextBox_id;
            this.TextBox_id.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_id.ForeColor = System.Drawing.Color.Black;
            this.TextBox_id.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_id.HoverState.Parent = this.TextBox_id;
            this.TextBox_id.Location = new System.Drawing.Point(132, 100);
            this.TextBox_id.Name = "TextBox_id";
            this.TextBox_id.PasswordChar = '\0';
            this.TextBox_id.PlaceholderText = "";
            this.TextBox_id.SelectedText = "";
            this.TextBox_id.ShadowDecoration.Parent = this.TextBox_id;
            this.TextBox_id.Size = new System.Drawing.Size(200, 29);
            this.TextBox_id.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(31, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // button_logout
            // 
            this.button_logout.Location = new System.Drawing.Point(25, 605);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(88, 38);
            this.button_logout.TabIndex = 26;
            this.button_logout.Text = "Logout";
            this.button_logout.UseVisualStyleBackColor = true;
            this.button_logout.Click += new System.EventHandler(this.button_logout_Click);
            this.button_logout.MouseEnter += new System.EventHandler(this.button_logout_MouseEnter);
            this.button_logout.MouseLeave += new System.EventHandler(this.button_logout_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(31, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Goldenrod;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.TextBox_password);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.TextBox_username);
            this.panel1.Controls.Add(this.dataGridView_employee);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.button_update);
            this.panel1.Controls.Add(this.button_add);
            this.panel1.Controls.Add(this.TextBox_address);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.TextBox_phone);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TextBox_name);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TextBox_id);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(156, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(920, 601);
            this.panel1.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(21, 312);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 30);
            this.label7.TabIndex = 18;
            this.label7.Text = "Username";
            // 
            // TextBox_username
            // 
            this.TextBox_username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_username.DefaultText = "";
            this.TextBox_username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_username.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_username.DisabledState.Parent = this.TextBox_username;
            this.TextBox_username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_username.FocusedState.Parent = this.TextBox_username;
            this.TextBox_username.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_username.ForeColor = System.Drawing.Color.Black;
            this.TextBox_username.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_username.HoverState.Parent = this.TextBox_username;
            this.TextBox_username.Location = new System.Drawing.Point(132, 313);
            this.TextBox_username.Name = "TextBox_username";
            this.TextBox_username.PasswordChar = '\0';
            this.TextBox_username.PlaceholderText = "";
            this.TextBox_username.SelectedText = "";
            this.TextBox_username.ShadowDecoration.Parent = this.TextBox_username;
            this.TextBox_username.Size = new System.Drawing.Size(200, 29);
            this.TextBox_username.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Sitka Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(24, 347);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 30);
            this.label8.TabIndex = 20;
            this.label8.Text = "Password";
            // 
            // TextBox_password
            // 
            this.TextBox_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_password.DefaultText = "";
            this.TextBox_password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_password.DisabledState.Parent = this.TextBox_password;
            this.TextBox_password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_password.FocusedState.Parent = this.TextBox_password;
            this.TextBox_password.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_password.ForeColor = System.Drawing.Color.Black;
            this.TextBox_password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_password.HoverState.Parent = this.TextBox_password;
            this.TextBox_password.Location = new System.Drawing.Point(132, 348);
            this.TextBox_password.Name = "TextBox_password";
            this.TextBox_password.PasswordChar = '\0';
            this.TextBox_password.PlaceholderText = "";
            this.TextBox_password.SelectedText = "";
            this.TextBox_password.ShadowDecoration.Parent = this.TextBox_password;
            this.TextBox_password.Size = new System.Drawing.Size(200, 29);
            this.TextBox_password.TabIndex = 19;
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 650);
            this.Controls.Add(this.button_customer);
            this.Controls.Add(this.button_selling);
            this.Controls.Add(this.button_category);
            this.Controls.Add(this.button_product);
            this.Controls.Add(this.label_exit);
            this.Controls.Add(this.button_logout);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.Employee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_employee)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_customer;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridView_employee;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_add;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_address;
        private System.Windows.Forms.Button button_selling;
        private System.Windows.Forms.Button button_category;
        private System.Windows.Forms.Button button_product;
        private System.Windows.Forms.Label label_exit;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_phone;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_name;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_logout;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_password;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_username;
    }
}