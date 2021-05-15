namespace Proje_Ödevi
{
    partial class admin_frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin_frm));
            this.para_list_btn = new System.Windows.Forms.Button();
            this.cikisadmin = new System.Windows.Forms.Button();
            this.cikis_btnadmin = new System.Windows.Forms.Button();
            this.urn_list_btn = new System.Windows.Forms.Button();
            this.dataGridViewSo = new System.Windows.Forms.DataGridView();
            this.admin_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSo)).BeginInit();
            this.SuspendLayout();
            // 
            // para_list_btn
            // 
            this.para_list_btn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.para_list_btn.Font = new System.Drawing.Font("Book Antiqua", 14.25F);
            this.para_list_btn.Location = new System.Drawing.Point(36, 316);
            this.para_list_btn.Name = "para_list_btn";
            this.para_list_btn.Size = new System.Drawing.Size(138, 37);
            this.para_list_btn.TabIndex = 0;
            this.para_list_btn.Text = "Para İstekleri";
            this.para_list_btn.UseVisualStyleBackColor = false;
            this.para_list_btn.Click += new System.EventHandler(this.para_list_btn_Click);
            // 
            // cikisadmin
            // 
            this.cikisadmin.BackColor = System.Drawing.Color.Transparent;
            this.cikisadmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cikisadmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cikisadmin.Font = new System.Drawing.Font("Forte", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cikisadmin.ForeColor = System.Drawing.Color.Brown;
            this.cikisadmin.Location = new System.Drawing.Point(730, -5);
            this.cikisadmin.Name = "cikisadmin";
            this.cikisadmin.Size = new System.Drawing.Size(32, 36);
            this.cikisadmin.TabIndex = 10;
            this.cikisadmin.Text = "X";
            this.cikisadmin.UseVisualStyleBackColor = false;
            this.cikisadmin.Click += new System.EventHandler(this.cikisadmin_Click);
            // 
            // cikis_btnadmin
            // 
            this.cikis_btnadmin.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cikis_btnadmin.Font = new System.Drawing.Font("Book Antiqua", 14.25F);
            this.cikis_btnadmin.Location = new System.Drawing.Point(589, 316);
            this.cikis_btnadmin.Name = "cikis_btnadmin";
            this.cikis_btnadmin.Size = new System.Drawing.Size(117, 37);
            this.cikis_btnadmin.TabIndex = 11;
            this.cikis_btnadmin.Text = "Çıkış";
            this.cikis_btnadmin.UseVisualStyleBackColor = false;
            this.cikis_btnadmin.Click += new System.EventHandler(this.cikis_btnadmin_Click);
            // 
            // urn_list_btn
            // 
            this.urn_list_btn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.urn_list_btn.Font = new System.Drawing.Font("Book Antiqua", 14.25F);
            this.urn_list_btn.Location = new System.Drawing.Point(310, 316);
            this.urn_list_btn.Name = "urn_list_btn";
            this.urn_list_btn.Size = new System.Drawing.Size(138, 37);
            this.urn_list_btn.TabIndex = 12;
            this.urn_list_btn.Text = "Ürün İstekleri";
            this.urn_list_btn.UseVisualStyleBackColor = false;
            this.urn_list_btn.Click += new System.EventHandler(this.sts_list_btn_Click);
            // 
            // dataGridViewSo
            // 
            this.dataGridViewSo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSo.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridViewSo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSo.Location = new System.Drawing.Point(18, 66);
            this.dataGridViewSo.Name = "dataGridViewSo";
            this.dataGridViewSo.Size = new System.Drawing.Size(715, 226);
            this.dataGridViewSo.TabIndex = 16;
            // 
            // admin_lbl
            // 
            this.admin_lbl.AutoSize = true;
            this.admin_lbl.BackColor = System.Drawing.Color.Transparent;
            this.admin_lbl.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_lbl.Location = new System.Drawing.Point(32, 9);
            this.admin_lbl.Name = "admin_lbl";
            this.admin_lbl.Size = new System.Drawing.Size(126, 24);
            this.admin_lbl.TabIndex = 17;
            this.admin_lbl.Text = "Kullanıcı Adı";
            // 
            // admin_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(758, 402);
            this.Controls.Add(this.admin_lbl);
            this.Controls.Add(this.dataGridViewSo);
            this.Controls.Add(this.urn_list_btn);
            this.Controls.Add(this.cikis_btnadmin);
            this.Controls.Add(this.cikisadmin);
            this.Controls.Add(this.para_list_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "admin_frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.admin_frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button para_list_btn;
        private System.Windows.Forms.Button cikisadmin;
        private System.Windows.Forms.Button cikis_btnadmin;
        private System.Windows.Forms.Button urn_list_btn;
        private System.Windows.Forms.DataGridView dataGridViewSo;
        private System.Windows.Forms.Label admin_lbl;
    }
}