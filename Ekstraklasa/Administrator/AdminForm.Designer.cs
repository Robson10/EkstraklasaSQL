namespace Ekstraklasa.Administrator
{
    partial class AdminForm
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
            this.BtZawodnik = new System.Windows.Forms.Button();
            this.BtDruzyny = new System.Windows.Forms.Button();
            this.myGrid = new System.Windows.Forms.DataGridView();
            this.BtNoweSpotkanie = new System.Windows.Forms.Button();
            this.BtWyniki = new System.Windows.Forms.Button();
            this.BtDodajZawodnika = new System.Windows.Forms.Button();
            this.gridDruzyny = new System.Windows.Forms.DataGridView();
            this.AddRow = new System.Windows.Forms.Button();
            this.BtUsuń = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.myGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDruzyny)).BeginInit();
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
            this.BtSpotkania.Location = new System.Drawing.Point(13, 13);
            this.BtSpotkania.Name = "BtSpotkania";
            this.BtSpotkania.Size = new System.Drawing.Size(100, 23);
            this.BtSpotkania.TabIndex = 2;
            this.BtSpotkania.Text = "Spotkania";
            this.BtSpotkania.UseVisualStyleBackColor = true;
            this.BtSpotkania.Click += new System.EventHandler(this.BtSpotkania_Click);
            // 
            // BtZawodnik
            // 
            this.BtZawodnik.Location = new System.Drawing.Point(14, 75);
            this.BtZawodnik.Name = "BtZawodnik";
            this.BtZawodnik.Size = new System.Drawing.Size(100, 23);
            this.BtZawodnik.TabIndex = 3;
            this.BtZawodnik.Text = "Zawodnicy";
            this.BtZawodnik.UseVisualStyleBackColor = true;
            this.BtZawodnik.Click += new System.EventHandler(this.BtZawodnik_Click);
            // 
            // BtDruzyny
            // 
            this.BtDruzyny.Location = new System.Drawing.Point(13, 134);
            this.BtDruzyny.Name = "BtDruzyny";
            this.BtDruzyny.Size = new System.Drawing.Size(100, 23);
            this.BtDruzyny.TabIndex = 5;
            this.BtDruzyny.Text = "Drużyny";
            this.BtDruzyny.UseVisualStyleBackColor = true;
            this.BtDruzyny.Click += new System.EventHandler(this.BtDruzyny_Click);
            // 
            // myGrid
            // 
            this.myGrid.AllowUserToAddRows = false;
            this.myGrid.AllowUserToDeleteRows = false;
            this.myGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.myGrid.Location = new System.Drawing.Point(120, 43);
            this.myGrid.Name = "myGrid";
            this.myGrid.ReadOnly = true;
            this.myGrid.Size = new System.Drawing.Size(752, 306);
            this.myGrid.TabIndex = 6;
            // 
            // BtNoweSpotkanie
            // 
            this.BtNoweSpotkanie.Location = new System.Drawing.Point(13, 43);
            this.BtNoweSpotkanie.Name = "BtNoweSpotkanie";
            this.BtNoweSpotkanie.Size = new System.Drawing.Size(100, 23);
            this.BtNoweSpotkanie.TabIndex = 7;
            this.BtNoweSpotkanie.Text = "Nowe spotkanie";
            this.BtNoweSpotkanie.UseVisualStyleBackColor = true;
            this.BtNoweSpotkanie.Click += new System.EventHandler(this.BtNoweSpotkanie_Click);
            // 
            // BtWyniki
            // 
            this.BtWyniki.Location = new System.Drawing.Point(14, 163);
            this.BtWyniki.Name = "BtWyniki";
            this.BtWyniki.Size = new System.Drawing.Size(100, 23);
            this.BtWyniki.TabIndex = 8;
            this.BtWyniki.Text = "Wyniki Spotkań";
            this.BtWyniki.UseVisualStyleBackColor = true;
            this.BtWyniki.Click += new System.EventHandler(this.BtWyniki_Click);
            // 
            // BtDodajZawodnika
            // 
            this.BtDodajZawodnika.Location = new System.Drawing.Point(14, 105);
            this.BtDodajZawodnika.Name = "BtDodajZawodnika";
            this.BtDodajZawodnika.Size = new System.Drawing.Size(99, 23);
            this.BtDodajZawodnika.TabIndex = 9;
            this.BtDodajZawodnika.Text = "Dodaj Zawodnika";
            this.BtDodajZawodnika.UseVisualStyleBackColor = true;
            this.BtDodajZawodnika.Click += new System.EventHandler(this.BtDodajZawodnika_Click);
            // 
            // gridDruzyny
            // 
            this.gridDruzyny.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDruzyny.Location = new System.Drawing.Point(120, 41);
            this.gridDruzyny.Name = "gridDruzyny";
            this.gridDruzyny.Size = new System.Drawing.Size(753, 308);
            this.gridDruzyny.TabIndex = 10;
            this.gridDruzyny.Visible = false;
            this.gridDruzyny.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridDruzyny_CellEndEdit);
            // 
            // AddRow
            // 
            this.AddRow.Location = new System.Drawing.Point(120, 12);
            this.AddRow.Name = "AddRow";
            this.AddRow.Size = new System.Drawing.Size(75, 23);
            this.AddRow.TabIndex = 11;
            this.AddRow.Text = "Dodaj wiersz";
            this.AddRow.UseVisualStyleBackColor = true;
            this.AddRow.Click += new System.EventHandler(this.AddRow_Click);
            // 
            // BtUsuń
            // 
            this.BtUsuń.Location = new System.Drawing.Point(202, 11);
            this.BtUsuń.Name = "BtUsuń";
            this.BtUsuń.Size = new System.Drawing.Size(75, 23);
            this.BtUsuń.TabIndex = 12;
            this.BtUsuń.Text = "Usuń wiersz";
            this.BtUsuń.UseVisualStyleBackColor = true;
            this.BtUsuń.Click += new System.EventHandler(this.BtUsuń_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 361);
            this.Controls.Add(this.BtUsuń);
            this.Controls.Add(this.AddRow);
            this.Controls.Add(this.gridDruzyny);
            this.Controls.Add(this.BtDodajZawodnika);
            this.Controls.Add(this.BtWyniki);
            this.Controls.Add(this.BtNoweSpotkanie);
            this.Controls.Add(this.myGrid);
            this.Controls.Add(this.BtDruzyny);
            this.Controls.Add(this.BtZawodnik);
            this.Controls.Add(this.BtSpotkania);
            this.Controls.Add(this.LogOut);
            this.Controls.Add(this.Exit);
            this.MaximumSize = new System.Drawing.Size(900, 620);
            this.MinimumSize = new System.Drawing.Size(900, 400);
            this.Name = "AdminForm";
            this.Text = "Okno Klienta";
            ((System.ComponentModel.ISupportInitialize)(this.myGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDruzyny)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button LogOut;
        private System.Windows.Forms.Button BtSpotkania;
        private System.Windows.Forms.Button BtZawodnik;
        private System.Windows.Forms.Button BtDruzyny;
        private System.Windows.Forms.DataGridView myGrid;
        private System.Windows.Forms.Button BtNoweSpotkanie;
        private System.Windows.Forms.Button BtWyniki;
        private System.Windows.Forms.Button BtDodajZawodnika;
        private System.Windows.Forms.DataGridView gridDruzyny;
        private System.Windows.Forms.Button AddRow;
        private System.Windows.Forms.Button BtUsuń;
    }
}