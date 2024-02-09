
namespace SamarqandStore
{
    partial class priceHistoryForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label_exit = new System.Windows.Forms.Label();
            this.button_go_back = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView_pricelog = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_pricelog)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_exit
            // 
            this.label_exit.AutoSize = true;
            this.label_exit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_exit.ForeColor = System.Drawing.Color.Gold;
            this.label_exit.Location = new System.Drawing.Point(1027, -8);
            this.label_exit.Name = "label_exit";
            this.label_exit.Size = new System.Drawing.Size(24, 25);
            this.label_exit.TabIndex = 36;
            this.label_exit.Text = "X";
            // 
            // button_go_back
            // 
            this.button_go_back.Location = new System.Drawing.Point(12, 549);
            this.button_go_back.Name = "button_go_back";
            this.button_go_back.Size = new System.Drawing.Size(88, 38);
            this.button_go_back.TabIndex = 12;
            this.button_go_back.Text = "Go Back <";
            this.button_go_back.UseVisualStyleBackColor = true;
            this.button_go_back.Click += new System.EventHandler(this.button_go_back_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(380, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(202, 30);
            this.label6.TabIndex = 14;
            this.label6.Text = "Price Change History";
            // 
            // dataGridView_pricelog
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridView_pricelog.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_pricelog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_pricelog.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_pricelog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_pricelog.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView_pricelog.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_pricelog.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_pricelog.ColumnHeadersHeight = 24;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_pricelog.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_pricelog.EnableHeadersVisualStyles = false;
            this.dataGridView_pricelog.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_pricelog.Location = new System.Drawing.Point(120, 57);
            this.dataGridView_pricelog.Name = "dataGridView_pricelog";
            this.dataGridView_pricelog.RowHeadersVisible = false;
            this.dataGridView_pricelog.RowHeadersWidth = 24;
            this.dataGridView_pricelog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_pricelog.Size = new System.Drawing.Size(783, 530);
            this.dataGridView_pricelog.TabIndex = 16;
            this.dataGridView_pricelog.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_pricelog.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridView_pricelog.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridView_pricelog.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridView_pricelog.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridView_pricelog.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_pricelog.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_pricelog.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridView_pricelog.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView_pricelog.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView_pricelog.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView_pricelog.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridView_pricelog.ThemeStyle.HeaderStyle.Height = 24;
            this.dataGridView_pricelog.ThemeStyle.ReadOnly = false;
            this.dataGridView_pricelog.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_pricelog.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView_pricelog.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView_pricelog.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView_pricelog.ThemeStyle.RowsStyle.Height = 22;
            this.dataGridView_pricelog.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_pricelog.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Goldenrod;
            this.panel1.Controls.Add(this.dataGridView_pricelog);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.button_go_back);
            this.panel1.Location = new System.Drawing.Point(148, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(920, 601);
            this.panel1.TabIndex = 35;
            // 
            // priceHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 611);
            this.Controls.Add(this.label_exit);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "priceHistoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "priceHistoryForm";
            this.Load += new System.EventHandler(this.priceHistoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_pricelog)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_exit;
        private System.Windows.Forms.Button button_go_back;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridView_pricelog;
        private System.Windows.Forms.Panel panel1;
    }
}