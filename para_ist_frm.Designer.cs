namespace Proje_Ödevi
{
    partial class para_ist_frm
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
            this.admin_label = new System.Windows.Forms.Label();
            this.cikis_btn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.onaylama_btn = new System.Windows.Forms.Button();
            this.onay_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // admin_label
            // 
            this.admin_label.AutoSize = true;
            this.admin_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.admin_label.Location = new System.Drawing.Point(14, 20);
            this.admin_label.Name = "admin_label";
            this.admin_label.Size = new System.Drawing.Size(241, 22);
            this.admin_label.TabIndex = 0;
            this.admin_label.Text = "Onay Bekleyen Para İstekleri";
            // 
            // cikis_btn
            // 
            this.cikis_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cikis_btn.Location = new System.Drawing.Point(559, 325);
            this.cikis_btn.Name = "cikis_btn";
            this.cikis_btn.Size = new System.Drawing.Size(127, 34);
            this.cikis_btn.TabIndex = 3;
            this.cikis_btn.Text = "Çıkış Yap";
            this.cikis_btn.UseVisualStyleBackColor = true;
            this.cikis_btn.Click += new System.EventHandler(this.cikis_btn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Onaylanan Kullanıclar",
            "Onaylanmayan Kullanıcılar",
            "Onay Bekleyen Kullanıcılar"});
            this.comboBox1.Location = new System.Drawing.Point(544, 20);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(142, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // onaylama_btn
            // 
            this.onaylama_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.onaylama_btn.Location = new System.Drawing.Point(291, 325);
            this.onaylama_btn.Name = "onaylama_btn";
            this.onaylama_btn.Size = new System.Drawing.Size(127, 34);
            this.onaylama_btn.TabIndex = 5;
            this.onaylama_btn.Text = "Onaylama";
            this.onaylama_btn.UseVisualStyleBackColor = true;
            this.onaylama_btn.Click += new System.EventHandler(this.onaylama_btn_Click);
            // 
            // onay_btn
            // 
            this.onay_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.onay_btn.Location = new System.Drawing.Point(18, 325);
            this.onay_btn.Name = "onay_btn";
            this.onay_btn.Size = new System.Drawing.Size(127, 34);
            this.onay_btn.TabIndex = 6;
            this.onay_btn.Text = "Onayla";
            this.onay_btn.UseVisualStyleBackColor = true;
            this.onay_btn.Click += new System.EventHandler(this.onay_btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Indigo;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(667, 226);
            this.dataGridView1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(479, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "Filitre:";
            // 
            // para_ist_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 383);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.onay_btn);
            this.Controls.Add(this.onaylama_btn);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.cikis_btn);
            this.Controls.Add(this.admin_label);
            this.Name = "para_ist_frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Para İstekleri";
            this.Load += new System.EventHandler(this.admin_frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label admin_label;
        private System.Windows.Forms.Button cikis_btn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button onaylama_btn;
        private System.Windows.Forms.Button onay_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
    }
}