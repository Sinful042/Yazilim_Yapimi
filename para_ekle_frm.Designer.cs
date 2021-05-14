namespace Proje_Ödevi
{
    partial class para_ekle_frm
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
            this.label1 = new System.Windows.Forms.Label();
            this.istek_para = new System.Windows.Forms.TextBox();
            this.ekle_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(13, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kaç para Eklemek İstiyorsunuz?";
            // 
            // istek_para
            // 
            this.istek_para.Location = new System.Drawing.Point(46, 137);
            this.istek_para.Name = "istek_para";
            this.istek_para.Size = new System.Drawing.Size(175, 20);
            this.istek_para.TabIndex = 3;
            // 
            // ekle_btn
            // 
            this.ekle_btn.Location = new System.Drawing.Point(58, 221);
            this.ekle_btn.Name = "ekle_btn";
            this.ekle_btn.Size = new System.Drawing.Size(147, 37);
            this.ekle_btn.TabIndex = 4;
            this.ekle_btn.Text = "Para Ekle";
            this.ekle_btn.UseVisualStyleBackColor = true;
            this.ekle_btn.Click += new System.EventHandler(this.ekle_btn_Click);
            // 
            // para_ekle_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 329);
            this.Controls.Add(this.ekle_btn);
            this.Controls.Add(this.istek_para);
            this.Controls.Add(this.label1);
            this.Name = "para_ekle_frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Para Ekle";
            this.Load += new System.EventHandler(this.para_ekle_frm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox istek_para;
        private System.Windows.Forms.Button ekle_btn;
    }
}