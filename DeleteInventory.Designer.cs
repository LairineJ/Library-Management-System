namespace FinalProject_Group11
{
    partial class DeleteInventory
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
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.gridInventoryDel = new System.Windows.Forms.DataGridView();
            this.textDeleteSearch = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.labelDelete = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridInventoryDel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Transparent;
            this.buttonBack.BackgroundImage = global::FinalProject_Group11.Properties.Resources.Loginbutton_removebg_preview;
            this.buttonBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("Bell Gothic Std Black", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonBack.Location = new System.Drawing.Point(11, 414);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(96, 39);
            this.buttonBack.TabIndex = 0;
            this.buttonBack.Text = "BACK";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.Color.Transparent;
            this.buttonDel.BackgroundImage = global::FinalProject_Group11.Properties.Resources.red_button;
            this.buttonDel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDel.Font = new System.Drawing.Font("Bell Gothic Std Black", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDel.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonDel.Location = new System.Drawing.Point(593, 418);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(88, 31);
            this.buttonDel.TabIndex = 1;
            this.buttonDel.Text = "DELETE";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // gridInventoryDel
            // 
            this.gridInventoryDel.AllowUserToAddRows = false;
            this.gridInventoryDel.AllowUserToDeleteRows = false;
            this.gridInventoryDel.AllowUserToOrderColumns = true;
            this.gridInventoryDel.AllowUserToResizeColumns = false;
            this.gridInventoryDel.AllowUserToResizeRows = false;
            this.gridInventoryDel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridInventoryDel.BackgroundColor = System.Drawing.Color.White;
            this.gridInventoryDel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridInventoryDel.Location = new System.Drawing.Point(12, 70);
            this.gridInventoryDel.Name = "gridInventoryDel";
            this.gridInventoryDel.ReadOnly = true;
            this.gridInventoryDel.Size = new System.Drawing.Size(669, 341);
            this.gridInventoryDel.TabIndex = 2;
            // 
            // textDeleteSearch
            // 
            this.textDeleteSearch.Location = new System.Drawing.Point(483, 47);
            this.textDeleteSearch.Name = "textDeleteSearch";
            this.textDeleteSearch.Size = new System.Drawing.Size(198, 20);
            this.textDeleteSearch.TabIndex = 27;
            this.textDeleteSearch.TextChanged += new System.EventHandler(this.textDeleteSearch_TextChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Bell Gothic Std Light", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(435, 49);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(42, 15);
            this.label22.TabIndex = 26;
            this.label22.Text = "Search";
            // 
            // labelDelete
            // 
            this.labelDelete.AutoSize = true;
            this.labelDelete.Font = new System.Drawing.Font("Bell Gothic Std Light", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDelete.Location = new System.Drawing.Point(102, 17);
            this.labelDelete.Name = "labelDelete";
            this.labelDelete.Size = new System.Drawing.Size(210, 33);
            this.labelDelete.TabIndex = 25;
            this.labelDelete.Text = "Delete a Record ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::FinalProject_Group11.Properties.Resources.image_removebg_preview__18_;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 55);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // DeleteInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(693, 458);
            this.Controls.Add(this.labelDelete);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textDeleteSearch);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.gridInventoryDel);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonBack);
            this.Name = "DeleteInventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.DeleteInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridInventoryDel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.DataGridView gridInventoryDel;
        private System.Windows.Forms.TextBox textDeleteSearch;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label labelDelete;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}