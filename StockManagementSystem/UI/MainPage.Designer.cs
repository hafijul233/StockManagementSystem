namespace StockManagementSystem.UI
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Category Setup");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Company Setup");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Item Setup");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Stock In");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Sales");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Damage");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Lost");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Srock Out", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Report");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Home", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode8,
            treeNode9});
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.developersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ReportButton = new System.Windows.Forms.Button();
            this.SalesButton = new System.Windows.Forms.Button();
            this.ViewItemsButtons = new System.Windows.Forms.Button();
            this.StockOutButton = new System.Windows.Forms.Button();
            this.StockInButton = new System.Windows.Forms.Button();
            this.ItemSetupButton = new System.Windows.Forms.Button();
            this.CompanySetupButton = new System.Windows.Forms.Button();
            this.CategorySetupButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1370, 38);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "hridoy";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(58, 34);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(93, 34);
            this.settingToolStripMenuItem.Text = "Setting";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productToolStripMenuItem,
            this.developersToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(84, 34);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(208, 34);
            this.productToolStripMenuItem.Text = "Product";
            // 
            // developersToolStripMenuItem
            // 
            this.developersToolStripMenuItem.Name = "developersToolStripMenuItem";
            this.developersToolStripMenuItem.Size = new System.Drawing.Size(208, 34);
            this.developersToolStripMenuItem.Text = "Developers";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(66, 34);
            this.quitToolStripMenuItem.Text = "Quit";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(176, 34);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(176, 34);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 38);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1370, 674);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 10;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.ReportButton, 8, 0);
            this.tableLayoutPanel2.Controls.Add(this.SalesButton, 7, 0);
            this.tableLayoutPanel2.Controls.Add(this.ViewItemsButtons, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.StockOutButton, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.StockInButton, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.ItemSetupButton, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.CompanySetupButton, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.CategorySetupButton, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1364, 159);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // ReportButton
            // 
            this.ReportButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportButton.Image = global::StockManagementSystem.Properties.Resources.Report;
            this.ReportButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ReportButton.Location = new System.Drawing.Point(1210, 9);
            this.ReportButton.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.ReportButton.Name = "ReportButton";
            this.ReportButton.Size = new System.Drawing.Size(130, 141);
            this.ReportButton.TabIndex = 8;
            this.ReportButton.Text = "Report";
            this.ReportButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ReportButton.UseVisualStyleBackColor = true;
            this.ReportButton.Click += new System.EventHandler(this.ReportButton_Click);
            // 
            // SalesButton
            // 
            this.SalesButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SalesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesButton.Image = global::StockManagementSystem.Properties.Resources.Sales;
            this.SalesButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SalesButton.Location = new System.Drawing.Point(1060, 9);
            this.SalesButton.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.SalesButton.Name = "SalesButton";
            this.SalesButton.Size = new System.Drawing.Size(130, 141);
            this.SalesButton.TabIndex = 7;
            this.SalesButton.Text = "Sales";
            this.SalesButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.SalesButton.UseVisualStyleBackColor = true;
            this.SalesButton.Click += new System.EventHandler(this.SalesButton_Click);
            // 
            // ViewItemsButtons
            // 
            this.ViewItemsButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewItemsButtons.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewItemsButtons.Image = global::StockManagementSystem.Properties.Resources.ViewItem;
            this.ViewItemsButtons.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ViewItemsButtons.Location = new System.Drawing.Point(910, 9);
            this.ViewItemsButtons.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.ViewItemsButtons.Name = "ViewItemsButtons";
            this.ViewItemsButtons.Size = new System.Drawing.Size(130, 141);
            this.ViewItemsButtons.TabIndex = 6;
            this.ViewItemsButtons.Text = "View Items";
            this.ViewItemsButtons.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ViewItemsButtons.UseVisualStyleBackColor = true;
            this.ViewItemsButtons.Click += new System.EventHandler(this.ViewItemsButtons_Click);
            // 
            // StockOutButton
            // 
            this.StockOutButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StockOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockOutButton.Image = global::StockManagementSystem.Properties.Resources.StockOut;
            this.StockOutButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.StockOutButton.Location = new System.Drawing.Point(760, 9);
            this.StockOutButton.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.StockOutButton.Name = "StockOutButton";
            this.StockOutButton.Size = new System.Drawing.Size(130, 141);
            this.StockOutButton.TabIndex = 5;
            this.StockOutButton.Text = "Stock Out";
            this.StockOutButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.StockOutButton.UseVisualStyleBackColor = true;
            this.StockOutButton.Click += new System.EventHandler(this.StockOutButton_Click);
            // 
            // StockInButton
            // 
            this.StockInButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StockInButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockInButton.Image = global::StockManagementSystem.Properties.Resources.StockIn;
            this.StockInButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.StockInButton.Location = new System.Drawing.Point(610, 9);
            this.StockInButton.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.StockInButton.Name = "StockInButton";
            this.StockInButton.Size = new System.Drawing.Size(130, 141);
            this.StockInButton.TabIndex = 4;
            this.StockInButton.Text = "Stock In";
            this.StockInButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.StockInButton.UseVisualStyleBackColor = true;
            this.StockInButton.Click += new System.EventHandler(this.StockInButton_Click);
            // 
            // ItemSetupButton
            // 
            this.ItemSetupButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemSetupButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemSetupButton.Image = global::StockManagementSystem.Properties.Resources.Item;
            this.ItemSetupButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ItemSetupButton.Location = new System.Drawing.Point(460, 9);
            this.ItemSetupButton.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.ItemSetupButton.Name = "ItemSetupButton";
            this.ItemSetupButton.Size = new System.Drawing.Size(130, 141);
            this.ItemSetupButton.TabIndex = 3;
            this.ItemSetupButton.Text = "Item Setup";
            this.ItemSetupButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ItemSetupButton.UseVisualStyleBackColor = true;
            this.ItemSetupButton.Click += new System.EventHandler(this.ItemSetupButton_Click);
            // 
            // CompanySetupButton
            // 
            this.CompanySetupButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CompanySetupButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompanySetupButton.Image = global::StockManagementSystem.Properties.Resources.Company;
            this.CompanySetupButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CompanySetupButton.Location = new System.Drawing.Point(310, 9);
            this.CompanySetupButton.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.CompanySetupButton.Name = "CompanySetupButton";
            this.CompanySetupButton.Size = new System.Drawing.Size(130, 141);
            this.CompanySetupButton.TabIndex = 2;
            this.CompanySetupButton.Text = "Company Setup";
            this.CompanySetupButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CompanySetupButton.UseVisualStyleBackColor = true;
            this.CompanySetupButton.Click += new System.EventHandler(this.CompanySetupButton_Click);
            // 
            // CategorySetupButton
            // 
            this.CategorySetupButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CategorySetupButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategorySetupButton.Image = ((System.Drawing.Image)(resources.GetObject("CategorySetupButton.Image")));
            this.CategorySetupButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CategorySetupButton.Location = new System.Drawing.Point(160, 9);
            this.CategorySetupButton.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.CategorySetupButton.Name = "CategorySetupButton";
            this.CategorySetupButton.Size = new System.Drawing.Size(130, 141);
            this.CategorySetupButton.TabIndex = 1;
            this.CategorySetupButton.Text = "Category Setup";
            this.CategorySetupButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CategorySetupButton.UseVisualStyleBackColor = true;
            this.CategorySetupButton.Click += new System.EventHandler(this.CategorySetupButton_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::StockManagementSystem.Properties.Resources.Dashboard3;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(10, 9);
            this.button1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 141);
            this.button1.TabIndex = 0;
            this.button1.Text = "Home";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.treeView1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 168);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1364, 512);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.Location = new System.Drawing.Point(3, 3);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node1";
            treeNode1.Text = "Category Setup";
            treeNode2.Name = "Node2";
            treeNode2.Text = "Company Setup";
            treeNode3.Name = "Node3";
            treeNode3.Text = "Item Setup";
            treeNode4.Name = "Node0";
            treeNode4.Text = "Stock In";
            treeNode5.Name = "Node3";
            treeNode5.Text = "Sales";
            treeNode6.Name = "Node4";
            treeNode6.Text = "Damage";
            treeNode7.Name = "Node5";
            treeNode7.Text = "Lost";
            treeNode8.Name = "Node2";
            treeNode8.Text = "Srock Out";
            treeNode9.Name = "Node8";
            treeNode9.Text = "Report";
            treeNode10.Name = "Node0";
            treeNode10.Text = "Home";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode10});
            this.treeView1.Size = new System.Drawing.Size(294, 506);
            this.treeView1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Controls.Add(this.listView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(303, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1470, 506);
            this.panel2.TabIndex = 1;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1470, 506);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "SI";
            this.columnHeader1.Width = 56;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Item Name";
            this.columnHeader2.Width = 404;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Category";
            this.columnHeader3.Width = 156;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Available Qty";
            this.columnHeader5.Width = 173;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Reorder Qty";
            this.columnHeader6.Width = 160;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Sales";
            this.columnHeader7.Width = 145;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Damaged";
            this.columnHeader8.Width = 152;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Lost";
            this.columnHeader9.Width = 140;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 712);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainPage_FormClosing);
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem developersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ReportButton;
        private System.Windows.Forms.Button SalesButton;
        private System.Windows.Forms.Button ViewItemsButtons;
        private System.Windows.Forms.Button StockOutButton;
        private System.Windows.Forms.Button StockInButton;
        private System.Windows.Forms.Button ItemSetupButton;
        private System.Windows.Forms.Button CompanySetupButton;
        private System.Windows.Forms.Button CategorySetupButton;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
    }
}