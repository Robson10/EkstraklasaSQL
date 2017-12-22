namespace Ekstraklasa.Klienci
{
    partial class KlientForm
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
            this.Exit = new System.Windows.Forms.Button();
            this.LogOut = new System.Windows.Forms.Button();
            this.BtSpotkania = new System.Windows.Forms.Button();
            this.BtListaZawodnikow = new System.Windows.Forms.Button();
            this.BtWynikiMeczy = new System.Windows.Forms.Button();
            this.ComboDruzyna = new System.Windows.Forms.ComboBox();
            this.GridResults = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GridResults)).BeginInit();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit.Location = new System.Drawing.Point(797, 12);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 0;
            this.Exit.Text = "Wyjdz";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Close_Click);
            // 
            // LogOut
            // 
            this.LogOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LogOut.Location = new System.Drawing.Point(716, 12);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(75, 23);
            this.LogOut.TabIndex = 1;
            this.LogOut.Text = "Wyloguj";
            this.LogOut.UseVisualStyleBackColor = true;
            this.LogOut.Click += new System.EventHandler(this.Logout_Click);
            // 
            // BtSpotkania
            // 
            this.BtSpotkania.Location = new System.Drawing.Point(12, 12);
            this.BtSpotkania.Name = "BtSpotkania";
            this.BtSpotkania.Size = new System.Drawing.Size(118, 23);
            this.BtSpotkania.TabIndex = 4;
            this.BtSpotkania.Text = "Tabela Spotkań";
            this.BtSpotkania.UseVisualStyleBackColor = true;
            this.BtSpotkania.Click += new System.EventHandler(this.BtSpotkania_Click);
            // 
            // BtListaZawodnikow
            // 
            this.BtListaZawodnikow.Location = new System.Drawing.Point(12, 70);
            this.BtListaZawodnikow.Name = "BtListaZawodnikow";
            this.BtListaZawodnikow.Size = new System.Drawing.Size(118, 23);
            this.BtListaZawodnikow.TabIndex = 5;
            this.BtListaZawodnikow.Text = "Lista Zawodnikow";
            this.BtListaZawodnikow.UseVisualStyleBackColor = true;
            this.BtListaZawodnikow.Click += new System.EventHandler(this.BtListaZawodnikow_Click);
            // 
            // BtWynikiMeczy
            // 
            this.BtWynikiMeczy.Location = new System.Drawing.Point(12, 41);
            this.BtWynikiMeczy.Name = "BtWynikiMeczy";
            this.BtWynikiMeczy.Size = new System.Drawing.Size(118, 23);
            this.BtWynikiMeczy.TabIndex = 6;
            this.BtWynikiMeczy.Text = "Wyniki Meczy";
            this.BtWynikiMeczy.UseVisualStyleBackColor = true;
            this.BtWynikiMeczy.Click += new System.EventHandler(this.BtWynikiMeczy_Click);
            // 
            // ComboDruzyna
            // 
            this.ComboDruzyna.FormattingEnabled = true;
            this.ComboDruzyna.Location = new System.Drawing.Point(13, 100);
            this.ComboDruzyna.Name = "ComboDruzyna";
            this.ComboDruzyna.Size = new System.Drawing.Size(121, 21);
            this.ComboDruzyna.TabIndex = 7;
            this.ComboDruzyna.SelectedIndexChanged += new System.EventHandler(this.ComboDruzyna_SelectedIndexChanged);
            // 
            // GridResults
            // 
            this.GridResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridResults.Location = new System.Drawing.Point(137, 41);
            this.GridResults.Name = "GridResults";
            this.GridResults.Size = new System.Drawing.Size(735, 308);
            this.GridResults.TabIndex = 8;
            // 
            // KlientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 361);
            this.Controls.Add(this.GridResults);
            this.Controls.Add(this.ComboDruzyna);
            this.Controls.Add(this.BtWynikiMeczy);
            this.Controls.Add(this.BtListaZawodnikow);
            this.Controls.Add(this.BtSpotkania);
            this.Controls.Add(this.LogOut);
            this.Controls.Add(this.Exit);
            this.MaximumSize = new System.Drawing.Size(900, 620);
            this.MinimumSize = new System.Drawing.Size(900, 400);
            this.Name = "KlientForm";
            this.Text = "Okno Klienta";
            ((System.ComponentModel.ISupportInitialize)(this.GridResults)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button LogOut;
        private System.Windows.Forms.Button BtSpotkania;
        private System.Windows.Forms.Button BtListaZawodnikow;
        private System.Windows.Forms.Button BtWynikiMeczy;
        private System.Windows.Forms.ComboBox ComboDruzyna;
        private System.Windows.Forms.DataGridView GridResults;
    }
}