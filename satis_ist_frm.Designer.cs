﻿namespace Proje_Ödevi
{
    partial class satis_ist_frm
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
            this.onay_btn = new System.Windows.Forms.Button();
            this.onaylama_btn = new System.Windows.Forms.Button();
            this.cikis_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.admin_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // onay_btn
            // 
            this.onay_btn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.onay_btn.Font = new System.Drawing.Font("Book Antiqua", 14.25F);
            this.onay_btn.Location = new System.Drawing.Point(47, 327);
            this.onay_btn.Name = "onay_btn";
            this.onay_btn.Size = new System.Drawing.Size(117, 37);
            this.onay_btn.TabIndex = 9;
            this.onay_btn.Text = "Onayla";
            this.onay_btn.UseVisualStyleBackColor = false;
            this.onay_btn.Click += new System.EventHandler(this.onay_btn_Click);
            // 
            // onaylama_btn
            // 
            this.onaylama_btn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.onaylama_btn.Font = new System.Drawing.Font("Book Antiqua", 14.25F);
            this.onaylama_btn.Location = new System.Drawing.Point(354, 327);
            this.onaylama_btn.Name = "onaylama_btn";
            this.onaylama_btn.Size = new System.Drawing.Size(117, 37);
            this.onaylama_btn.TabIndex = 8;
            this.onaylama_btn.Text = "Onaylama";
            this.onaylama_btn.UseVisualStyleBackColor = false;
            this.onaylama_btn.Click += new System.EventHandler(this.onaylama_btn_Click);
            // 
            // cikis_btn
            // 
            this.cikis_btn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cikis_btn.Font = new System.Drawing.Font("Book Antiqua", 14.25F);
            this.cikis_btn.Location = new System.Drawing.Point(645, 327);
            this.cikis_btn.Name = "cikis_btn";
            this.cikis_btn.Size = new System.Drawing.Size(117, 37);
            this.cikis_btn.TabIndex = 7;
            this.cikis_btn.Text = "Geri";
            this.cikis_btn.UseVisualStyleBackColor = false;
            this.cikis_btn.Click += new System.EventHandler(this.cikis_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(554, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 22);
            this.label1.TabIndex = 13;
            this.label1.Text = "Filtre:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(47, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(715, 226);
            this.dataGridView1.TabIndex = 12;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Onaylanan Kullanıclar",
            "Onaylanmayan Kullanıcılar",
            "Onay Bekleyen Kullanıcılar"});
            this.comboBox1.Location = new System.Drawing.Point(612, 16);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(142, 21);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // admin_label
            // 
            this.admin_label.AutoSize = true;
            this.admin_label.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.admin_label.Font = new System.Drawing.Font("Georgia", 15F);
            this.admin_label.Location = new System.Drawing.Point(49, 16);
            this.admin_label.Name = "admin_label";
            this.admin_label.Size = new System.Drawing.Size(139, 24);
            this.admin_label.TabIndex = 10;
            this.admin_label.Text = "Şatış İstekleri:";
            // 
            // satis_ist_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 412);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.admin_label);
            this.Controls.Add(this.onay_btn);
            this.Controls.Add(this.onaylama_btn);
            this.Controls.Add(this.cikis_btn);
            this.Name = "satis_ist_frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satış İstekleri";
            this.Load += new System.EventHandler(this.satis_ist_frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button onay_btn;
        private System.Windows.Forms.Button onaylama_btn;
        private System.Windows.Forms.Button cikis_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label admin_label;
    }
}