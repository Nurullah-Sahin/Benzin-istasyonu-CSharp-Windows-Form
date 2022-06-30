namespace proje
{
    partial class frmdepoBilgileri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmdepoBilgileri));
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBenzin95 = new System.Windows.Forms.TextBox();
            this.txtBenzin97 = new System.Windows.Forms.TextBox();
            this.txtDizel = new System.Windows.Forms.TextBox();
            this.txtEurodizel = new System.Windows.Forms.TextBox();
            this.txtLpg = new System.Windows.Forms.TextBox();
            this.btnBenzin95 = new System.Windows.Forms.Button();
            this.btnBenzin97 = new System.Windows.Forms.Button();
            this.btnDizel = new System.Windows.Forms.Button();
            this.btnEurodizel = new System.Windows.Forms.Button();
            this.btnLpg = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(110, 333);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "LPG";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(110, 269);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "EURO DİZEL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 207);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "DİZEL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 143);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "BENZİN  (97)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "BENZİN  (95)";
            // 
            // txtBenzin95
            // 
            this.txtBenzin95.Location = new System.Drawing.Point(279, 73);
            this.txtBenzin95.Name = "txtBenzin95";
            this.txtBenzin95.Size = new System.Drawing.Size(100, 22);
            this.txtBenzin95.TabIndex = 10;
            this.txtBenzin95.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtBenzin97
            // 
            this.txtBenzin97.Location = new System.Drawing.Point(279, 137);
            this.txtBenzin97.Name = "txtBenzin97";
            this.txtBenzin97.Size = new System.Drawing.Size(100, 22);
            this.txtBenzin97.TabIndex = 11;
            this.txtBenzin97.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtDizel
            // 
            this.txtDizel.Location = new System.Drawing.Point(279, 201);
            this.txtDizel.Name = "txtDizel";
            this.txtDizel.Size = new System.Drawing.Size(100, 22);
            this.txtDizel.TabIndex = 12;
            this.txtDizel.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtEurodizel
            // 
            this.txtEurodizel.Location = new System.Drawing.Point(279, 263);
            this.txtEurodizel.Name = "txtEurodizel";
            this.txtEurodizel.Size = new System.Drawing.Size(100, 22);
            this.txtEurodizel.TabIndex = 13;
            this.txtEurodizel.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtLpg
            // 
            this.txtLpg.Location = new System.Drawing.Point(279, 327);
            this.txtLpg.Name = "txtLpg";
            this.txtLpg.Size = new System.Drawing.Size(100, 22);
            this.txtLpg.TabIndex = 14;
            this.txtLpg.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // btnBenzin95
            // 
            this.btnBenzin95.BackColor = System.Drawing.Color.Aqua;
            this.btnBenzin95.Enabled = false;
            this.btnBenzin95.Location = new System.Drawing.Point(432, 72);
            this.btnBenzin95.Name = "btnBenzin95";
            this.btnBenzin95.Size = new System.Drawing.Size(109, 23);
            this.btnBenzin95.TabIndex = 15;
            this.btnBenzin95.Text = "GÜNCELLE";
            this.btnBenzin95.UseVisualStyleBackColor = false;
            this.btnBenzin95.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBenzin97
            // 
            this.btnBenzin97.BackColor = System.Drawing.Color.Aqua;
            this.btnBenzin97.Enabled = false;
            this.btnBenzin97.Location = new System.Drawing.Point(432, 136);
            this.btnBenzin97.Name = "btnBenzin97";
            this.btnBenzin97.Size = new System.Drawing.Size(109, 23);
            this.btnBenzin97.TabIndex = 16;
            this.btnBenzin97.Text = "GÜNCELLE";
            this.btnBenzin97.UseVisualStyleBackColor = false;
            this.btnBenzin97.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDizel
            // 
            this.btnDizel.BackColor = System.Drawing.Color.Aqua;
            this.btnDizel.Enabled = false;
            this.btnDizel.Location = new System.Drawing.Point(432, 200);
            this.btnDizel.Name = "btnDizel";
            this.btnDizel.Size = new System.Drawing.Size(109, 23);
            this.btnDizel.TabIndex = 17;
            this.btnDizel.Text = "GÜNCELLE";
            this.btnDizel.UseVisualStyleBackColor = false;
            this.btnDizel.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnEurodizel
            // 
            this.btnEurodizel.BackColor = System.Drawing.Color.Aqua;
            this.btnEurodizel.Enabled = false;
            this.btnEurodizel.Location = new System.Drawing.Point(432, 262);
            this.btnEurodizel.Name = "btnEurodizel";
            this.btnEurodizel.Size = new System.Drawing.Size(109, 23);
            this.btnEurodizel.TabIndex = 18;
            this.btnEurodizel.Text = "GÜNCELLE";
            this.btnEurodizel.UseVisualStyleBackColor = false;
            this.btnEurodizel.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnLpg
            // 
            this.btnLpg.BackColor = System.Drawing.Color.Aqua;
            this.btnLpg.Enabled = false;
            this.btnLpg.Location = new System.Drawing.Point(432, 326);
            this.btnLpg.Name = "btnLpg";
            this.btnLpg.Size = new System.Drawing.Size(109, 23);
            this.btnLpg.TabIndex = 19;
            this.btnLpg.Text = "GÜNCELLE";
            this.btnLpg.UseVisualStyleBackColor = false;
            this.btnLpg.Click += new System.EventHandler(this.button5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Yellow;
            this.label6.Location = new System.Drawing.Point(131, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(379, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "LÜTFEN AKARYAKITLARI GÜNCEL FİYATINI YAZINIZ";
            // 
            // frmdepoBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(626, 406);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnLpg);
            this.Controls.Add(this.btnEurodizel);
            this.Controls.Add(this.btnDizel);
            this.Controls.Add(this.btnBenzin97);
            this.Controls.Add(this.btnBenzin95);
            this.Controls.Add(this.txtLpg);
            this.Controls.Add(this.txtEurodizel);
            this.Controls.Add(this.txtDizel);
            this.Controls.Add(this.txtBenzin97);
            this.Controls.Add(this.txtBenzin95);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmdepoBilgileri";
            this.Text = "frmdepoBilgileri";
            this.Load += new System.EventHandler(this.frmdepoBilgileri_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBenzin95;
        private System.Windows.Forms.TextBox txtBenzin97;
        private System.Windows.Forms.TextBox txtDizel;
        private System.Windows.Forms.TextBox txtEurodizel;
        private System.Windows.Forms.TextBox txtLpg;
        private System.Windows.Forms.Button btnBenzin95;
        private System.Windows.Forms.Button btnBenzin97;
        private System.Windows.Forms.Button btnDizel;
        private System.Windows.Forms.Button btnEurodizel;
        private System.Windows.Forms.Button btnLpg;
        private System.Windows.Forms.Label label6;
    }
}