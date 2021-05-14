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
            this.para_list_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // para_list_btn
            // 
            this.para_list_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.para_list_btn.Location = new System.Drawing.Point(34, 322);
            this.para_list_btn.Name = "para_list_btn";
            this.para_list_btn.Size = new System.Drawing.Size(124, 35);
            this.para_list_btn.TabIndex = 0;
            this.para_list_btn.Text = "Para İstekleri";
            this.para_list_btn.UseVisualStyleBackColor = true;
            this.para_list_btn.Click += new System.EventHandler(this.para_list_btn_Click);
            // 
            // admin_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.para_list_btn);
            this.Name = "admin_frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Sayfa";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button para_list_btn;
    }
}