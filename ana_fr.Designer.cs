namespace Proje_Ödevi
{
    partial class ana_fr
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
            this.kullanici_lbl = new System.Windows.Forms.Label();
            this.para_lbl = new System.Windows.Forms.Label();
            this.satis_btn = new System.Windows.Forms.Button();
            this.ürün_al_btn = new System.Windows.Forms.Button();
            this.para_ekle_btn = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // kullanici_lbl
            // 
            this.kullanici_lbl.AutoSize = true;
            this.kullanici_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullanici_lbl.Location = new System.Drawing.Point(12, 9);
            this.kullanici_lbl.Name = "kullanici_lbl";
            this.kullanici_lbl.Size = new System.Drawing.Size(119, 25);
            this.kullanici_lbl.TabIndex = 0;
            this.kullanici_lbl.Text = "Kullanıcı Adı";
            // 
            // para_lbl
            // 
            this.para_lbl.AutoSize = true;
            this.para_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.para_lbl.Location = new System.Drawing.Point(698, 9);
            this.para_lbl.Name = "para_lbl";
            this.para_lbl.Size = new System.Drawing.Size(53, 25);
            this.para_lbl.TabIndex = 1;
            this.para_lbl.Text = "Para";
            // 
            // satis_btn
            // 
            this.satis_btn.Location = new System.Drawing.Point(56, 338);
            this.satis_btn.Name = "satis_btn";
            this.satis_btn.Size = new System.Drawing.Size(117, 27);
            this.satis_btn.TabIndex = 2;
            this.satis_btn.Text = "Satış Yap";
            this.satis_btn.UseVisualStyleBackColor = true;
            // 
            // ürün_al_btn
            // 
            this.ürün_al_btn.Location = new System.Drawing.Point(240, 338);
            this.ürün_al_btn.Name = "ürün_al_btn";
            this.ürün_al_btn.Size = new System.Drawing.Size(117, 27);
            this.ürün_al_btn.TabIndex = 3;
            this.ürün_al_btn.Text = "Ürün Al";
            this.ürün_al_btn.UseVisualStyleBackColor = true;
            // 
            // para_ekle_btn
            // 
            this.para_ekle_btn.Location = new System.Drawing.Point(424, 338);
            this.para_ekle_btn.Name = "para_ekle_btn";
            this.para_ekle_btn.Size = new System.Drawing.Size(117, 27);
            this.para_ekle_btn.TabIndex = 4;
            this.para_ekle_btn.Text = "Para Ekle";
            this.para_ekle_btn.UseVisualStyleBackColor = true;
            this.para_ekle_btn.Click += new System.EventHandler(this.para_ekle_btn_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(608, 338);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(117, 27);
            this.button4.TabIndex = 5;
            this.button4.Text = "Çıkış Yap";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(699, 236);
            this.dataGridView1.TabIndex = 6;
            // 
            // ana_fr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 444);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.para_ekle_btn);
            this.Controls.Add(this.ürün_al_btn);
            this.Controls.Add(this.satis_btn);
            this.Controls.Add(this.para_lbl);
            this.Controls.Add(this.kullanici_lbl);
            this.Name = "ana_fr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.ana_fr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label kullanici_lbl;
        private System.Windows.Forms.Label para_lbl;
        private System.Windows.Forms.Button satis_btn;
        private System.Windows.Forms.Button ürün_al_btn;
        private System.Windows.Forms.Button para_ekle_btn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}