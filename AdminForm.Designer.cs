namespace FinalProject_Group11
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.panelInventory = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.BtnInventoryDel = new System.Windows.Forms.Button();
            this.BtnInventoryUd = new System.Windows.Forms.Button();
            this.BtnInventoryRead = new System.Windows.Forms.Button();
            this.BtnInventoryCreate = new System.Windows.Forms.Button();
            this.textInvSearch = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.dataGridInventory = new System.Windows.Forms.DataGridView();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panelBorrowed = new System.Windows.Forms.Panel();
            this.BtnBorrowDel = new System.Windows.Forms.Button();
            this.BtnBorrowUD = new System.Windows.Forms.Button();
            this.BtnBorrowRead = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textDetailSearch = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.dataGridDetails = new System.Windows.Forms.DataGridView();
            this.BtnBorrowCreate = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.panel16 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.labelNumBooks = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblBorrowedBooks = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.labeluserPenalty = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonDash = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panelInventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panelBorrowed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDetails)).BeginInit();
            this.panel16.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelInventory
            // 
            this.panelInventory.Controls.Add(this.label15);
            this.panelInventory.Controls.Add(this.BtnInventoryDel);
            this.panelInventory.Controls.Add(this.BtnInventoryUd);
            this.panelInventory.Controls.Add(this.BtnInventoryRead);
            this.panelInventory.Controls.Add(this.BtnInventoryCreate);
            this.panelInventory.Controls.Add(this.textInvSearch);
            this.panelInventory.Controls.Add(this.label17);
            this.panelInventory.Controls.Add(this.dataGridInventory);
            this.panelInventory.Controls.Add(this.pictureBox3);
            this.panelInventory.Location = new System.Drawing.Point(175, 37);
            this.panelInventory.Name = "panelInventory";
            this.panelInventory.Size = new System.Drawing.Size(626, 412);
            this.panelInventory.TabIndex = 10;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Bell Gothic Std Light", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(98, 24);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(254, 26);
            this.label15.TabIndex = 11;
            this.label15.Text = "Book Inventory and Status";
            // 
            // BtnInventoryDel
            // 
            this.BtnInventoryDel.BackColor = System.Drawing.Color.Transparent;
            this.BtnInventoryDel.BackgroundImage = global::FinalProject_Group11.Properties.Resources.red_button;
            this.BtnInventoryDel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnInventoryDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInventoryDel.Font = new System.Drawing.Font("Bell Gothic Std Black", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInventoryDel.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnInventoryDel.Location = new System.Drawing.Point(298, 376);
            this.BtnInventoryDel.Name = "BtnInventoryDel";
            this.BtnInventoryDel.Size = new System.Drawing.Size(81, 32);
            this.BtnInventoryDel.TabIndex = 17;
            this.BtnInventoryDel.Text = "Delete";
            this.BtnInventoryDel.UseVisualStyleBackColor = false;
            this.BtnInventoryDel.Click += new System.EventHandler(this.BtnInventoryDel_Click);
            // 
            // BtnInventoryUd
            // 
            this.BtnInventoryUd.BackColor = System.Drawing.Color.Transparent;
            this.BtnInventoryUd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnInventoryUd.BackgroundImage")));
            this.BtnInventoryUd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnInventoryUd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInventoryUd.Font = new System.Drawing.Font("Bell Gothic Std Black", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInventoryUd.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnInventoryUd.Location = new System.Drawing.Point(206, 376);
            this.BtnInventoryUd.Name = "BtnInventoryUd";
            this.BtnInventoryUd.Size = new System.Drawing.Size(81, 32);
            this.BtnInventoryUd.TabIndex = 16;
            this.BtnInventoryUd.Text = "Update";
            this.BtnInventoryUd.UseVisualStyleBackColor = false;
            this.BtnInventoryUd.Click += new System.EventHandler(this.BtnInventoryUd_Click);
            // 
            // BtnInventoryRead
            // 
            this.BtnInventoryRead.BackColor = System.Drawing.Color.Transparent;
            this.BtnInventoryRead.BackgroundImage = global::FinalProject_Group11.Properties.Resources.green_button_removebg_removebg_preview;
            this.BtnInventoryRead.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnInventoryRead.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInventoryRead.Font = new System.Drawing.Font("Bell Gothic Std Black", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInventoryRead.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnInventoryRead.Location = new System.Drawing.Point(114, 376);
            this.BtnInventoryRead.Name = "BtnInventoryRead";
            this.BtnInventoryRead.Size = new System.Drawing.Size(81, 32);
            this.BtnInventoryRead.TabIndex = 15;
            this.BtnInventoryRead.Text = "Read";
            this.BtnInventoryRead.UseVisualStyleBackColor = false;
            this.BtnInventoryRead.Click += new System.EventHandler(this.BtnInventoryRead_Click);
            // 
            // BtnInventoryCreate
            // 
            this.BtnInventoryCreate.BackColor = System.Drawing.Color.Transparent;
            this.BtnInventoryCreate.BackgroundImage = global::FinalProject_Group11.Properties.Resources.blue_button_removebg_removebg_preview;
            this.BtnInventoryCreate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnInventoryCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInventoryCreate.Font = new System.Drawing.Font("Bell Gothic Std Black", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInventoryCreate.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnInventoryCreate.Location = new System.Drawing.Point(22, 376);
            this.BtnInventoryCreate.Name = "BtnInventoryCreate";
            this.BtnInventoryCreate.Size = new System.Drawing.Size(81, 32);
            this.BtnInventoryCreate.TabIndex = 14;
            this.BtnInventoryCreate.Text = "Create";
            this.BtnInventoryCreate.UseVisualStyleBackColor = false;
            this.BtnInventoryCreate.Click += new System.EventHandler(this.BtnInventoryCreate_Click);
            // 
            // textInvSearch
            // 
            this.textInvSearch.Location = new System.Drawing.Point(407, 56);
            this.textInvSearch.Name = "textInvSearch";
            this.textInvSearch.Size = new System.Drawing.Size(208, 20);
            this.textInvSearch.TabIndex = 13;
            this.textInvSearch.TextChanged += new System.EventHandler(this.textInvSearch_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Bell Gothic Std Black", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(366, 59);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(44, 14);
            this.label17.TabIndex = 12;
            this.label17.Text = "Search";
            // 
            // dataGridInventory
            // 
            this.dataGridInventory.AllowUserToAddRows = false;
            this.dataGridInventory.AllowUserToDeleteRows = false;
            this.dataGridInventory.AllowUserToResizeColumns = false;
            this.dataGridInventory.AllowUserToResizeRows = false;
            this.dataGridInventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridInventory.BackgroundColor = System.Drawing.Color.White;
            this.dataGridInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridInventory.Location = new System.Drawing.Point(13, 81);
            this.dataGridInventory.Name = "dataGridInventory";
            this.dataGridInventory.ReadOnly = true;
            this.dataGridInventory.RowHeadersVisible = false;
            this.dataGridInventory.ShowEditingIcon = false;
            this.dataGridInventory.Size = new System.Drawing.Size(602, 289);
            this.dataGridInventory.StandardTab = true;
            this.dataGridInventory.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::FinalProject_Group11.Properties.Resources.image_removebg_preview__18_;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(13, 13);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 59);
            this.pictureBox3.TabIndex = 30;
            this.pictureBox3.TabStop = false;
            // 
            // panelBorrowed
            // 
            this.panelBorrowed.Controls.Add(this.BtnBorrowDel);
            this.panelBorrowed.Controls.Add(this.BtnBorrowUD);
            this.panelBorrowed.Controls.Add(this.BtnBorrowRead);
            this.panelBorrowed.Controls.Add(this.label23);
            this.panelBorrowed.Controls.Add(this.pictureBox2);
            this.panelBorrowed.Controls.Add(this.textDetailSearch);
            this.panelBorrowed.Controls.Add(this.label22);
            this.panelBorrowed.Controls.Add(this.dataGridDetails);
            this.panelBorrowed.Controls.Add(this.BtnBorrowCreate);
            this.panelBorrowed.Location = new System.Drawing.Point(175, 38);
            this.panelBorrowed.Name = "panelBorrowed";
            this.panelBorrowed.Size = new System.Drawing.Size(616, 406);
            this.panelBorrowed.TabIndex = 11;
            // 
            // BtnBorrowDel
            // 
            this.BtnBorrowDel.BackColor = System.Drawing.Color.Transparent;
            this.BtnBorrowDel.BackgroundImage = global::FinalProject_Group11.Properties.Resources.red_button;
            this.BtnBorrowDel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnBorrowDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBorrowDel.Font = new System.Drawing.Font("Bell Gothic Std Black", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBorrowDel.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnBorrowDel.Location = new System.Drawing.Point(304, 367);
            this.BtnBorrowDel.Name = "BtnBorrowDel";
            this.BtnBorrowDel.Size = new System.Drawing.Size(81, 32);
            this.BtnBorrowDel.TabIndex = 17;
            this.BtnBorrowDel.Text = "Delete";
            this.BtnBorrowDel.UseVisualStyleBackColor = false;
            this.BtnBorrowDel.Click += new System.EventHandler(this.BtnBorrowDel_Click);
            // 
            // BtnBorrowUD
            // 
            this.BtnBorrowUD.BackColor = System.Drawing.Color.Transparent;
            this.BtnBorrowUD.BackgroundImage = global::FinalProject_Group11.Properties.Resources.gold_button_removebg_preview__1_;
            this.BtnBorrowUD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnBorrowUD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBorrowUD.Font = new System.Drawing.Font("Bell Gothic Std Black", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBorrowUD.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnBorrowUD.Location = new System.Drawing.Point(213, 367);
            this.BtnBorrowUD.Name = "BtnBorrowUD";
            this.BtnBorrowUD.Size = new System.Drawing.Size(81, 32);
            this.BtnBorrowUD.TabIndex = 16;
            this.BtnBorrowUD.Text = "Update";
            this.BtnBorrowUD.UseVisualStyleBackColor = false;
            this.BtnBorrowUD.Click += new System.EventHandler(this.BtnBorrowUD_Click);
            // 
            // BtnBorrowRead
            // 
            this.BtnBorrowRead.BackColor = System.Drawing.Color.Transparent;
            this.BtnBorrowRead.BackgroundImage = global::FinalProject_Group11.Properties.Resources.green_button_removebg_removebg_preview;
            this.BtnBorrowRead.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnBorrowRead.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBorrowRead.Font = new System.Drawing.Font("Bell Gothic Std Black", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBorrowRead.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnBorrowRead.Location = new System.Drawing.Point(120, 367);
            this.BtnBorrowRead.Name = "BtnBorrowRead";
            this.BtnBorrowRead.Size = new System.Drawing.Size(81, 32);
            this.BtnBorrowRead.TabIndex = 15;
            this.BtnBorrowRead.Text = "Read";
            this.BtnBorrowRead.UseVisualStyleBackColor = false;
            this.BtnBorrowRead.Click += new System.EventHandler(this.BtnBorrowRead_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Bell Gothic Std Light", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(106, 13);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(289, 26);
            this.label23.TabIndex = 22;
            this.label23.Text = "Borrowing Details and Penalty";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::FinalProject_Group11.Properties.Resources.image_removebg_preview__18_;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(20, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 59);
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            // 
            // textDetailSearch
            // 
            this.textDetailSearch.Location = new System.Drawing.Point(427, 55);
            this.textDetailSearch.Name = "textDetailSearch";
            this.textDetailSearch.Size = new System.Drawing.Size(178, 20);
            this.textDetailSearch.TabIndex = 24;
            this.textDetailSearch.TextChanged += new System.EventHandler(this.textDetailSearch_TextChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Bell Gothic Std Black", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(377, 60);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(44, 14);
            this.label22.TabIndex = 23;
            this.label22.Text = "Search";
            // 
            // dataGridDetails
            // 
            this.dataGridDetails.AllowUserToAddRows = false;
            this.dataGridDetails.AllowUserToDeleteRows = false;
            this.dataGridDetails.AllowUserToResizeColumns = false;
            this.dataGridDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridDetails.BackgroundColor = System.Drawing.Color.White;
            this.dataGridDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDetails.Location = new System.Drawing.Point(15, 79);
            this.dataGridDetails.Name = "dataGridDetails";
            this.dataGridDetails.ReadOnly = true;
            this.dataGridDetails.RowHeadersVisible = false;
            this.dataGridDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridDetails.Size = new System.Drawing.Size(590, 283);
            this.dataGridDetails.TabIndex = 21;
            // 
            // BtnBorrowCreate
            // 
            this.BtnBorrowCreate.BackColor = System.Drawing.Color.Transparent;
            this.BtnBorrowCreate.BackgroundImage = global::FinalProject_Group11.Properties.Resources.blue_button_removebg_removebg_preview;
            this.BtnBorrowCreate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnBorrowCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBorrowCreate.Font = new System.Drawing.Font("Bell Gothic Std Black", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBorrowCreate.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnBorrowCreate.Location = new System.Drawing.Point(28, 367);
            this.BtnBorrowCreate.Name = "BtnBorrowCreate";
            this.BtnBorrowCreate.Size = new System.Drawing.Size(81, 32);
            this.BtnBorrowCreate.TabIndex = 14;
            this.BtnBorrowCreate.Text = "Create";
            this.BtnBorrowCreate.UseVisualStyleBackColor = false;
            this.BtnBorrowCreate.Click += new System.EventHandler(this.BtnBorrowCreate_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.White;
            this.label16.Font = new System.Drawing.Font("Bell Gothic Std Light", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(104, 27);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(108, 26);
            this.label16.TabIndex = 10;
            this.label16.Text = "Dashboard";
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.White;
            this.panel16.Controls.Add(this.panel5);
            this.panel16.Controls.Add(this.panel6);
            this.panel16.Controls.Add(this.label16);
            this.panel16.Controls.Add(this.pictureBox4);
            this.panel16.Controls.Add(this.panel7);
            this.panel16.Location = new System.Drawing.Point(180, 43);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(608, 394);
            this.panel16.TabIndex = 32;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.ForestGreen;
            this.panel5.BackgroundImage = global::FinalProject_Group11.Properties.Resources.total_books;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Controls.Add(this.labelNumBooks);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Location = new System.Drawing.Point(10, 77);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(189, 106);
            this.panel5.TabIndex = 7;
            // 
            // labelNumBooks
            // 
            this.labelNumBooks.AutoSize = true;
            this.labelNumBooks.BackColor = System.Drawing.Color.Transparent;
            this.labelNumBooks.Font = new System.Drawing.Font("Bell Gothic Std Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumBooks.ForeColor = System.Drawing.Color.White;
            this.labelNumBooks.Location = new System.Drawing.Point(-2, 27);
            this.labelNumBooks.Name = "labelNumBooks";
            this.labelNumBooks.Size = new System.Drawing.Size(53, 38);
            this.labelNumBooks.TabIndex = 1;
            this.labelNumBooks.Text = "10";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Bell Gothic Std Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(3, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Total Books";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Goldenrod;
            this.panel6.BackgroundImage = global::FinalProject_Group11.Properties.Resources.borrowed_books;
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel6.Controls.Add(this.lblBorrowedBooks);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Location = new System.Drawing.Point(208, 77);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(189, 106);
            this.panel6.TabIndex = 9;
            // 
            // lblBorrowedBooks
            // 
            this.lblBorrowedBooks.AutoSize = true;
            this.lblBorrowedBooks.BackColor = System.Drawing.Color.Transparent;
            this.lblBorrowedBooks.Font = new System.Drawing.Font("Bell Gothic Std Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBorrowedBooks.ForeColor = System.Drawing.Color.White;
            this.lblBorrowedBooks.Location = new System.Drawing.Point(3, 27);
            this.lblBorrowedBooks.Name = "lblBorrowedBooks";
            this.lblBorrowedBooks.Size = new System.Drawing.Size(53, 38);
            this.lblBorrowedBooks.TabIndex = 3;
            this.lblBorrowedBooks.Text = "10";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Bell Gothic Std Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(8, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 19);
            this.label7.TabIndex = 1;
            this.label7.Text = "Borrowed Books";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.BackgroundImage = global::FinalProject_Group11.Properties.Resources.image_removebg_preview__18_;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Location = new System.Drawing.Point(12, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 59);
            this.pictureBox4.TabIndex = 31;
            this.pictureBox4.TabStop = false;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.DarkRed;
            this.panel7.BackgroundImage = global::FinalProject_Group11.Properties.Resources.penaltycard;
            this.panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel7.Controls.Add(this.labeluserPenalty);
            this.panel7.Controls.Add(this.label8);
            this.panel7.Location = new System.Drawing.Point(403, 77);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(189, 106);
            this.panel7.TabIndex = 8;
            // 
            // labeluserPenalty
            // 
            this.labeluserPenalty.AutoSize = true;
            this.labeluserPenalty.BackColor = System.Drawing.Color.Transparent;
            this.labeluserPenalty.Font = new System.Drawing.Font("Bell Gothic Std Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeluserPenalty.ForeColor = System.Drawing.Color.White;
            this.labeluserPenalty.Location = new System.Drawing.Point(3, 27);
            this.labeluserPenalty.Name = "labeluserPenalty";
            this.labeluserPenalty.Size = new System.Drawing.Size(53, 38);
            this.labeluserPenalty.TabIndex = 2;
            this.labeluserPenalty.Text = "10";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Bell Gothic Std Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(3, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 19);
            this.label8.TabIndex = 2;
            this.label8.Text = "Penalty && Missing";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.BackgroundImage = global::FinalProject_Group11.Properties.Resources.Metallic_MAGNETIC_Dark_Gray_2_oz_Tru_Color_Paint;
            this.panel2.Controls.Add(this.pictureBox5);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lblName);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.buttonDash);
            this.panel2.Controls.Add(this.linkLabel1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(0, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(169, 417);
            this.panel2.TabIndex = 6;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox5.Location = new System.Drawing.Point(15, 33);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(10, 10);
            this.pictureBox5.TabIndex = 15;
            this.pictureBox5.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(17, 174);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(132, 15);
            this.label11.TabIndex = 3;
            this.label11.Text = "Borrowed Books Details\r\n";
            this.label11.Click += new System.EventHandler(this.labelDetails_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.DimGray;
            this.button3.Location = new System.Drawing.Point(-6, 168);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(175, 25);
            this.button3.TabIndex = 10;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.buttonDetails_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel4.BackgroundImage = global::FinalProject_Group11.Properties.Resources._3840x2160_dark_jungle_green_solid_color_background;
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(0, 120);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(169, 24);
            this.panel4.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Manage";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(43, 147);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 15);
            this.label10.TabIndex = 2;
            this.label10.Text = "Book Inventory";
            this.label10.Click += new System.EventHandler(this.labelInventory_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(57, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 15);
            this.label9.TabIndex = 1;
            this.label9.Text = "Dashboard";
            this.label9.Click += new System.EventHandler(this.labelDash_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(28, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Librarian";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(28, 32);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(39, 13);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "Name";
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.DimGray;
            this.button2.Location = new System.Drawing.Point(-6, 142);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 25);
            this.button2.TabIndex = 5;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonInventory_Click);
            // 
            // buttonDash
            // 
            this.buttonDash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonDash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDash.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonDash.Location = new System.Drawing.Point(1, 98);
            this.buttonDash.Name = "buttonDash";
            this.buttonDash.Size = new System.Drawing.Size(168, 22);
            this.buttonDash.TabIndex = 4;
            this.buttonDash.UseVisualStyleBackColor = false;
            this.buttonDash.Click += new System.EventHandler(this.buttonDash_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(57, 393);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(45, 15);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Logout";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLogout_LinkClicked);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel3.BackgroundImage = global::FinalProject_Group11.Properties.Resources._3840x2160_dark_jungle_green_solid_color_background;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(0, 76);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(169, 22);
            this.panel3.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Reports";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.BackgroundImage = global::FinalProject_Group11.Properties.Resources.bcf795aa5abfba7d377e6c122b3f05fd;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1292, 32);
            this.panel1.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Bell Gothic Std Light", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(27, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "URLibrary";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelInventory);
            this.Controls.Add(this.panelBorrowed);
            this.Controls.Add(this.panel16);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.panelInventory.ResumeLayout(false);
            this.panelInventory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panelBorrowed.ResumeLayout(false);
            this.panelBorrowed.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDetails)).EndInit();
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelInventory;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonDash;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelBorrowed;
        private System.Windows.Forms.DataGridView dataGridInventory;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnInventoryDel;
        private System.Windows.Forms.Button BtnInventoryUd;
        private System.Windows.Forms.Button BtnInventoryRead;
        private System.Windows.Forms.Button BtnInventoryCreate;
        private System.Windows.Forms.TextBox textInvSearch;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label labeluserPenalty;
        private System.Windows.Forms.Label lblBorrowedBooks;
        private System.Windows.Forms.Label labelNumBooks;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textDetailSearch;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.DataGridView dataGridDetails;
        private System.Windows.Forms.Button BtnBorrowCreate;
        private System.Windows.Forms.Button BtnBorrowRead;
        private System.Windows.Forms.Button BtnBorrowUD;
        private System.Windows.Forms.Button BtnBorrowDel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Panel panel16;
    }
}