namespace StockManagementSystem.UI
{
    partial class ItemSetup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemSetup));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.WarningLabel = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ReorderTextBox = new System.Windows.Forms.TextBox();
            this.reorderLabel4 = new System.Windows.Forms.Label();
            this.ItemNameTextBox = new System.Windows.Forms.TextBox();
            this.itemLabel3 = new System.Windows.Forms.Label();
            this.CompanyNameComboBox = new System.Windows.Forms.ComboBox();
            this.companyLabel2 = new System.Windows.Forms.Label();
            this.CategoryNameComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.WarningLabel);
            this.groupBox1.Controls.Add(this.SaveButton);
            this.groupBox1.Controls.Add(this.ReorderTextBox);
            this.groupBox1.Controls.Add(this.reorderLabel4);
            this.groupBox1.Controls.Add(this.ItemNameTextBox);
            this.groupBox1.Controls.Add(this.itemLabel3);
            this.groupBox1.Controls.Add(this.CompanyNameComboBox);
            this.groupBox1.Controls.Add(this.companyLabel2);
            this.groupBox1.Controls.Add(this.CategoryNameComboBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(868, 515);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Item Setup Form";
            // 
            // WarningLabel
            // 
            this.WarningLabel.Location = new System.Drawing.Point(240, 44);
            this.WarningLabel.Name = "WarningLabel";
            this.WarningLabel.Size = new System.Drawing.Size(559, 59);
            this.WarningLabel.TabIndex = 18;
            this.WarningLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(397, 358);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(199, 54);
            this.SaveButton.TabIndex = 17;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ReorderTextBox
            // 
            this.ReorderTextBox.Location = new System.Drawing.Point(303, 292);
            this.ReorderTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ReorderTextBox.Name = "ReorderTextBox";
            this.ReorderTextBox.Size = new System.Drawing.Size(452, 30);
            this.ReorderTextBox.TabIndex = 16;
            this.ReorderTextBox.TextChanged += new System.EventHandler(this.ReorderTextBox_TextChanged);
            // 
            // reorderLabel4
            // 
            this.reorderLabel4.AutoSize = true;
            this.reorderLabel4.Location = new System.Drawing.Point(113, 295);
            this.reorderLabel4.Name = "reorderLabel4";
            this.reorderLabel4.Size = new System.Drawing.Size(146, 25);
            this.reorderLabel4.TabIndex = 15;
            this.reorderLabel4.Text = "Reorder Level";
            // 
            // ItemNameTextBox
            // 
            this.ItemNameTextBox.Location = new System.Drawing.Point(303, 232);
            this.ItemNameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ItemNameTextBox.Name = "ItemNameTextBox";
            this.ItemNameTextBox.Size = new System.Drawing.Size(452, 30);
            this.ItemNameTextBox.TabIndex = 14;
            // 
            // itemLabel3
            // 
            this.itemLabel3.AutoSize = true;
            this.itemLabel3.Location = new System.Drawing.Point(113, 235);
            this.itemLabel3.Name = "itemLabel3";
            this.itemLabel3.Size = new System.Drawing.Size(115, 25);
            this.itemLabel3.TabIndex = 13;
            this.itemLabel3.Text = "Item Name";
            // 
            // CompanyNameComboBox
            // 
            this.CompanyNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CompanyNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CompanyNameComboBox.FormattingEnabled = true;
            this.CompanyNameComboBox.Location = new System.Drawing.Point(303, 172);
            this.CompanyNameComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CompanyNameComboBox.Name = "CompanyNameComboBox";
            this.CompanyNameComboBox.Size = new System.Drawing.Size(452, 33);
            this.CompanyNameComboBox.TabIndex = 12;
            // 
            // companyLabel2
            // 
            this.companyLabel2.AutoSize = true;
            this.companyLabel2.Location = new System.Drawing.Point(113, 175);
            this.companyLabel2.Name = "companyLabel2";
            this.companyLabel2.Size = new System.Drawing.Size(104, 25);
            this.companyLabel2.TabIndex = 11;
            this.companyLabel2.Text = "Company";
            // 
            // CategoryNameComboBox
            // 
            this.CategoryNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CategoryNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CategoryNameComboBox.FormattingEnabled = true;
            this.CategoryNameComboBox.Location = new System.Drawing.Point(303, 119);
            this.CategoryNameComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CategoryNameComboBox.Name = "CategoryNameComboBox";
            this.CategoryNameComboBox.Size = new System.Drawing.Size(452, 33);
            this.CategoryNameComboBox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Category";
            // 
            // ItemSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 515);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ItemSetup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ItemSetup";
            this.Load += new System.EventHandler(this.ItemSetup_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox ReorderTextBox;
        private System.Windows.Forms.Label reorderLabel4;
        private System.Windows.Forms.TextBox ItemNameTextBox;
        private System.Windows.Forms.Label itemLabel3;
        private System.Windows.Forms.ComboBox CompanyNameComboBox;
        private System.Windows.Forms.Label companyLabel2;
        private System.Windows.Forms.ComboBox CategoryNameComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label WarningLabel;
    }
}