﻿namespace InventoryManagement
{
    partial class ManageUsers
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.TextBox();
            this.fullName = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.contact = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.UsersShow = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.userId = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsersShow)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1357, 159);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(1318, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 38);
            this.label3.TabIndex = 2;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(323, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(694, 57);
            this.label2.TabIndex = 1;
            this.label2.Text = "Inventory Management System";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(576, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage User";
            // 
            // userName
            // 
            this.userName.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userName.Location = new System.Drawing.Point(99, 282);
            this.userName.Name = "userName";
            this.userName.PlaceholderText = "Username";
            this.userName.Size = new System.Drawing.Size(255, 43);
            this.userName.TabIndex = 1;
            // 
            // fullName
            // 
            this.fullName.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fullName.Location = new System.Drawing.Point(99, 349);
            this.fullName.Name = "fullName";
            this.fullName.PlaceholderText = "Full Name";
            this.fullName.Size = new System.Drawing.Size(255, 43);
            this.fullName.TabIndex = 2;
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.password.Location = new System.Drawing.Point(99, 409);
            this.password.Name = "password";
            this.password.PlaceholderText = "Password";
            this.password.Size = new System.Drawing.Size(255, 43);
            this.password.TabIndex = 3;
            // 
            // contact
            // 
            this.contact.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.contact.Location = new System.Drawing.Point(99, 469);
            this.contact.Name = "contact";
            this.contact.PlaceholderText = "Contact";
            this.contact.Size = new System.Drawing.Size(255, 43);
            this.contact.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(67, 553);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 47);
            this.button1.TabIndex = 5;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(171, 553);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 47);
            this.button2.TabIndex = 6;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(275, 553);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 47);
            this.button3.TabIndex = 7;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(171, 620);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(98, 47);
            this.button4.TabIndex = 8;
            this.button4.Text = "Home";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 726);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1357, 108);
            this.panel2.TabIndex = 10;
            // 
            // UsersShow
            // 
            this.UsersShow.BackgroundColor = System.Drawing.Color.White;
            this.UsersShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsersShow.Location = new System.Drawing.Point(576, 207);
            this.UsersShow.Name = "UsersShow";
            this.UsersShow.RowHeadersWidth = 51;
            this.UsersShow.RowTemplate.Height = 29;
            this.UsersShow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UsersShow.Size = new System.Drawing.Size(700, 477);
            this.UsersShow.TabIndex = 11;
            this.UsersShow.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UsersShow_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(867, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "User List";
            // 
            // userId
            // 
            this.userId.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userId.Location = new System.Drawing.Point(99, 218);
            this.userId.Name = "userId";
            this.userId.PlaceholderText = "User ID";
            this.userId.Size = new System.Drawing.Size(255, 43);
            this.userId.TabIndex = 12;
            // 
            // ManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1357, 834);
            this.Controls.Add(this.userId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.UsersShow);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.contact);
            this.Controls.Add(this.password);
            this.Controls.Add(this.fullName);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageUsers";
            this.Load += new System.EventHandler(this.ManageUsers_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsersShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox userName;
        private TextBox fullName;
        private TextBox password;
        private TextBox contact;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Panel panel2;
        private Label label3;
        private DataGridView UsersShow;
        private Label label4;
        private TextBox userId;
    }
}