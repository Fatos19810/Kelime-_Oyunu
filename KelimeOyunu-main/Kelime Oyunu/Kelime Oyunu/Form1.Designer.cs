﻿
namespace Kelime_Oyunu
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_harfal = new System.Windows.Forms.Button();
            this.btn_cevapla = new System.Windows.Forms.Button();
            this.txt_soru = new System.Windows.Forms.TextBox();
            this.txt_harf1 = new System.Windows.Forms.TextBox();
            this.txt_harf2 = new System.Windows.Forms.TextBox();
            this.txt_harf3 = new System.Windows.Forms.TextBox();
            this.txt_harf4 = new System.Windows.Forms.TextBox();
            this.txt_harf5 = new System.Windows.Forms.TextBox();
            this.txt_harf6 = new System.Windows.Forms.TextBox();
            this.txt_harf7 = new System.Windows.Forms.TextBox();
            this.txt_harf8 = new System.Windows.Forms.TextBox();
            this.txt_harf9 = new System.Windows.Forms.TextBox();
            this.txt_harf10 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_soruSay = new System.Windows.Forms.Label();
            this.lbl_puan = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_dk = new System.Windows.Forms.Label();
            this.lbl_sn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lbl_cvpsure = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btn_harfal
            // 
            this.btn_harfal.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_harfal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(229)))), ((int)(((byte)(248)))));
            this.btn_harfal.FlatAppearance.BorderSize = 0;
            this.btn_harfal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_harfal.Font = new System.Drawing.Font("MV Boli", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_harfal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(73)))), ((int)(((byte)(224)))));
            this.btn_harfal.Location = new System.Drawing.Point(457, 448);
            this.btn_harfal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_harfal.Name = "btn_harfal";
            this.btn_harfal.Size = new System.Drawing.Size(212, 67);
            this.btn_harfal.TabIndex = 0;
            this.btn_harfal.Text = "HARF ALAYIM";
            this.btn_harfal.UseVisualStyleBackColor = false;
            this.btn_harfal.Click += new System.EventHandler(this.btn_harfal_Click);
            // 
            // btn_cevapla
            // 
            this.btn_cevapla.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_cevapla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(229)))), ((int)(((byte)(248)))));
            this.btn_cevapla.Enabled = false;
            this.btn_cevapla.FlatAppearance.BorderSize = 0;
            this.btn_cevapla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cevapla.Font = new System.Drawing.Font("MV Boli", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cevapla.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(73)))), ((int)(((byte)(224)))));
            this.btn_cevapla.Location = new System.Drawing.Point(457, 519);
            this.btn_cevapla.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_cevapla.Name = "btn_cevapla";
            this.btn_cevapla.Size = new System.Drawing.Size(212, 61);
            this.btn_cevapla.TabIndex = 1;
            this.btn_cevapla.Text = "CEVAPLA";
            this.btn_cevapla.UseVisualStyleBackColor = false;
            this.btn_cevapla.Click += new System.EventHandler(this.btn_cevapla_Click);
            // 
            // txt_soru
            // 
            this.txt_soru.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(229)))), ((int)(((byte)(248)))));
            this.txt_soru.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_soru.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(73)))), ((int)(((byte)(224)))));
            this.txt_soru.Location = new System.Drawing.Point(209, 205);
            this.txt_soru.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_soru.Multiline = true;
            this.txt_soru.Name = "txt_soru";
            this.txt_soru.ReadOnly = true;
            this.txt_soru.Size = new System.Drawing.Size(771, 239);
            this.txt_soru.TabIndex = 3;
            this.txt_soru.Text = "Kuzey Amerika’ya özgü, kafası tilkiye benzeyen, uzun kuyruğu alaca halkalı olan k" +
    "ürklü hayvan";
            this.txt_soru.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_soru.TextChanged += new System.EventHandler(this.txt_soru_TextChanged);
            // 
            // txt_harf1
            // 
            this.txt_harf1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(229)))), ((int)(((byte)(248)))));
            this.txt_harf1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_harf1.Location = new System.Drawing.Point(75, 157);
            this.txt_harf1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_harf1.MaxLength = 1;
            this.txt_harf1.Multiline = true;
            this.txt_harf1.Name = "txt_harf1";
            this.txt_harf1.Size = new System.Drawing.Size(100, 35);
            this.txt_harf1.TabIndex = 4;
            this.txt_harf1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_harf2
            // 
            this.txt_harf2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(229)))), ((int)(((byte)(248)))));
            this.txt_harf2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_harf2.Location = new System.Drawing.Point(181, 157);
            this.txt_harf2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_harf2.MaxLength = 1;
            this.txt_harf2.Multiline = true;
            this.txt_harf2.Name = "txt_harf2";
            this.txt_harf2.Size = new System.Drawing.Size(100, 35);
            this.txt_harf2.TabIndex = 5;
            this.txt_harf2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_harf3
            // 
            this.txt_harf3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(229)))), ((int)(((byte)(248)))));
            this.txt_harf3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_harf3.Location = new System.Drawing.Point(287, 157);
            this.txt_harf3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_harf3.MaxLength = 1;
            this.txt_harf3.Multiline = true;
            this.txt_harf3.Name = "txt_harf3";
            this.txt_harf3.Size = new System.Drawing.Size(100, 35);
            this.txt_harf3.TabIndex = 6;
            this.txt_harf3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_harf4
            // 
            this.txt_harf4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(229)))), ((int)(((byte)(248)))));
            this.txt_harf4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_harf4.Location = new System.Drawing.Point(393, 157);
            this.txt_harf4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_harf4.MaxLength = 1;
            this.txt_harf4.Multiline = true;
            this.txt_harf4.Name = "txt_harf4";
            this.txt_harf4.Size = new System.Drawing.Size(100, 35);
            this.txt_harf4.TabIndex = 7;
            this.txt_harf4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_harf5
            // 
            this.txt_harf5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(229)))), ((int)(((byte)(248)))));
            this.txt_harf5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_harf5.Location = new System.Drawing.Point(499, 157);
            this.txt_harf5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_harf5.MaxLength = 1;
            this.txt_harf5.Multiline = true;
            this.txt_harf5.Name = "txt_harf5";
            this.txt_harf5.Size = new System.Drawing.Size(100, 35);
            this.txt_harf5.TabIndex = 8;
            this.txt_harf5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_harf6
            // 
            this.txt_harf6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(229)))), ((int)(((byte)(248)))));
            this.txt_harf6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_harf6.Location = new System.Drawing.Point(605, 157);
            this.txt_harf6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_harf6.MaxLength = 1;
            this.txt_harf6.Multiline = true;
            this.txt_harf6.Name = "txt_harf6";
            this.txt_harf6.Size = new System.Drawing.Size(100, 35);
            this.txt_harf6.TabIndex = 9;
            this.txt_harf6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_harf7
            // 
            this.txt_harf7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(229)))), ((int)(((byte)(248)))));
            this.txt_harf7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_harf7.Location = new System.Drawing.Point(711, 157);
            this.txt_harf7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_harf7.MaxLength = 1;
            this.txt_harf7.Multiline = true;
            this.txt_harf7.Name = "txt_harf7";
            this.txt_harf7.Size = new System.Drawing.Size(100, 35);
            this.txt_harf7.TabIndex = 10;
            this.txt_harf7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_harf8
            // 
            this.txt_harf8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(229)))), ((int)(((byte)(248)))));
            this.txt_harf8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_harf8.Location = new System.Drawing.Point(819, 157);
            this.txt_harf8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_harf8.MaxLength = 1;
            this.txt_harf8.Multiline = true;
            this.txt_harf8.Name = "txt_harf8";
            this.txt_harf8.Size = new System.Drawing.Size(100, 35);
            this.txt_harf8.TabIndex = 11;
            this.txt_harf8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_harf9
            // 
            this.txt_harf9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(229)))), ((int)(((byte)(248)))));
            this.txt_harf9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_harf9.Location = new System.Drawing.Point(925, 157);
            this.txt_harf9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_harf9.MaxLength = 1;
            this.txt_harf9.Multiline = true;
            this.txt_harf9.Name = "txt_harf9";
            this.txt_harf9.Size = new System.Drawing.Size(100, 35);
            this.txt_harf9.TabIndex = 12;
            this.txt_harf9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_harf10
            // 
            this.txt_harf10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(229)))), ((int)(((byte)(248)))));
            this.txt_harf10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_harf10.Location = new System.Drawing.Point(1031, 157);
            this.txt_harf10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_harf10.MaxLength = 1;
            this.txt_harf10.Multiline = true;
            this.txt_harf10.Name = "txt_harf10";
            this.txt_harf10.Size = new System.Drawing.Size(100, 35);
            this.txt_harf10.TabIndex = 13;
            this.txt_harf10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(229)))), ((int)(((byte)(248)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("MV Boli", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(73)))), ((int)(((byte)(224)))));
            this.button1.Location = new System.Drawing.Point(457, 584);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 71);
            this.button1.TabIndex = 14;
            this.button1.Text = "DURDUR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_soruSay
            // 
            this.txt_soruSay.AutoSize = true;
            this.txt_soruSay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_soruSay.Location = new System.Drawing.Point(13, 14);
            this.txt_soruSay.Name = "txt_soruSay";
            this.txt_soruSay.Size = new System.Drawing.Size(64, 20);
            this.txt_soruSay.TabIndex = 15;
            this.txt_soruSay.Text = "Soru 1";
            // 
            // lbl_puan
            // 
            this.lbl_puan.AutoSize = true;
            this.lbl_puan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(229)))), ((int)(((byte)(248)))));
            this.lbl_puan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_puan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(73)))), ((int)(((byte)(224)))));
            this.lbl_puan.Location = new System.Drawing.Point(857, 64);
            this.lbl_puan.Name = "lbl_puan";
            this.lbl_puan.Size = new System.Drawing.Size(27, 24);
            this.lbl_puan.TabIndex = 16;
            this.lbl_puan.Text = " 0";
            this.lbl_puan.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lbl_puan.Click += new System.EventHandler(this.lbl_puan_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_dk
            // 
            this.lbl_dk.AutoSize = true;
            this.lbl_dk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(227)))), ((int)(((byte)(240)))));
            this.lbl_dk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_dk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(73)))), ((int)(((byte)(224)))));
            this.lbl_dk.Location = new System.Drawing.Point(921, 66);
            this.lbl_dk.Name = "lbl_dk";
            this.lbl_dk.Size = new System.Drawing.Size(29, 20);
            this.lbl_dk.TabIndex = 17;
            this.lbl_dk.Text = "04";
            // 
            // lbl_sn
            // 
            this.lbl_sn.AutoSize = true;
            this.lbl_sn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(227)))), ((int)(((byte)(240)))));
            this.lbl_sn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(73)))), ((int)(((byte)(224)))));
            this.lbl_sn.Location = new System.Drawing.Point(977, 68);
            this.lbl_sn.Name = "lbl_sn";
            this.lbl_sn.Size = new System.Drawing.Size(29, 20);
            this.lbl_sn.TabIndex = 18;
            this.lbl_sn.Text = "00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(227)))), ((int)(((byte)(240)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(73)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(956, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = ":";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // lbl_cvpsure
            // 
            this.lbl_cvpsure.AutoSize = true;
            this.lbl_cvpsure.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(229)))), ((int)(((byte)(248)))));
            this.lbl_cvpsure.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_cvpsure.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(73)))), ((int)(((byte)(224)))));
            this.lbl_cvpsure.Location = new System.Drawing.Point(13, 544);
            this.lbl_cvpsure.Name = "lbl_cvpsure";
            this.lbl_cvpsure.Size = new System.Drawing.Size(32, 24);
            this.lbl_cvpsure.TabIndex = 20;
            this.lbl_cvpsure.Text = "20";
            this.lbl_cvpsure.Visible = false;
            // 
            // lbl_username
            // 
            this.lbl_username.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_username.Location = new System.Drawing.Point(910, 756);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(51, 20);
            this.lbl_username.TabIndex = 21;
            this.lbl_username.Text = "fatos";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.BackgroundImage = global::Kelime_Oyunu.Properties.Resources.Soru_ekranı;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 785);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.lbl_cvpsure);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_sn);
            this.Controls.Add(this.lbl_dk);
            this.Controls.Add(this.lbl_puan);
            this.Controls.Add(this.txt_soruSay);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_harf10);
            this.Controls.Add(this.txt_harf9);
            this.Controls.Add(this.txt_harf8);
            this.Controls.Add(this.txt_harf7);
            this.Controls.Add(this.txt_harf6);
            this.Controls.Add(this.txt_harf5);
            this.Controls.Add(this.txt_harf4);
            this.Controls.Add(this.txt_harf3);
            this.Controls.Add(this.txt_harf2);
            this.Controls.Add(this.txt_harf1);
            this.Controls.Add(this.txt_soru);
            this.Controls.Add(this.btn_cevapla);
            this.Controls.Add(this.btn_harfal);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_harfal;
        private System.Windows.Forms.Button btn_cevapla;
        private System.Windows.Forms.TextBox txt_soru;
        private System.Windows.Forms.TextBox txt_harf1;
        private System.Windows.Forms.TextBox txt_harf2;
        private System.Windows.Forms.TextBox txt_harf3;
        private System.Windows.Forms.TextBox txt_harf4;
        private System.Windows.Forms.TextBox txt_harf5;
        private System.Windows.Forms.TextBox txt_harf6;
        private System.Windows.Forms.TextBox txt_harf7;
        private System.Windows.Forms.TextBox txt_harf8;
        private System.Windows.Forms.TextBox txt_harf9;
        private System.Windows.Forms.TextBox txt_harf10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label txt_soruSay;
        private System.Windows.Forms.Label lbl_puan;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_dk;
        private System.Windows.Forms.Label lbl_sn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lbl_cvpsure;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

