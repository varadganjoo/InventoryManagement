namespace InventoryManagement
{
    partial class ManageCategories
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
            this.headPanel = new System.Windows.Forms.Panel();
            this.close = new System.Windows.Forms.Label();
            this.heading = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.CatName = new System.Windows.Forms.TextBox();
            this.CatId = new System.Windows.Forms.TextBox();
            this.CategoriesShow = new System.Windows.Forms.DataGridView();
            this.gridTitle = new System.Windows.Forms.Label();
            this.footPanel = new System.Windows.Forms.Panel();
            this.home = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.headPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CategoriesShow)).BeginInit();
            this.SuspendLayout();
            // 
            // headPanel
            // 
            this.headPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.headPanel.Controls.Add(this.close);
            this.headPanel.Controls.Add(this.heading);
            this.headPanel.Controls.Add(this.title);
            this.headPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headPanel.Location = new System.Drawing.Point(0, 0);
            this.headPanel.Name = "headPanel";
            this.headPanel.Size = new System.Drawing.Size(1357, 159);
            this.headPanel.TabIndex = 2;
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.close.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.close.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.close.Location = new System.Drawing.Point(1318, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(39, 38);
            this.close.TabIndex = 2;
            this.close.Text = "X";
            this.close.Click += new System.EventHandler(this.label3_Click);
            // 
            // heading
            // 
            this.heading.AutoSize = true;
            this.heading.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.heading.Location = new System.Drawing.Point(323, 25);
            this.heading.Name = "heading";
            this.heading.Size = new System.Drawing.Size(694, 57);
            this.heading.TabIndex = 1;
            this.heading.Text = "Inventory Management System";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.title.Location = new System.Drawing.Point(533, 110);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(297, 38);
            this.title.TabIndex = 0;
            this.title.Text = "Manage Categories";
            // 
            // CatName
            // 
            this.CatName.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CatName.Location = new System.Drawing.Point(99, 416);
            this.CatName.Name = "CatName";
            this.CatName.PlaceholderText = "Category Name";
            this.CatName.Size = new System.Drawing.Size(255, 43);
            this.CatName.TabIndex = 14;
            // 
            // CatId
            // 
            this.CatId.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CatId.Location = new System.Drawing.Point(99, 338);
            this.CatId.Name = "CatId";
            this.CatId.PlaceholderText = "Category Id";
            this.CatId.Size = new System.Drawing.Size(255, 43);
            this.CatId.TabIndex = 13;
            // 
            // CategoriesShow
            // 
            this.CategoriesShow.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CategoriesShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CategoriesShow.Location = new System.Drawing.Point(594, 221);
            this.CategoriesShow.Name = "CategoriesShow";
            this.CategoriesShow.RowHeadersWidth = 51;
            this.CategoriesShow.RowTemplate.Height = 29;
            this.CategoriesShow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CategoriesShow.Size = new System.Drawing.Size(663, 485);
            this.CategoriesShow.TabIndex = 18;
            this.CategoriesShow.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CategoriesShow_CellContentClick);
            // 
            // gridTitle
            // 
            this.gridTitle.AutoSize = true;
            this.gridTitle.Font = new System.Drawing.Font("Times New Roman", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gridTitle.Location = new System.Drawing.Point(826, 175);
            this.gridTitle.Name = "gridTitle";
            this.gridTitle.Size = new System.Drawing.Size(200, 32);
            this.gridTitle.TabIndex = 17;
            this.gridTitle.Text = "Categories List";
            // 
            // footPanel
            // 
            this.footPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.footPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footPanel.Location = new System.Drawing.Point(0, 726);
            this.footPanel.Name = "footPanel";
            this.footPanel.Size = new System.Drawing.Size(1357, 108);
            this.footPanel.TabIndex = 19;
            // 
            // home
            // 
            this.home.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.home.Location = new System.Drawing.Point(176, 553);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(98, 47);
            this.home.TabIndex = 23;
            this.home.Text = "Home";
            this.home.UseVisualStyleBackColor = true;
            this.home.Click += new System.EventHandler(this.button4_Click);
            // 
            // delete
            // 
            this.delete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.delete.Location = new System.Drawing.Point(280, 486);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(98, 47);
            this.delete.TabIndex = 22;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.button3_Click);
            // 
            // edit
            // 
            this.edit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.edit.Location = new System.Drawing.Point(176, 486);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(98, 47);
            this.edit.TabIndex = 21;
            this.edit.Text = "Edit";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.button2_Click);
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.add.Location = new System.Drawing.Point(72, 486);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(98, 47);
            this.add.TabIndex = 20;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.button1_Click);
            // 
            // ManageCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1357, 834);
            this.Controls.Add(this.home);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.add);
            this.Controls.Add(this.footPanel);
            this.Controls.Add(this.CategoriesShow);
            this.Controls.Add(this.gridTitle);
            this.Controls.Add(this.CatName);
            this.Controls.Add(this.CatId);
            this.Controls.Add(this.headPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageCategories";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageCategories";
            this.Load += new System.EventHandler(this.ManageCategories_Load);
            this.headPanel.ResumeLayout(false);
            this.headPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CategoriesShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel headPanel;
        private Label close;
        private Label heading;
        private Label title;
        private TextBox CatName;
        private TextBox CatId;
        private DataGridView CategoriesShow;
        private Label gridTitle;
        private Panel footPanel;
        private Button home;
        private Button delete;
        private Button edit;
        private Button add;
    }
}