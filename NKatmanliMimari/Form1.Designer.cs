namespace NKatmanliMimari
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxıd = new System.Windows.Forms.TextBox();
            this.Buttonlist = new System.Windows.Forms.Button();
            this.textBoxad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxsoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxmaas = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxgorev = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxsehir = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonadd = new System.Windows.Forms.Button();
            this.buttonsil = new System.Windows.Forms.Button();
            this.buttonupdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 250);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(628, 165);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // textBoxıd
            // 
            this.textBoxıd.Location = new System.Drawing.Point(108, 25);
            this.textBoxıd.Name = "textBoxıd";
            this.textBoxıd.Size = new System.Drawing.Size(100, 30);
            this.textBoxıd.TabIndex = 2;
            // 
            // Buttonlist
            // 
            this.Buttonlist.Location = new System.Drawing.Point(441, 25);
            this.Buttonlist.Name = "Buttonlist";
            this.Buttonlist.Size = new System.Drawing.Size(133, 38);
            this.Buttonlist.TabIndex = 3;
            this.Buttonlist.Text = "Listele";
            this.Buttonlist.UseVisualStyleBackColor = true;
            this.Buttonlist.Click += new System.EventHandler(this.Buttonlist_Click);
            // 
            // textBoxad
            // 
            this.textBoxad.Location = new System.Drawing.Point(108, 73);
            this.textBoxad.Name = "textBoxad";
            this.textBoxad.Size = new System.Drawing.Size(100, 30);
            this.textBoxad.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "AD:";
            // 
            // textBoxsoyad
            // 
            this.textBoxsoyad.Location = new System.Drawing.Point(108, 122);
            this.textBoxsoyad.Name = "textBoxsoyad";
            this.textBoxsoyad.Size = new System.Drawing.Size(100, 30);
            this.textBoxsoyad.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "SOYAD:";
            // 
            // textBoxmaas
            // 
            this.textBoxmaas.Location = new System.Drawing.Point(314, 28);
            this.textBoxmaas.Name = "textBoxmaas";
            this.textBoxmaas.Size = new System.Drawing.Size(100, 30);
            this.textBoxmaas.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(231, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "MAAŞ:";
            // 
            // textBoxgorev
            // 
            this.textBoxgorev.Location = new System.Drawing.Point(314, 73);
            this.textBoxgorev.Name = "textBoxgorev";
            this.textBoxgorev.Size = new System.Drawing.Size(100, 30);
            this.textBoxgorev.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(219, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "GÖREV:";
            // 
            // textBoxsehir
            // 
            this.textBoxsehir.Location = new System.Drawing.Point(314, 122);
            this.textBoxsehir.Name = "textBoxsehir";
            this.textBoxsehir.Size = new System.Drawing.Size(100, 30);
            this.textBoxsehir.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(231, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "ŞEHİR:";
            // 
            // buttonadd
            // 
            this.buttonadd.Location = new System.Drawing.Point(441, 69);
            this.buttonadd.Name = "buttonadd";
            this.buttonadd.Size = new System.Drawing.Size(133, 38);
            this.buttonadd.TabIndex = 14;
            this.buttonadd.Text = "Ekle";
            this.buttonadd.UseVisualStyleBackColor = true;
            this.buttonadd.Click += new System.EventHandler(this.buttonadd_Click);
            // 
            // buttonsil
            // 
            this.buttonsil.Location = new System.Drawing.Point(441, 113);
            this.buttonsil.Name = "buttonsil";
            this.buttonsil.Size = new System.Drawing.Size(133, 38);
            this.buttonsil.TabIndex = 15;
            this.buttonsil.Text = "Sil";
            this.buttonsil.UseVisualStyleBackColor = true;
            this.buttonsil.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonupdate
            // 
            this.buttonupdate.Location = new System.Drawing.Point(441, 157);
            this.buttonupdate.Name = "buttonupdate";
            this.buttonupdate.Size = new System.Drawing.Size(133, 38);
            this.buttonupdate.TabIndex = 16;
            this.buttonupdate.Text = "Güncelle";
            this.buttonupdate.UseVisualStyleBackColor = true;
            this.buttonupdate.Click += new System.EventHandler(this.buttonupdate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 427);
            this.Controls.Add(this.buttonupdate);
            this.Controls.Add(this.buttonsil);
            this.Controls.Add(this.buttonadd);
            this.Controls.Add(this.textBoxsehir);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxgorev);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxmaas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxsoyad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Buttonlist);
            this.Controls.Add(this.textBoxıd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxıd;
        private System.Windows.Forms.Button Buttonlist;
        private System.Windows.Forms.TextBox textBoxad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxsoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxmaas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxgorev;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxsehir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonadd;
        private System.Windows.Forms.Button buttonsil;
        private System.Windows.Forms.Button buttonupdate;
    }
}

