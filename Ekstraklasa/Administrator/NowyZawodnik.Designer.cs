namespace Ekstraklasa.Administrator
{
    partial class NowyZawodnik
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TbImie = new System.Windows.Forms.TextBox();
            this.TbNazwisko = new System.Windows.Forms.TextBox();
            this.TbPozycja = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtOk = new System.Windows.Forms.Button();
            this.BtAnuluj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(102, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(170, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Druzyna";
            // 
            // TbImie
            // 
            this.TbImie.Location = new System.Drawing.Point(102, 40);
            this.TbImie.Name = "TbImie";
            this.TbImie.Size = new System.Drawing.Size(170, 20);
            this.TbImie.TabIndex = 2;
            // 
            // TbNazwisko
            // 
            this.TbNazwisko.Location = new System.Drawing.Point(102, 66);
            this.TbNazwisko.Name = "TbNazwisko";
            this.TbNazwisko.Size = new System.Drawing.Size(170, 20);
            this.TbNazwisko.TabIndex = 3;
            // 
            // TbPozycja
            // 
            this.TbPozycja.Location = new System.Drawing.Point(102, 92);
            this.TbPozycja.Name = "TbPozycja";
            this.TbPozycja.Size = new System.Drawing.Size(170, 20);
            this.TbPozycja.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Imie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nazwisko";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Pozycja";
            // 
            // BtOk
            // 
            this.BtOk.Location = new System.Drawing.Point(13, 131);
            this.BtOk.Name = "BtOk";
            this.BtOk.Size = new System.Drawing.Size(75, 23);
            this.BtOk.TabIndex = 8;
            this.BtOk.Text = "Ok";
            this.BtOk.UseVisualStyleBackColor = true;
            this.BtOk.Click += new System.EventHandler(this.BtOk_Click);
            // 
            // BtAnuluj
            // 
            this.BtAnuluj.Location = new System.Drawing.Point(197, 131);
            this.BtAnuluj.Name = "BtAnuluj";
            this.BtAnuluj.Size = new System.Drawing.Size(75, 23);
            this.BtAnuluj.TabIndex = 9;
            this.BtAnuluj.Text = "Anuluj";
            this.BtAnuluj.UseVisualStyleBackColor = true;
            this.BtAnuluj.Click += new System.EventHandler(this.BtAnuluj_Click);
            // 
            // NowyZawodnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 166);
            this.Controls.Add(this.BtAnuluj);
            this.Controls.Add(this.BtOk);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TbPozycja);
            this.Controls.Add(this.TbNazwisko);
            this.Controls.Add(this.TbImie);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "NowyZawodnik";
            this.Text = "NowyZawodnik";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbImie;
        private System.Windows.Forms.TextBox TbNazwisko;
        private System.Windows.Forms.TextBox TbPozycja;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtOk;
        private System.Windows.Forms.Button BtAnuluj;
    }
}