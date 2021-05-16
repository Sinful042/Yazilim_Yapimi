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
            this.satis_btn = new System.Windows.Forms.Button();
            this.cikis_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // para_list_btn
            // 
            this.para_list_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.para_list_btn.Location = new System.Drawing.Point(85, 321);
            this.para_list_btn.Name = "para_list_btn";
            this.para_list_btn.Size = new System.Drawing.Size(124, 35);
            this.para_list_btn.TabIndex = 0;
            this.para_list_btn.Text = "Para İstekleri";
            this.para_list_btn.UseVisualStyleBackColor = true;
            this.para_list_btn.Click += new System.EventHandler(this.para_list_btn_Click);
            // 
            // satis_btn
            // 
            this.satis_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.satis_btn.Location = new System.Drawing.Point(325, 321);
            this.satis_btn.Name = "satis_btn";
            this.satis_btn.Size = new System.Drawing.Size(124, 35);
            this.satis_btn.TabIndex = 1;
            this.satis_btn.Text = "Şatış İstekleri";
            this.satis_btn.UseVisualStyleBackColor = true;
            this.satis_btn.Click += new System.EventHandler(this.satis_btn_Click);
            // 
            // cikis_btn
            // 
            this.cikis_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cikis_btn.Location = new System.Drawing.Point(565, 321);
            this.cikis_btn.Name = "cikis_btn";
            this.cikis_btn.Size = new System.Drawing.Size(124, 35);
            this.cikis_btn.TabIndex = 2;
            this.cikis_btn.Text = "Çıkış Yap";
            this.cikis_btn.UseVisualStyleBackColor = true;
            this.cikis_btn.Click += new System.EventHandler(this.cikis_btn_Click);
            // 
            // admin_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 450);
            this.Controls.Add(this.cikis_btn);
            this.Controls.Add(this.satis_btn);
            this.Controls.Add(this.para_list_btn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "admin_frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.admin_frm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button para_list_btn;
        private System.Windows.Forms.Button satis_btn;
        private System.Windows.Forms.Button cikis_btn;
    }
}