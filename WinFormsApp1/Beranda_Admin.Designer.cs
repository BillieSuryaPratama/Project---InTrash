﻿namespace WinFormsApp1
{
    partial class Beranda_Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Beranda_Admin));
            btnJemputSampah = new Button();
            btnProfil = new Button();
            btnReward = new Button();
            btnRiwayatTransaksi = new Button();
            label1 = new Label();
            btnEditSampah = new Button();
            btnDaftarkanKurir = new Button();
            btnEditKurir = new Button();
            btnLogOut = new Button();
            btnHapusAkun = new Button();
            SuspendLayout();
            // 
            // btnJemputSampah
            // 
            btnJemputSampah.Image = (Image)resources.GetObject("btnJemputSampah.Image");
            btnJemputSampah.Location = new Point(154, 222);
            btnJemputSampah.Margin = new Padding(2);
            btnJemputSampah.Name = "btnJemputSampah";
            btnJemputSampah.Size = new Size(142, 40);
            btnJemputSampah.TabIndex = 9;
            btnJemputSampah.Text = "Jemput Sampah";
            btnJemputSampah.UseVisualStyleBackColor = true;
            // 
            // btnProfil
            // 
            btnProfil.ForeColor = Color.Black;
            btnProfil.Image = (Image)resources.GetObject("btnProfil.Image");
            btnProfil.Location = new Point(154, 133);
            btnProfil.Margin = new Padding(2);
            btnProfil.Name = "btnProfil";
            btnProfil.Size = new Size(142, 37);
            btnProfil.TabIndex = 8;
            btnProfil.Text = "Profil";
            btnProfil.UseVisualStyleBackColor = true;
            // 
            // btnReward
            // 
            btnReward.Image = (Image)resources.GetObject("btnReward.Image");
            btnReward.Location = new Point(154, 177);
            btnReward.Margin = new Padding(2);
            btnReward.Name = "btnReward";
            btnReward.Size = new Size(142, 39);
            btnReward.TabIndex = 7;
            btnReward.Text = "Reward";
            btnReward.UseVisualStyleBackColor = true;
            // 
            // btnRiwayatTransaksi
            // 
            btnRiwayatTransaksi.Image = (Image)resources.GetObject("btnRiwayatTransaksi.Image");
            btnRiwayatTransaksi.Location = new Point(154, 268);
            btnRiwayatTransaksi.Margin = new Padding(2);
            btnRiwayatTransaksi.Name = "btnRiwayatTransaksi";
            btnRiwayatTransaksi.Size = new Size(142, 40);
            btnRiwayatTransaksi.TabIndex = 6;
            btnRiwayatTransaksi.Text = "Riwayat Transaksi";
            btnRiwayatTransaksi.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.Location = new Point(167, 23);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(300, 74);
            label1.TabIndex = 5;
            label1.Text = "Beranda";
            // 
            // btnEditSampah
            // 
            btnEditSampah.Image = (Image)resources.GetObject("btnEditSampah.Image");
            btnEditSampah.Location = new Point(337, 222);
            btnEditSampah.Name = "btnEditSampah";
            btnEditSampah.Size = new Size(142, 41);
            btnEditSampah.TabIndex = 10;
            btnEditSampah.Text = "Edit Data Sampah";
            btnEditSampah.UseVisualStyleBackColor = true;
            // 
            // btnDaftarkanKurir
            // 
            btnDaftarkanKurir.Image = (Image)resources.GetObject("btnDaftarkanKurir.Image");
            btnDaftarkanKurir.Location = new Point(337, 131);
            btnDaftarkanKurir.Name = "btnDaftarkanKurir";
            btnDaftarkanKurir.Size = new Size(142, 39);
            btnDaftarkanKurir.TabIndex = 11;
            btnDaftarkanKurir.Text = "Daftarkan Kurir";
            btnDaftarkanKurir.UseVisualStyleBackColor = true;
            // 
            // btnEditKurir
            // 
            btnEditKurir.BackColor = SystemColors.ControlDarkDark;
            btnEditKurir.Image = (Image)resources.GetObject("btnEditKurir.Image");
            btnEditKurir.Location = new Point(337, 176);
            btnEditKurir.Name = "btnEditKurir";
            btnEditKurir.Size = new Size(142, 40);
            btnEditKurir.TabIndex = 12;
            btnEditKurir.Text = "Edit Data Kurir";
            btnEditKurir.UseVisualStyleBackColor = false;
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.Red;
            btnLogOut.ForeColor = Color.White;
            btnLogOut.Location = new Point(29, 319);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(94, 29);
            btnLogOut.TabIndex = 13;
            btnLogOut.Text = "Log out";
            btnLogOut.UseVisualStyleBackColor = false;
            // 
            // btnHapusAkun
            // 
            btnHapusAkun.Image = (Image)resources.GetObject("btnHapusAkun.Image");
            btnHapusAkun.Location = new Point(337, 268);
            btnHapusAkun.Name = "btnHapusAkun";
            btnHapusAkun.Size = new Size(142, 40);
            btnHapusAkun.TabIndex = 14;
            btnHapusAkun.Text = "Hapus Akun";
            btnHapusAkun.UseVisualStyleBackColor = true;
            // 
            // Beranda_Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(640, 360);
            Controls.Add(btnHapusAkun);
            Controls.Add(btnLogOut);
            Controls.Add(btnEditKurir);
            Controls.Add(btnDaftarkanKurir);
            Controls.Add(btnEditSampah);
            Controls.Add(btnJemputSampah);
            Controls.Add(btnProfil);
            Controls.Add(btnReward);
            Controls.Add(btnRiwayatTransaksi);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "Beranda_Admin";
            Text = "InTrash";
            Load += Form15_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnJemputSampah;
        private Button btnProfil;
        private Button btnReward;
        private Button btnRiwayatTransaksi;
        private Label label1;
        private Button btnEditSampah;
        private Button btnDaftarkanKurir;
        private Button btnEditKurir;
        private Button btnLogOut;
        private Button btnHapusAkun;
    }
}