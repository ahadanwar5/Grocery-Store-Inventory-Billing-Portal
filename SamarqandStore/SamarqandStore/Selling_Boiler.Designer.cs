
namespace SamarqandStore
{
    partial class Selling_Boiler
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
            this.button_logout = new System.Windows.Forms.Button();
            this.label_exit = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_sell = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_logout
            // 
            this.button_logout.Location = new System.Drawing.Point(17, 580);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(88, 38);
            this.button_logout.TabIndex = 40;
            this.button_logout.Text = "Logout";
            this.button_logout.UseVisualStyleBackColor = true;
            // 
            // label_exit
            // 
            this.label_exit.AutoSize = true;
            this.label_exit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_exit.ForeColor = System.Drawing.Color.Gold;
            this.label_exit.Location = new System.Drawing.Point(1037, 1);
            this.label_exit.Name = "label_exit";
            this.label_exit.Size = new System.Drawing.Size(24, 25);
            this.label_exit.TabIndex = 36;
            this.label_exit.Text = "X";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Goldenrod;
            this.panel1.Controls.Add(this.button_sell);
            this.panel1.Location = new System.Drawing.Point(156, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(920, 601);
            this.panel1.TabIndex = 35;
            // 
            // button_sell
            // 
            this.button_sell.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_sell.Location = new System.Drawing.Point(162, 226);
            this.button_sell.Name = "button_sell";
            this.button_sell.Size = new System.Drawing.Size(198, 94);
            this.button_sell.TabIndex = 0;
            this.button_sell.Text = "SELL";
            this.button_sell.UseVisualStyleBackColor = true;
            this.button_sell.Click += new System.EventHandler(this.button_sell_Click);
            // 
            // Selling_Boiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 650);
            this.Controls.Add(this.button_logout);
            this.Controls.Add(this.label_exit);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Selling_Boiler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selling_Boiler";
            this.Load += new System.EventHandler(this.Selling_Boiler_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_logout;
        private System.Windows.Forms.Label label_exit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_sell;
    }
}