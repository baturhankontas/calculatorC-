namespace hesap_makinesi_form_v1
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
            {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.hesapButon = new System.Windows.Forms.Button();
            this.cikarmaButon = new System.Windows.Forms.Button();
            this.carpmaButon = new System.Windows.Forms.Button();
            this.bolmeButon = new System.Windows.Forms.Button();
            this.faktoriyelButon = new System.Windows.Forms.Button();
            this.sonuc2 = new System.Windows.Forms.Label();
            this.sayi1textbox = new System.Windows.Forms.TextBox();
            this.sayi2textbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // hesapButon
            // 
            this.hesapButon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hesapButon.BackgroundImage")));
            this.hesapButon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hesapButon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.hesapButon.Location = new System.Drawing.Point(22, 60);
            this.hesapButon.Name = "hesapButon";
            this.hesapButon.Size = new System.Drawing.Size(33, 32);
            this.hesapButon.TabIndex = 0;
            this.hesapButon.UseVisualStyleBackColor = true;
            this.hesapButon.Click += new System.EventHandler(this.hesapButon_Click);
            // 
            // cikarmaButon
            // 
            this.cikarmaButon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cikarmaButon.BackgroundImage")));
            this.cikarmaButon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cikarmaButon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cikarmaButon.Location = new System.Drawing.Point(61, 60);
            this.cikarmaButon.Name = "cikarmaButon";
            this.cikarmaButon.Size = new System.Drawing.Size(33, 33);
            this.cikarmaButon.TabIndex = 1;
            this.cikarmaButon.UseVisualStyleBackColor = true;
            this.cikarmaButon.Click += new System.EventHandler(this.cikarmaButon_Click);
            // 
            // carpmaButon
            // 
            this.carpmaButon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("carpmaButon.BackgroundImage")));
            this.carpmaButon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.carpmaButon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.carpmaButon.Location = new System.Drawing.Point(100, 60);
            this.carpmaButon.Name = "carpmaButon";
            this.carpmaButon.Size = new System.Drawing.Size(33, 33);
            this.carpmaButon.TabIndex = 2;
            this.carpmaButon.UseVisualStyleBackColor = true;
            this.carpmaButon.Click += new System.EventHandler(this.carpmaButon_Click);
            // 
            // bolmeButon
            // 
            this.bolmeButon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bolmeButon.BackgroundImage")));
            this.bolmeButon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bolmeButon.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bolmeButon.FlatAppearance.BorderSize = 0;
            this.bolmeButon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.bolmeButon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.bolmeButon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bolmeButon.Location = new System.Drawing.Point(139, 60);
            this.bolmeButon.Name = "bolmeButon";
            this.bolmeButon.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.bolmeButon.Size = new System.Drawing.Size(33, 33);
            this.bolmeButon.TabIndex = 3;
            this.bolmeButon.UseVisualStyleBackColor = true;
            this.bolmeButon.Click += new System.EventHandler(this.bolmeButon_Click);
            // 
            // faktoriyelButon
            // 
            this.faktoriyelButon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("faktoriyelButon.BackgroundImage")));
            this.faktoriyelButon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.faktoriyelButon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.faktoriyelButon.Location = new System.Drawing.Point(178, 60);
            this.faktoriyelButon.Name = "faktoriyelButon";
            this.faktoriyelButon.Size = new System.Drawing.Size(33, 33);
            this.faktoriyelButon.TabIndex = 4;
            this.faktoriyelButon.UseVisualStyleBackColor = true;
            this.faktoriyelButon.Click += new System.EventHandler(this.faktoriyelButon_Click);
            // 
            // sonuc2
            // 
            this.sonuc2.AutoSize = true;
            this.sonuc2.Location = new System.Drawing.Point(234, 31);
            this.sonuc2.Name = "sonuc2";
            this.sonuc2.Size = new System.Drawing.Size(36, 13);
            this.sonuc2.TabIndex = 5;
            this.sonuc2.Text = "sonuc";
            this.sonuc2.Visible = false;
            // 
            // sayi1textbox
            // 
            this.sayi1textbox.Location = new System.Drawing.Point(12, 24);
            this.sayi1textbox.Name = "sayi1textbox";
            this.sayi1textbox.Size = new System.Drawing.Size(100, 20);
            this.sayi1textbox.TabIndex = 6;
            // 
            // sayi2textbox
            // 
            this.sayi2textbox.Location = new System.Drawing.Point(118, 24);
            this.sayi2textbox.Name = "sayi2textbox";
            this.sayi2textbox.Size = new System.Drawing.Size(100, 20);
            this.sayi2textbox.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 106);
            this.Controls.Add(this.sayi2textbox);
            this.Controls.Add(this.sayi1textbox);
            this.Controls.Add(this.sonuc2);
            this.Controls.Add(this.faktoriyelButon);
            this.Controls.Add(this.bolmeButon);
            this.Controls.Add(this.carpmaButon);
            this.Controls.Add(this.cikarmaButon);
            this.Controls.Add(this.hesapButon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Hesap Makinesi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button hesapButon;
        private System.Windows.Forms.Button cikarmaButon;
        private System.Windows.Forms.Button carpmaButon;
        private System.Windows.Forms.Button bolmeButon;
        private System.Windows.Forms.Button faktoriyelButon;
        private System.Windows.Forms.Label sonuc2;
        private System.Windows.Forms.TextBox sayi1textbox;
        private System.Windows.Forms.TextBox sayi2textbox;
    }
}

