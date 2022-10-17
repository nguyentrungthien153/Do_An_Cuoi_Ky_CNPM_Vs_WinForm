namespace DXApplication1
{
    partial class OptionGUIcs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionGUIcs));
            this.label1 = new System.Windows.Forms.Label();
            this.llblSignOut = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCategory = new System.Windows.Forms.Label();
            this.picCategory = new System.Windows.Forms.PictureBox();
            this.picHome = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Các Tùy Chọn:";
            // 
            // llblSignOut
            // 
            this.llblSignOut.AutoSize = true;
            this.llblSignOut.DisabledLinkColor = System.Drawing.Color.Silver;
            this.llblSignOut.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblSignOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.llblSignOut.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.llblSignOut.Location = new System.Drawing.Point(760, 9);
            this.llblSignOut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.llblSignOut.Name = "llblSignOut";
            this.llblSignOut.Size = new System.Drawing.Size(96, 21);
            this.llblSignOut.TabIndex = 6;
            this.llblSignOut.TabStop = true;
            this.llblSignOut.Text = "Đăng Xuất";
            this.llblSignOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblSignOut_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(162, 395);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Giao diện chính";
            // 
            // txtCategory
            // 
            this.txtCategory.AutoSize = true;
            this.txtCategory.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategory.ForeColor = System.Drawing.Color.Blue;
            this.txtCategory.Location = new System.Drawing.Point(535, 395);
            this.txtCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(146, 21);
            this.txtCategory.TabIndex = 4;
            this.txtCategory.Text = "Quản lý danh mục";
            // 
            // picCategory
            // 
            this.picCategory.Image = global::DXApplication1.Properties.Resources.categories;
            this.picCategory.Location = new System.Drawing.Point(482, 173);
            this.picCategory.Margin = new System.Windows.Forms.Padding(4);
            this.picCategory.Name = "picCategory";
            this.picCategory.Size = new System.Drawing.Size(244, 193);
            this.picCategory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCategory.TabIndex = 8;
            this.picCategory.TabStop = false;
            this.picCategory.Click += new System.EventHandler(this.picCategory_Click);
            // 
            // picHome
            // 
            this.picHome.Image = global::DXApplication1.Properties.Resources.homepage;
            this.picHome.Location = new System.Drawing.Point(107, 173);
            this.picHome.Margin = new System.Windows.Forms.Padding(4);
            this.picHome.Name = "picHome";
            this.picHome.Size = new System.Drawing.Size(245, 197);
            this.picHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHome.TabIndex = 7;
            this.picHome.TabStop = false;
            this.picHome.Click += new System.EventHandler(this.picHome_Click);
            // 
            // OptionGUIcs
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 490);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.picCategory);
            this.Controls.Add(this.picHome);
            this.Controls.Add(this.llblSignOut);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("OptionGUIcs.IconOptions.LargeImage")));
            this.Name = "OptionGUIcs";
            this.Text = "Giao Diện Các Tùy Chọn";
            ((System.ComponentModel.ISupportInitialize)(this.picCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel llblSignOut;
        private System.Windows.Forms.PictureBox picHome;
        private System.Windows.Forms.PictureBox picCategory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txtCategory;
    }
}