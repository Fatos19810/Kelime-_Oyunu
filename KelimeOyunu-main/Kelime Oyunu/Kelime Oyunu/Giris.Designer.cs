
namespace Kelime_Oyunu
{
    partial class Giris
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
            this.txt_username = new System.Windows.Forms.TextBox();
            this.btn_basla = new System.Windows.Forms.Button();
            this.btn_soru_ekle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_username
            // 
            this.txt_username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(229)))), ((int)(((byte)(248)))));
            this.txt_username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_username.Location = new System.Drawing.Point(313, 244);
            this.txt_username.Multiline = true;
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(341, 58);
            this.txt_username.TabIndex = 2;
            this.txt_username.TextChanged += new System.EventHandler(this.txt_username_TextChanged);
            // 
            // btn_basla
            // 
            this.btn_basla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(229)))), ((int)(((byte)(248)))));
            this.btn_basla.FlatAppearance.BorderSize = 0;
            this.btn_basla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_basla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_basla.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(69)))), ((int)(((byte)(116)))));
            this.btn_basla.Location = new System.Drawing.Point(390, 338);
            this.btn_basla.Name = "btn_basla";
            this.btn_basla.Size = new System.Drawing.Size(185, 61);
            this.btn_basla.TabIndex = 3;
            this.btn_basla.Text = "START";
            this.btn_basla.UseVisualStyleBackColor = false;
            this.btn_basla.Click += new System.EventHandler(this.btn_basla_Click);
            this.btn_basla.MouseHover += new System.EventHandler(this.btn_basla_MouseHover);
            // 
            // btn_soru_ekle
            // 
            this.btn_soru_ekle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(229)))), ((int)(((byte)(248)))));
            this.btn_soru_ekle.FlatAppearance.BorderSize = 0;
            this.btn_soru_ekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_soru_ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_soru_ekle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(69)))), ((int)(((byte)(116)))));
            this.btn_soru_ekle.Location = new System.Drawing.Point(390, 405);
            this.btn_soru_ekle.Name = "btn_soru_ekle";
            this.btn_soru_ekle.Size = new System.Drawing.Size(185, 56);
            this.btn_soru_ekle.TabIndex = 4;
            this.btn_soru_ekle.Text = "SORU EKLE";
            this.btn_soru_ekle.UseVisualStyleBackColor = false;
            this.btn_soru_ekle.Click += new System.EventHandler(this.btn_soru_ekle_Click);
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Kelime_Oyunu.Properties.Resources.Giris1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1022, 637);
            this.Controls.Add(this.btn_soru_ekle);
            this.Controls.Add(this.btn_basla);
            this.Controls.Add(this.txt_username);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(69)))), ((int)(((byte)(116)))));
            this.Name = "Giris";
            this.Text = "Giris";
            this.Load += new System.EventHandler(this.Giris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Button btn_basla;
        private System.Windows.Forms.Button btn_soru_ekle;
    }
}