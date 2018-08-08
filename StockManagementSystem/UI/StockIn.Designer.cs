namespace StockManagementSystem.UI
{
    partial class StockIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockIn));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AvailableQuantityLabel = new System.Windows.Forms.Label();
            this.ReorderLevelLabel = new System.Windows.Forms.Label();
            this.CompanyNameComboBox = new System.Windows.Forms.ComboBox();
            this.CategoryNameComboBox = new System.Windows.Forms.ComboBox();
            this.StockInTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ItemNameComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.reorderLabel4 = new System.Windows.Forms.Label();
            this.itemLabel3 = new System.Windows.Forms.Label();
            this.companyLabel2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.WarningLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.WarningLabel);
            this.groupBox1.Controls.Add(this.AvailableQuantityLabel);
            this.groupBox1.Controls.Add(this.ReorderLevelLabel);
            this.groupBox1.Controls.Add(this.CompanyNameComboBox);
            this.groupBox1.Controls.Add(this.CategoryNameComboBox);
            this.groupBox1.Controls.Add(this.StockInTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ItemNameComboBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.SaveButton);
            this.groupBox1.Controls.Add(this.reorderLabel4);
            this.groupBox1.Controls.Add(this.itemLabel3);
            this.groupBox1.Controls.Add(this.companyLabel2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 656);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stock Input Form";
            // 
            // AvailableQuantityLabel
            // 
            this.AvailableQuantityLabel.AutoSize = true;
            this.AvailableQuantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvailableQuantityLabel.Location = new System.Drawing.Point(272, 375);
            this.AvailableQuantityLabel.Name = "AvailableQuantityLabel";
            this.AvailableQuantityLabel.Size = new System.Drawing.Size(79, 25);
            this.AvailableQuantityLabel.TabIndex = 25;
            this.AvailableQuantityLabel.Text = "<View>";
            // 
            // ReorderLevelLabel
            // 
            this.ReorderLevelLabel.AutoSize = true;
            this.ReorderLevelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReorderLevelLabel.Location = new System.Drawing.Point(272, 315);
            this.ReorderLevelLabel.Name = "ReorderLevelLabel";
            this.ReorderLevelLabel.Size = new System.Drawing.Size(79, 25);
            this.ReorderLevelLabel.TabIndex = 24;
            this.ReorderLevelLabel.Text = "<View>";
            // 
            // CompanyNameComboBox
            // 
            this.CompanyNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CompanyNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CompanyNameComboBox.FormattingEnabled = true;
            this.CompanyNameComboBox.Location = new System.Drawing.Point(277, 183);
            this.CompanyNameComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CompanyNameComboBox.Name = "CompanyNameComboBox";
            this.CompanyNameComboBox.Size = new System.Drawing.Size(452, 33);
            this.CompanyNameComboBox.TabIndex = 23;
            this.CompanyNameComboBox.SelectedValueChanged += new System.EventHandler(this.CompanyNameComboBox_SelectedValueChanged);
            // 
            // CategoryNameComboBox
            // 
            this.CategoryNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CategoryNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CategoryNameComboBox.FormattingEnabled = true;
            this.CategoryNameComboBox.Location = new System.Drawing.Point(277, 121);
            this.CategoryNameComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CategoryNameComboBox.Name = "CategoryNameComboBox";
            this.CategoryNameComboBox.Size = new System.Drawing.Size(452, 33);
            this.CategoryNameComboBox.TabIndex = 22;
            this.CategoryNameComboBox.SelectedValueChanged += new System.EventHandler(this.CategoryNameComboBox_SelectedValueChanged);
            // 
            // StockInTextBox
            // 
            this.StockInTextBox.Location = new System.Drawing.Point(277, 440);
            this.StockInTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StockInTextBox.Name = "StockInTextBox";
            this.StockInTextBox.Size = new System.Drawing.Size(452, 30);
            this.StockInTextBox.TabIndex = 21;
            this.StockInTextBox.TextChanged += new System.EventHandler(this.StockInTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 440);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "Stock In Quantity";
            // 
            // ItemNameComboBox
            // 
            this.ItemNameComboBox.FormattingEnabled = true;
            this.ItemNameComboBox.Location = new System.Drawing.Point(277, 247);
            this.ItemNameComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ItemNameComboBox.Name = "ItemNameComboBox";
            this.ItemNameComboBox.Size = new System.Drawing.Size(452, 33);
            this.ItemNameComboBox.TabIndex = 19;
            this.ItemNameComboBox.SelectedValueChanged += new System.EventHandler(this.ItemNameComboBox_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Item Name";
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(317, 516);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(199, 54);
            this.SaveButton.TabIndex = 17;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // reorderLabel4
            // 
            this.reorderLabel4.AutoSize = true;
            this.reorderLabel4.Location = new System.Drawing.Point(45, 375);
            this.reorderLabel4.Name = "reorderLabel4";
            this.reorderLabel4.Size = new System.Drawing.Size(188, 25);
            this.reorderLabel4.TabIndex = 15;
            this.reorderLabel4.Text = "Available Quantity";
            // 
            // itemLabel3
            // 
            this.itemLabel3.AutoSize = true;
            this.itemLabel3.Location = new System.Drawing.Point(87, 315);
            this.itemLabel3.Name = "itemLabel3";
            this.itemLabel3.Size = new System.Drawing.Size(146, 25);
            this.itemLabel3.TabIndex = 13;
            this.itemLabel3.Text = "Reorder Level";
            // 
            // companyLabel2
            // 
            this.companyLabel2.AutoSize = true;
            this.companyLabel2.Location = new System.Drawing.Point(129, 186);
            this.companyLabel2.Name = "companyLabel2";
            this.companyLabel2.Size = new System.Drawing.Size(104, 25);
            this.companyLabel2.TabIndex = 11;
            this.companyLabel2.Text = "Company";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Category";
            // 
            // WarningLabel
            // 
            this.WarningLabel.Location = new System.Drawing.Point(298, 38);
            this.WarningLabel.Name = "WarningLabel";
            this.WarningLabel.Size = new System.Drawing.Size(376, 54);
            this.WarningLabel.TabIndex = 26;
            // 
            // StockIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 656);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StockIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StockIn";
            this.Load += new System.EventHandler(this.StockIn_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label reorderLabel4;
        private System.Windows.Forms.Label itemLabel3;
        private System.Windows.Forms.Label companyLabel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox StockInTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ItemNameComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CompanyNameComboBox;
        private System.Windows.Forms.ComboBox CategoryNameComboBox;
        private System.Windows.Forms.Label AvailableQuantityLabel;
        private System.Windows.Forms.Label ReorderLevelLabel;
        private System.Windows.Forms.Label WarningLabel;
    }
}