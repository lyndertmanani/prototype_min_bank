﻿namespace ADIbanking
{
    partial class Adpayee_trans_view
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Pid = new System.Windows.Forms.TextBox();
            this.Deletbtn = new System.Windows.Forms.Button();
            this.Clearbtn = new System.Windows.Forms.Button();
            this.PayeeGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.PayeeGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.Menu;
            this.label1.Location = new System.Drawing.Point(11, 389);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 19);
            this.label1.TabIndex = 35;
            this.label1.Text = "Payee";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.25F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(64)))), ((int)(((byte)(84)))));
            this.label4.Location = new System.Drawing.Point(158, 392);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 34;
            this.label4.Text = "Select by ID";
            // 
            // Pid
            // 
            this.Pid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(28)))), ((int)(((byte)(51)))));
            this.Pid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Pid.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.Pid.ForeColor = System.Drawing.SystemColors.Window;
            this.Pid.Location = new System.Drawing.Point(242, 392);
            this.Pid.Name = "Pid";
            this.Pid.Size = new System.Drawing.Size(201, 23);
            this.Pid.TabIndex = 33;
            // 
            // Deletbtn
            // 
            this.Deletbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Deletbtn.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.Deletbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(174)))), ((int)(((byte)(221)))));
            this.Deletbtn.Location = new System.Drawing.Point(449, 389);
            this.Deletbtn.Name = "Deletbtn";
            this.Deletbtn.Size = new System.Drawing.Size(85, 26);
            this.Deletbtn.TabIndex = 31;
            this.Deletbtn.Text = "Delete";
            this.Deletbtn.UseVisualStyleBackColor = true;
            this.Deletbtn.Click += new System.EventHandler(this.Deletbtn_Click);
            // 
            // Clearbtn
            // 
            this.Clearbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clearbtn.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.Clearbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(174)))), ((int)(((byte)(221)))));
            this.Clearbtn.Location = new System.Drawing.Point(540, 389);
            this.Clearbtn.Name = "Clearbtn";
            this.Clearbtn.Size = new System.Drawing.Size(85, 26);
            this.Clearbtn.TabIndex = 32;
            this.Clearbtn.Text = "Clear";
            this.Clearbtn.UseVisualStyleBackColor = true;
            this.Clearbtn.Click += new System.EventHandler(this.Clearbtn_Click);
            // 
            // PayeeGrid
            // 
            this.PayeeGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(9)))), ((int)(((byte)(31)))));
            this.PayeeGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PayeeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PayeeGrid.GridColor = System.Drawing.Color.White;
            this.PayeeGrid.Location = new System.Drawing.Point(15, 27);
            this.PayeeGrid.Name = "PayeeGrid";
            this.PayeeGrid.Size = new System.Drawing.Size(610, 343);
            this.PayeeGrid.TabIndex = 30;
            // 
            // Adpayee_trans_view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(9)))), ((int)(((byte)(31)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Pid);
            this.Controls.Add(this.Deletbtn);
            this.Controls.Add(this.Clearbtn);
            this.Controls.Add(this.PayeeGrid);
            this.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(9)))), ((int)(((byte)(31)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Adpayee_trans_view";
            this.Size = new System.Drawing.Size(636, 442);
            this.Load += new System.EventHandler(this.Adpayee_trans_view_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PayeeGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Pid;
        private System.Windows.Forms.Button Deletbtn;
        private System.Windows.Forms.Button Clearbtn;
        private System.Windows.Forms.DataGridView PayeeGrid;
    }
}
