namespace StockManagementSystem.UI
{
    partial class StockOut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockOut));
            this.itemLabel3 = new System.Windows.Forms.Label();
            this.reorderLabel4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.StockOutTextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CompanyNameComboBox = new System.Windows.Forms.ComboBox();
            this.CategoryNameComboBox = new System.Windows.Forms.ComboBox();
            this.ItemNameComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.companyLabel2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AvailableQuantityLabel = new System.Windows.Forms.Label();
            this.ReorderLevelLabel = new System.Windows.Forms.Label();
            this.WarningLabel = new System.Windows.Forms.Label();
            this.StockOutListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // itemLabel3
            // 
            this.itemLabel3.AutoSize = true;
            this.itemLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemLabel3.Location = new System.Drawing.Point(330, 177);
            this.itemLabel3.Name = "itemLabel3";
            this.itemLabel3.Size = new System.Drawing.Size(146, 25);
            this.itemLabel3.TabIndex = 44;
            this.itemLabel3.Text = "Reorder Level";
            // 
            // reorderLabel4
            // 
            this.reorderLabel4.AutoSize = true;
            this.reorderLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reorderLabel4.Location = new System.Drawing.Point(288, 223);
            this.reorderLabel4.Name = "reorderLabel4";
            this.reorderLabel4.Size = new System.Drawing.Size(188, 25);
            this.reorderLabel4.TabIndex = 46;
            this.reorderLabel4.Text = "Available Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(298, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 25);
            this.label3.TabIndex = 50;
            this.label3.Text = "Stock Out Quantity";
            // 
            // StockOutTextBox
            // 
            this.StockOutTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockOutTextBox.Location = new System.Drawing.Point(520, 266);
            this.StockOutTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StockOutTextBox.Name = "StockOutTextBox";
            this.StockOutTextBox.Size = new System.Drawing.Size(452, 30);
            this.StockOutTextBox.TabIndex = 51;
            this.StockOutTextBox.TextChanged += new System.EventHandler(this.StockOutTextBox_TextChanged);
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.Location = new System.Drawing.Point(773, 316);
            this.AddButton.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(199, 54);
            this.AddButton.TabIndex = 52;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(276, 794);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 54);
            this.button1.TabIndex = 53;
            this.button1.Text = "Sales";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(540, 794);
            this.button2.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(199, 54);
            this.button2.TabIndex = 54;
            this.button2.Text = "Damaged";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(791, 794);
            this.button3.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(199, 54);
            this.button3.TabIndex = 55;
            this.button3.Text = "Lost";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.StockOutListView);
            this.groupBox1.Controls.Add(this.WarningLabel);
            this.groupBox1.Controls.Add(this.AvailableQuantityLabel);
            this.groupBox1.Controls.Add(this.ReorderLevelLabel);
            this.groupBox1.Controls.Add(this.CompanyNameComboBox);
            this.groupBox1.Controls.Add(this.CategoryNameComboBox);
            this.groupBox1.Controls.Add(this.ItemNameComboBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.companyLabel2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.AddButton);
            this.groupBox1.Controls.Add(this.StockOutTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.reorderLabel4);
            this.groupBox1.Controls.Add(this.itemLabel3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1328, 861);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stock Output Form";
            // 
            // CompanyNameComboBox
            // 
            this.CompanyNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CompanyNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CompanyNameComboBox.FormattingEnabled = true;
            this.CompanyNameComboBox.Location = new System.Drawing.Point(520, 75);
            this.CompanyNameComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CompanyNameComboBox.Name = "CompanyNameComboBox";
            this.CompanyNameComboBox.Size = new System.Drawing.Size(452, 33);
            this.CompanyNameComboBox.TabIndex = 61;
            this.CompanyNameComboBox.SelectedIndexChanged += new System.EventHandler(this.CompanyNameComboBox_SelectedIndexChanged);
            // 
            // CategoryNameComboBox
            // 
            this.CategoryNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CategoryNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CategoryNameComboBox.FormattingEnabled = true;
            this.CategoryNameComboBox.Location = new System.Drawing.Point(520, 23);
            this.CategoryNameComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CategoryNameComboBox.Name = "CategoryNameComboBox";
            this.CategoryNameComboBox.Size = new System.Drawing.Size(452, 33);
            this.CategoryNameComboBox.TabIndex = 60;
            this.CategoryNameComboBox.SelectedValueChanged += new System.EventHandler(this.CategoryNameComboBox_SelectedValueChanged);
            // 
            // ItemNameComboBox
            // 
            this.ItemNameComboBox.FormattingEnabled = true;
            this.ItemNameComboBox.Location = new System.Drawing.Point(520, 128);
            this.ItemNameComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ItemNameComboBox.Name = "ItemNameComboBox";
            this.ItemNameComboBox.Size = new System.Drawing.Size(452, 33);
            this.ItemNameComboBox.TabIndex = 59;
            this.ItemNameComboBox.SelectedIndexChanged += new System.EventHandler(this.ItemNameComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(361, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 58;
            this.label2.Text = "Item Name";
            // 
            // companyLabel2
            // 
            this.companyLabel2.AutoSize = true;
            this.companyLabel2.Location = new System.Drawing.Point(372, 78);
            this.companyLabel2.Name = "companyLabel2";
            this.companyLabel2.Size = new System.Drawing.Size(104, 25);
            this.companyLabel2.TabIndex = 57;
            this.companyLabel2.Text = "Company";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(376, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 56;
            this.label1.Text = "Category";
            // 
            // AvailableQuantityLabel
            // 
            this.AvailableQuantityLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AvailableQuantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvailableQuantityLabel.Location = new System.Drawing.Point(515, 223);
            this.AvailableQuantityLabel.Name = "AvailableQuantityLabel";
            this.AvailableQuantityLabel.Size = new System.Drawing.Size(450, 25);
            this.AvailableQuantityLabel.TabIndex = 63;
            this.AvailableQuantityLabel.Text = "<View>";
            // 
            // ReorderLevelLabel
            // 
            this.ReorderLevelLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ReorderLevelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReorderLevelLabel.Location = new System.Drawing.Point(515, 177);
            this.ReorderLevelLabel.Name = "ReorderLevelLabel";
            this.ReorderLevelLabel.Size = new System.Drawing.Size(450, 25);
            this.ReorderLevelLabel.TabIndex = 62;
            this.ReorderLevelLabel.Text = "<View>";
            // 
            // WarningLabel
            // 
            this.WarningLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WarningLabel.Location = new System.Drawing.Point(978, 256);
            this.WarningLabel.Name = "WarningLabel";
            this.WarningLabel.Size = new System.Drawing.Size(308, 40);
            this.WarningLabel.TabIndex = 64;
            // 
            // StockOutListView
            // 
            this.StockOutListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.StockOutListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockOutListView.FullRowSelect = true;
            this.StockOutListView.GridLines = true;
            this.StockOutListView.Location = new System.Drawing.Point(29, 394);
            this.StockOutListView.Margin = new System.Windows.Forms.Padding(20);
            this.StockOutListView.Name = "StockOutListView";
            this.StockOutListView.Size = new System.Drawing.Size(1276, 376);
            this.StockOutListView.TabIndex = 65;
            this.StockOutListView.UseCompatibleStateImageBehavior = false;
            this.StockOutListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "SI";
            this.columnHeader1.Width = 56;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Item";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 236;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Company";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 286;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Quantity";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 232;
            // 
            // StockOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 861);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StockOut";
            this.Text = "StockOut";
            this.Load += new System.EventHandler(this.StockOut_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label itemLabel3;
        private System.Windows.Forms.Label reorderLabel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox StockOutTextBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CompanyNameComboBox;
        private System.Windows.Forms.ComboBox CategoryNameComboBox;
        private System.Windows.Forms.ComboBox ItemNameComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label companyLabel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label AvailableQuantityLabel;
        private System.Windows.Forms.Label ReorderLevelLabel;
        private System.Windows.Forms.Label WarningLabel;
        private System.Windows.Forms.ListView StockOutListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}