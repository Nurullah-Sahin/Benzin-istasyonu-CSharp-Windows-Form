namespace proje
{
    partial class frmGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGiris));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lnklblKulOlustur = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKulGirSifre = new System.Windows.Forms.TextBox();
            this.txtKulGirAdmin = new System.Windows.Forms.TextBox();
            this.btnGiris = new System.Windows.Forms.Button();
            this.btniptal = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btniptal);
            this.panel1.Controls.Add(this.lnklblKulOlustur);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtKulGirSifre);
            this.panel1.Controls.Add(this.txtKulGirAdmin);
            this.panel1.Controls.Add(this.btnGiris);
            this.panel1.Location = new System.Drawing.Point(53, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(414, 245);
            this.panel1.TabIndex = 1;
            // 
            // lnklblKulOlustur
            // 
            this.lnklblKulOlustur.AutoSize = true;
            this.lnklblKulOlustur.Location = new System.Drawing.Point(90, 214);
            this.lnklblKulOlustur.Name = "lnklblKulOlustur";
            this.lnklblKulOlustur.Size = new System.Drawing.Size(217, 13);
            this.lnklblKulOlustur.TabIndex = 9;
            this.lnklblKulOlustur.TabStop = true;
            this.lnklblKulOlustur.Text = "YENİ KULLANICI ADI VE ŞİFRE OLUŞTUR";
            this.lnklblKulOlustur.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblKulOlustur_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(36, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "KULLANICI ADI;";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(81, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "ŞİFRE;";
            // 
            // txtKulGirSifre
            // 
            this.txtKulGirSifre.Location = new System.Drawing.Point(153, 90);
            this.txtKulGirSifre.Name = "txtKulGirSifre";
            this.txtKulGirSifre.PasswordChar = '*';
            this.txtKulGirSifre.Size = new System.Drawing.Size(100, 20);
            this.txtKulGirSifre.TabIndex = 4;
            // 
            // txtKulGirAdmin
            // 
            this.txtKulGirAdmin.Location = new System.Drawing.Point(153, 33);
            this.txtKulGirAdmin.Name = "txtKulGirAdmin";
            this.txtKulGirAdmin.Size = new System.Drawing.Size(100, 20);
            this.txtKulGirAdmin.TabIndex = 1;
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.Color.White;
            this.btnGiris.Image = ((System.Drawing.Image)(resources.GetObject("btnGiris.Image")));
            this.btnGiris.Location = new System.Drawing.Point(242, 129);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(83, 72);
            this.btnGiris.TabIndex = 0;
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // btniptal
            // 
            this.btniptal.Image = ((System.Drawing.Image)(resources.GetObject("btniptal.Image")));
            this.btniptal.Location = new System.Drawing.Point(84, 129);
            this.btniptal.Name = "btniptal";
            this.btniptal.Size = new System.Drawing.Size(80, 72);
            this.btniptal.TabIndex = 10;
            this.btniptal.UseVisualStyleBackColor = true;
            this.btniptal.Click += new System.EventHandler(this.btniptal_Click);
            // 
            // frmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(527, 385);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGiris";
            this.Text = "Giriş";
            this.Load += new System.EventHandler(this.frmGiris_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKulGirAdmin;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.LinkLabel lnklblKulOlustur;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKulGirSifre;
        private System.Windows.Forms.Button btniptal;

    }
}

