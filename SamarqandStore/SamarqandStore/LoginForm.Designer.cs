
namespace SamarqandStore
{
    partial class LoginForm
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
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.label_username = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_exit = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBox_username = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBox_password = new Guna.UI2.WinForms.Guna2TextBox();
            this.Button_login = new Guna.UI2.WinForms.Guna2Button();
            this.label_clear = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // guna2CircleButton1
            // 
            this.guna2CircleButton1.CheckedState.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.CustomImages.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton1.DisabledState.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.FillColor = System.Drawing.Color.Gold;
            this.guna2CircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton1.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton1.HoverState.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.Location = new System.Drawing.Point(-213, -15);
            this.guna2CircleButton1.Name = "guna2CircleButton1";
            this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton1.ShadowDecoration.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.Size = new System.Drawing.Size(469, 446);
            this.guna2CircleButton1.TabIndex = 0;
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_username.ForeColor = System.Drawing.Color.Goldenrod;
            this.label_username.Location = new System.Drawing.Point(311, 174);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(80, 20);
            this.label_username.TabIndex = 1;
            this.label_username.Text = "Username";
            this.label_username.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_password.ForeColor = System.Drawing.Color.Goldenrod;
            this.label_password.Location = new System.Drawing.Point(311, 208);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(76, 20);
            this.label_password.TabIndex = 2;
            this.label_password.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Goldenrod;
            this.label1.Location = new System.Drawing.Point(403, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "LOGIN";
            // 
            // label_exit
            // 
            this.label_exit.AutoSize = true;
            this.label_exit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_exit.ForeColor = System.Drawing.Color.Gold;
            this.label_exit.Location = new System.Drawing.Point(626, 0);
            this.label_exit.Name = "label_exit";
            this.label_exit.Size = new System.Drawing.Size(24, 25);
            this.label_exit.TabIndex = 4;
            this.label_exit.Text = "X";
            this.label_exit.Click += new System.EventHandler(this.label_exit_Click);
            this.label_exit.MouseEnter += new System.EventHandler(this.label_exit_MouseEnter);
            this.label_exit.MouseLeave += new System.EventHandler(this.label_exit_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gold;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(86, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Welcome!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gold;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(45, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 111);
            this.label3.TabIndex = 6;
            this.label3.Text = "Samarqand\r\nGeneral\r\nStore";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.TextBox_username.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_username.HoverState.Parent = this.TextBox_username;
            this.TextBox_username.Location = new System.Drawing.Point(410, 168);
            this.TextBox_username.Name = "TextBox_username";
            this.TextBox_username.PasswordChar = '\0';
            this.TextBox_username.PlaceholderText = "";
            this.TextBox_username.SelectedText = "";
            this.TextBox_username.ShadowDecoration.Parent = this.TextBox_username;
            this.TextBox_username.Size = new System.Drawing.Size(199, 30);
            this.TextBox_username.TabIndex = 7;
            this.TextBox_username.TextChanged += new System.EventHandler(this.TextBox_username_TextChanged);
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
            this.TextBox_password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_password.HoverState.Parent = this.TextBox_password;
            this.TextBox_password.Location = new System.Drawing.Point(410, 204);
            this.TextBox_password.Name = "TextBox_password";
            this.TextBox_password.PasswordChar = '●';
            this.TextBox_password.PlaceholderText = "";
            this.TextBox_password.SelectedText = "";
            this.TextBox_password.ShadowDecoration.Parent = this.TextBox_password;
            this.TextBox_password.Size = new System.Drawing.Size(199, 30);
            this.TextBox_password.TabIndex = 8;
            this.TextBox_password.UseSystemPasswordChar = true;
            // 
            // Button_login
            // 
            this.Button_login.CheckedState.Parent = this.Button_login;
            this.Button_login.CustomImages.Parent = this.Button_login;
            this.Button_login.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_login.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_login.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_login.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_login.DisabledState.Parent = this.Button_login;
            this.Button_login.FillColor = System.Drawing.Color.Goldenrod;
            this.Button_login.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Button_login.ForeColor = System.Drawing.Color.White;
            this.Button_login.HoverState.Parent = this.Button_login;
            this.Button_login.Location = new System.Drawing.Point(461, 255);
            this.Button_login.Name = "Button_login";
            this.Button_login.ShadowDecoration.Parent = this.Button_login;
            this.Button_login.Size = new System.Drawing.Size(92, 34);
            this.Button_login.TabIndex = 10;
            this.Button_login.Text = "Login";
            this.Button_login.Click += new System.EventHandler(this.Button_login_Click);
            // 
            // label_clear
            // 
            this.label_clear.AutoSize = true;
            this.label_clear.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_clear.ForeColor = System.Drawing.Color.Goldenrod;
            this.label_clear.Location = new System.Drawing.Point(477, 313);
            this.label_clear.Name = "label_clear";
            this.label_clear.Size = new System.Drawing.Size(47, 20);
            this.label_clear.TabIndex = 11;
            this.label_clear.Text = "Clear";
            this.label_clear.Click += new System.EventHandler(this.label_clear_Click);
            this.label_clear.MouseEnter += new System.EventHandler(this.label_clear_MouseEnter);
            this.label_clear.MouseLeave += new System.EventHandler(this.label_clear_MouseLeave);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 400);
            this.Controls.Add(this.label_clear);
            this.Controls.Add(this.Button_login);
            this.Controls.Add(this.TextBox_password);
            this.Controls.Add(this.TextBox_username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_exit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_username);
            this.Controls.Add(this.guna2CircleButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_exit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_username;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_password;
        private Guna.UI2.WinForms.Guna2Button Button_login;
        private System.Windows.Forms.Label label_clear;
    }
}

