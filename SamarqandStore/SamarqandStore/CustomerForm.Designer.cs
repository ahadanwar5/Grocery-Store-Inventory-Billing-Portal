
namespace SamarqandStore
{
    partial class CustomerForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button_product = new System.Windows.Forms.Button();
            this.dataGridView_customer = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.button_selling = new System.Windows.Forms.Button();
            this.button_category = new System.Windows.Forms.Button();
            this.button_employee = new System.Windows.Forms.Button();
            this.label_exit = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBox_phone = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBox_name = new Guna.UI2.WinForms.Guna2TextBox();
            this.button_logout = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TextBox_id = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_customer)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_product
            // 
            this.button_product.Location = new System.Drawing.Point(25, 311);
            this.button_product.Name = "button_product";
            this.button_product.Size = new System.Drawing.Size(88, 38);
            this.button_product.TabIndex = 27;
            this.button_product.Text = "Product";
            this.button_product.UseVisualStyleBackColor = true;
            this.button_product.Click += new System.EventHandler(this.button_product_Click);
            // 
            // dataGridView_customer
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dataGridView_customer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView_customer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_customer.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_customer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_customer.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView_customer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_customer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView_customer.ColumnHeadersHeight = 24;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_customer.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView_customer.EnableHeadersVisualStyles = false;
            this.dataGridView_customer.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_customer.Location = new System.Drawing.Point(339, 100);
            this.dataGridView_customer.Name = "dataGridView_customer";
            this.dataGridView_customer.RowHeadersVisible = false;
            this.dataGridView_customer.RowHeadersWidth = 24;
            this.dataGridView_customer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_customer.Size = new System.Drawing.Size(564, 488);
            this.dataGridView_customer.TabIndex = 16;
            this.dataGridView_customer.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_customer.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridView_customer.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridView_customer.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridView_customer.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridView_customer.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_customer.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_customer.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridView_customer.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView_customer.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView_customer.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView_customer.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridView_customer.ThemeStyle.HeaderStyle.Height = 24;
            this.dataGridView_customer.ThemeStyle.ReadOnly = false;
            this.dataGridView_customer.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_customer.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView_customer.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView_customer.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView_customer.ThemeStyle.RowsStyle.Height = 22;
            this.dataGridView_customer.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_customer.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView_customer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_customer_CellContentClick);
            this.dataGridView_customer.Click += new System.EventHandler(this.dataGridView_customer_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(380, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(215, 30);
            this.label6.TabIndex = 14;
            this.label6.Text = "MANAGE CUSTOMERS";
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(244, 228);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(88, 38);
            this.button_delete.TabIndex = 12;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(141, 228);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(88, 38);
            this.button_update.TabIndex = 11;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(36, 228);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(88, 38);
            this.button_add.TabIndex = 10;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
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
            // button_employee
            // 
            this.button_employee.Location = new System.Drawing.Point(25, 108);
            this.button_employee.Name = "button_employee";
            this.button_employee.Size = new System.Drawing.Size(88, 38);
            this.button_employee.TabIndex = 23;
            this.button_employee.Text = "Employees";
            this.button_employee.UseVisualStyleBackColor = true;
            this.button_employee.Click += new System.EventHandler(this.button_employee_Click);
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
            this.label4.Size = new System.Drawing.Size(99, 30);
            this.label4.TabIndex = 6;
            this.label4.Text = "Phone No";
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
            this.panel1.Controls.Add(this.TextBox_id);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridView_customer);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.button_delete);
            this.panel1.Controls.Add(this.button_update);
            this.panel1.Controls.Add(this.button_add);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.TextBox_phone);
            this.panel1.Controls.Add(this.TextBox_name);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(156, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(920, 601);
            this.panel1.TabIndex = 21;
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
            this.TextBox_id.Location = new System.Drawing.Point(133, 100);
            this.TextBox_id.Name = "TextBox_id";
            this.TextBox_id.PasswordChar = '\0';
            this.TextBox_id.PlaceholderText = "Leave Empty if ADDING";
            this.TextBox_id.SelectedText = "";
            this.TextBox_id.ShadowDecoration.Parent = this.TextBox_id;
            this.TextBox_id.Size = new System.Drawing.Size(200, 29);
            this.TextBox_id.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(32, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 30);
            this.label1.TabIndex = 17;
            this.label1.Text = "Id";
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 650);
            this.Controls.Add(this.button_product);
            this.Controls.Add(this.button_selling);
            this.Controls.Add(this.button_category);
            this.Controls.Add(this.button_employee);
            this.Controls.Add(this.label_exit);
            this.Controls.Add(this.button_logout);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerForm";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_customer)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_product;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridView_customer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_selling;
        private System.Windows.Forms.Button button_category;
        private System.Windows.Forms.Button button_employee;
        private System.Windows.Forms.Label label_exit;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_phone;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_name;
        private System.Windows.Forms.Button button_logout;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_id;
        private System.Windows.Forms.Label label1;
    }
}