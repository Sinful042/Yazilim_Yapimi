namespace Proje_Ödevi
{
    partial class urn_ist_frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(urn_ist_frm));
            this.cikissatisonay = new System.Windows.Forms.Button();
            this.geri_btnso = new System.Windows.Forms.Button();
            this.satis_label = new System.Windows.Forms.Label();
            this.onay_btnso = new System.Windows.Forms.Button();
            this.onaylama_btnso = new System.Windows.Forms.Button();
            this.dataGridViewSo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSo)).BeginInit();
            this.SuspendLayout();
            // 
            // cikissatisonay
            // 
            this.cikissatisonay.BackColor = System.Drawing.Color.Transparent;
            this.cikissatisonay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cikissatisonay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cikissatisonay.Font = new System.Drawing.Font("Forte", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cikissatisonay.ForeColor = System.Drawing.Color.Brown;
            this.cikissatisonay.Location = new System.Drawing.Point(730, -5);
            this.cikissatisonay.Name = "cikissatisonay";
            this.cikissatisonay.Size = new System.Drawing.Size(32, 36);
            this.cikissatisonay.TabIndex = 10;
            this.cikissatisonay.Text = "X";
            this.cikissatisonay.UseVisualStyleBackColor = false;
            this.cikissatisonay.Click += new System.EventHandler(this.cikissatisonay_Click);
            // 
            // geri_btnso
            // 
            this.geri_btnso.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.geri_btnso.Font = new System.Drawing.Font("Book Antiqua", 14.25F);
            this.geri_btnso.Location = new System.Drawing.Point(616, 325);
            this.geri_btnso.Name = "geri_btnso";
            this.geri_btnso.Size = new System.Drawing.Size(117, 37);
            this.geri_btnso.TabIndex = 11;
            this.geri_btnso.Text = "Geri";
            this.geri_btnso.UseVisualStyleBackColor = false;
            this.geri_btnso.Click += new System.EventHandler(this.geri_btnso_Click);
            // 
            // satis_label
            // 
            this.satis_label.AutoSize = true;
            this.satis_label.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.satis_label.Font = new System.Drawing.Font("Georgia", 15F);
            this.satis_label.Location = new System.Drawing.Point(20, 20);
            this.satis_label.Name = "satis_label";
            this.satis_label.Size = new System.Drawing.Size(143, 24);
            this.satis_label.TabIndex = 12;
            this.satis_label.Text = "Ürün İstekleri;";
            // 
            // onay_btnso
            // 
            this.onay_btnso.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.onay_btnso.Font = new System.Drawing.Font("Book Antiqua", 14.25F);
            this.onay_btnso.Location = new System.Drawing.Point(18, 325);
            this.onay_btnso.Name = "onay_btnso";
            this.onay_btnso.Size = new System.Drawing.Size(117, 37);
            this.onay_btnso.TabIndex = 13;
            this.onay_btnso.Text = "Onayla";
            this.onay_btnso.UseVisualStyleBackColor = false;
            // 
            // onaylama_btnso
            // 
            this.onaylama_btnso.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.onaylama_btnso.Font = new System.Drawing.Font("Book Antiqua", 14.25F);
            this.onaylama_btnso.Location = new System.Drawing.Point(325, 325);
            this.onaylama_btnso.Name = "onaylama_btnso";
            this.onaylama_btnso.Size = new System.Drawing.Size(117, 37);
            this.onaylama_btnso.TabIndex = 14;
            this.onaylama_btnso.Text = "Onaylama";
            this.onaylama_btnso.UseVisualStyleBackColor = false;
            // 
            // dataGridViewSo
            // 
            this.dataGridViewSo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSo.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridViewSo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSo.Location = new System.Drawing.Point(18, 66);
            this.dataGridViewSo.Name = "dataGridViewSo";
            this.dataGridViewSo.Size = new System.Drawing.Size(715, 226);
            this.dataGridViewSo.TabIndex = 15;
            // 
            // urn_ist_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(758, 402);
            this.Controls.Add(this.dataGridViewSo);
            this.Controls.Add(this.onaylama_btnso);
            this.Controls.Add(this.onay_btnso);
            this.Controls.Add(this.satis_label);
            this.Controls.Add(this.geri_btnso);
            this.Controls.Add(this.cikissatisonay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "urn_ist_frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "sts_ist_frm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cikissatisonay;
        private System.Windows.Forms.Button geri_btnso;
        private System.Windows.Forms.Label satis_label;
        private System.Windows.Forms.Button onay_btnso;
        private System.Windows.Forms.Button onaylama_btnso;
        private System.Windows.Forms.DataGridView dataGridViewSo;
    }
}