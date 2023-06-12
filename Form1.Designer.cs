namespace Oyun
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.oyuncu = new System.Windows.Forms.PictureBox();
            this.solTimer2 = new System.Windows.Forms.Timer(this.components);
            this.sagTimer3 = new System.Windows.Forms.Timer(this.components);
            this.asagiTimer4 = new System.Windows.Forms.Timer(this.components);
            this.yukariTimer5 = new System.Windows.Forms.Timer(this.components);
            this.mermiTimer2 = new System.Windows.Forms.Timer(this.components);
            this.dusmanTimer2 = new System.Windows.Forms.Timer(this.components);
            this.dusmanMermiTimer2 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.cikisButton1 = new System.Windows.Forms.Button();
            this.baslatButton2 = new System.Windows.Forms.Button();
            this.puanLabel2 = new System.Windows.Forms.Label();
            this.levelLabel2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.oyuncu)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // oyuncu
            // 
            this.oyuncu.BackColor = System.Drawing.Color.Transparent;
            this.oyuncu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.oyuncu.Image = ((System.Drawing.Image)(resources.GetObject("oyuncu.Image")));
            this.oyuncu.Location = new System.Drawing.Point(272, 381);
            this.oyuncu.Name = "oyuncu";
            this.oyuncu.Size = new System.Drawing.Size(42, 60);
            this.oyuncu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.oyuncu.TabIndex = 0;
            this.oyuncu.TabStop = false;
            // 
            // solTimer2
            // 
            this.solTimer2.Interval = 5;
            this.solTimer2.Tick += new System.EventHandler(this.solTimer2_Tick);
            // 
            // sagTimer3
            // 
            this.sagTimer3.Interval = 5;
            this.sagTimer3.Tick += new System.EventHandler(this.sagTimer3_Tick);
            // 
            // asagiTimer4
            // 
            this.asagiTimer4.Interval = 5;
            this.asagiTimer4.Tick += new System.EventHandler(this.asagiTimer4_Tick);
            // 
            // yukariTimer5
            // 
            this.yukariTimer5.Interval = 5;
            this.yukariTimer5.Tick += new System.EventHandler(this.yukariTimer5_Tick);
            // 
            // mermiTimer2
            // 
            this.mermiTimer2.Enabled = true;
            this.mermiTimer2.Interval = 20;
            this.mermiTimer2.Tick += new System.EventHandler(this.mermiTimer2_Tick);
            // 
            // dusmanTimer2
            // 
            this.dusmanTimer2.Enabled = true;
            this.dusmanTimer2.Tick += new System.EventHandler(this.dusmanTimer2_Tick);
            // 
            // dusmanMermiTimer2
            // 
            this.dusmanMermiTimer2.Enabled = true;
            this.dusmanMermiTimer2.Interval = 20;
            this.dusmanMermiTimer2.Tick += new System.EventHandler(this.dusmanMermiTimer2_Tick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("MV Boli", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(558, 87);
            this.label1.TabIndex = 1;
            this.label1.Text = "Label 1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Visible = false;
            // 
            // cikisButton1
            // 
            this.cikisButton1.BackColor = System.Drawing.Color.Red;
            this.cikisButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cikisButton1.ForeColor = System.Drawing.Color.Black;
            this.cikisButton1.Location = new System.Drawing.Point(227, 309);
            this.cikisButton1.Name = "cikisButton1";
            this.cikisButton1.Size = new System.Drawing.Size(144, 41);
            this.cikisButton1.TabIndex = 2;
            this.cikisButton1.Text = "ÇIKIŞ";
            this.cikisButton1.UseVisualStyleBackColor = false;
            this.cikisButton1.Visible = false;
            this.cikisButton1.Click += new System.EventHandler(this.cikisButton1_Click);
            // 
            // baslatButton2
            // 
            this.baslatButton2.BackColor = System.Drawing.Color.Red;
            this.baslatButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.baslatButton2.ForeColor = System.Drawing.Color.Black;
            this.baslatButton2.Location = new System.Drawing.Point(227, 231);
            this.baslatButton2.Name = "baslatButton2";
            this.baslatButton2.Size = new System.Drawing.Size(144, 41);
            this.baslatButton2.TabIndex = 3;
            this.baslatButton2.Text = "BAŞLAT";
            this.baslatButton2.UseVisualStyleBackColor = false;
            this.baslatButton2.Visible = false;
            this.baslatButton2.Click += new System.EventHandler(this.baslatButton2_Click);
            // 
            // puanLabel2
            // 
            this.puanLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.puanLabel2.ForeColor = System.Drawing.Color.DarkOrange;
            this.puanLabel2.Location = new System.Drawing.Point(3, 9);
            this.puanLabel2.Name = "puanLabel2";
            this.puanLabel2.Size = new System.Drawing.Size(163, 26);
            this.puanLabel2.TabIndex = 4;
            this.puanLabel2.Text = "Puan: 0";
            // 
            // levelLabel2
            // 
            this.levelLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.levelLabel2.ForeColor = System.Drawing.Color.DarkOrange;
            this.levelLabel2.Location = new System.Drawing.Point(475, 9);
            this.levelLabel2.Name = "levelLabel2";
            this.levelLabel2.Size = new System.Drawing.Size(103, 26);
            this.levelLabel2.TabIndex = 5;
            this.levelLabel2.Text = "Level:1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(582, 453);
            this.Controls.Add(this.baslatButton2);
            this.Controls.Add(this.cikisButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.oyuncu);
            this.Controls.Add(this.puanLabel2);
            this.Controls.Add(this.levelLabel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.oyuncu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox oyuncu;
        private System.Windows.Forms.Timer solTimer2;
        private System.Windows.Forms.Timer sagTimer3;
        private System.Windows.Forms.Timer asagiTimer4;
        private System.Windows.Forms.Timer yukariTimer5;
        private System.Windows.Forms.Timer mermiTimer2;
        private System.Windows.Forms.Timer dusmanTimer2;
        private System.Windows.Forms.Timer dusmanMermiTimer2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cikisButton1;
        private System.Windows.Forms.Button baslatButton2;
        private System.Windows.Forms.Label puanLabel2;
        private System.Windows.Forms.Label levelLabel2;
    }
}

