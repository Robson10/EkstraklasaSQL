namespace Ekstraklasa.Administrator
{
    partial class NoweSpotkanieForm
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
            this.comboBoxDruzynaA = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxDruzynaB = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.BtOk = new System.Windows.Forms.Button();
            this.BtAnuluj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxDruzynaA
            // 
            this.comboBoxDruzynaA.FormattingEnabled = true;
            this.comboBoxDruzynaA.Location = new System.Drawing.Point(75, 12);
            this.comboBoxDruzynaA.Name = "comboBoxDruzynaA";
            this.comboBoxDruzynaA.Size = new System.Drawing.Size(144, 21);
            this.comboBoxDruzynaA.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Druzyna A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Druzyna B";
            // 
            // comboBoxDruzynaB
            // 
            this.comboBoxDruzynaB.FormattingEnabled = true;
            this.comboBoxDruzynaB.Location = new System.Drawing.Point(75, 34);
            this.comboBoxDruzynaB.Name = "comboBoxDruzynaB";
            this.comboBoxDruzynaB.Size = new System.Drawing.Size(144, 21);
            this.comboBoxDruzynaB.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(16, 61);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(203, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // BtOk
            // 
            this.BtOk.Location = new System.Drawing.Point(16, 88);
            this.BtOk.Name = "BtOk";
            this.BtOk.Size = new System.Drawing.Size(75, 23);
            this.BtOk.TabIndex = 5;
            this.BtOk.Text = "Ok";
            this.BtOk.UseVisualStyleBackColor = true;
            this.BtOk.Click += new System.EventHandler(this.BtOk_Click);
            // 
            // BtAnuluj
            // 
            this.BtAnuluj.Location = new System.Drawing.Point(144, 87);
            this.BtAnuluj.Name = "BtAnuluj";
            this.BtAnuluj.Size = new System.Drawing.Size(75, 23);
            this.BtAnuluj.TabIndex = 6;
            this.BtAnuluj.Text = "Anuluj";
            this.BtAnuluj.UseVisualStyleBackColor = true;
            this.BtAnuluj.Click += new System.EventHandler(this.BtAnuluj_Click);
            // 
            // NoweSpotkanieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 122);
            this.Controls.Add(this.BtAnuluj);
            this.Controls.Add(this.BtOk);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBoxDruzynaB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxDruzynaA);
            this.Name = "NoweSpotkanieForm";
            this.Text = "NoweSpotkanieForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxDruzynaA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxDruzynaB;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button BtOk;
        private System.Windows.Forms.Button BtAnuluj;
    }
}