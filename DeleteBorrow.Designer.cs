namespace FinalProject_Group11
{
    partial class DeleteBorrow
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textDeleteSearch = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.labelDelete = new System.Windows.Forms.Label();
            this.gridBorrowDel = new System.Windows.Forms.DataGridView();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridBorrowDel)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::FinalProject_Group11.Properties.Resources.image_removebg_preview__18_;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 55);
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // textDeleteSearch
            // 
            this.textDeleteSearch.Location = new System.Drawing.Point(477, 47);
            this.textDeleteSearch.Name = "textDeleteSearch";
            this.textDeleteSearch.Size = new System.Drawing.Size(204, 20);
            this.textDeleteSearch.TabIndex = 34;
            this.textDeleteSearch.TextChanged += new System.EventHandler(this.textDeleteSearch_TextChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Bell Gothic Std Light", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(429, 49);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(42, 15);
            this.label22.TabIndex = 33;
            this.label22.Text = "Search";
            // 
            // labelDelete
            // 
            this.labelDelete.AutoSize = true;
            this.labelDelete.Font = new System.Drawing.Font("Bell Gothic Std Light", 20.25F, System.Drawing.FontStyle.Bold);
            this.labelDelete.Location = new System.Drawing.Point(102, 22);
            this.labelDelete.Name = "labelDelete";
            this.labelDelete.Size = new System.Drawing.Size(303, 33);
            this.labelDelete.TabIndex = 32;
            this.labelDelete.Text = "Delete a Borrow Record ";
            // 
            // gridBorrowDel
            // 
            this.gridBorrowDel.AllowUserToAddRows = false;
            this.gridBorrowDel.AllowUserToDeleteRows = false;
            this.gridBorrowDel.AllowUserToOrderColumns = true;
            this.gridBorrowDel.AllowUserToResizeColumns = false;
            this.gridBorrowDel.AllowUserToResizeRows = false;
            this.gridBorrowDel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridBorrowDel.BackgroundColor = System.Drawing.Color.White;
            this.gridBorrowDel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridBorrowDel.Location = new System.Drawing.Point(12, 70);
            this.gridBorrowDel.Name = "gridBorrowDel";
            this.gridBorrowDel.ReadOnly = true;
            this.gridBorrowDel.Size = new System.Drawing.Size(669, 341);
            this.gridBorrowDel.TabIndex = 31;
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.Color.Transparent;
            this.buttonDel.BackgroundImage = global::FinalProject_Group11.Properties.Resources.red_button;
            this.buttonDel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDel.Font = new System.Drawing.Font("Bell Gothic Std Black", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDel.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonDel.Location = new System.Drawing.Point(593, 415);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(88, 31);
            this.buttonDel.TabIndex = 30;
            this.buttonDel.Text = "DELETE";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Transparent;
            this.buttonBack.BackgroundImage = global::FinalProject_Group11.Properties.Resources.Loginbutton_removebg_preview;
            this.buttonBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("Bell Gothic Std Black", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonBack.Location = new System.Drawing.Point(12, 411);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(96, 39);
            this.buttonBack.TabIndex = 29;
            this.buttonBack.Text = "BACK";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // DeleteBorrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(693, 458);
            this.Controls.Add(this.labelDelete);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textDeleteSearch);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.gridBorrowDel);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonBack);
            this.Name = "DeleteBorrow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.DeleteBorrow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridBorrowDel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textDeleteSearch;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label labelDelete;
        private System.Windows.Forms.DataGridView gridBorrowDel;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonBack;
    }
}