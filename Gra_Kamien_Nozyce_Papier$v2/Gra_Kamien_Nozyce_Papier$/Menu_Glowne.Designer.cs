namespace Gra_Kamien_Nozyce_Papier_
{
    partial class Menu_Glowne
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_Glowne));
            this.Nazwa_Gry = new System.Windows.Forms.Label();
            this.bStart = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bZasady = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Nazwa_Gry
            // 
            this.Nazwa_Gry.AutoSize = true;
            this.Nazwa_Gry.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Nazwa_Gry.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Nazwa_Gry.Cursor = System.Windows.Forms.Cursors.Default;
            this.Nazwa_Gry.Font = new System.Drawing.Font("MS PGothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Nazwa_Gry.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Nazwa_Gry.Location = new System.Drawing.Point(45, 34);
            this.Nazwa_Gry.MinimumSize = new System.Drawing.Size(520, 70);
            this.Nazwa_Gry.Name = "Nazwa_Gry";
            this.Nazwa_Gry.Padding = new System.Windows.Forms.Padding(6);
            this.Nazwa_Gry.Size = new System.Drawing.Size(537, 70);
            this.Nazwa_Gry.TabIndex = 0;
            this.Nazwa_Gry.Text = "GRA KAMIEŃ - NOŻYCE - PAPIER";
            this.Nazwa_Gry.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bStart
            // 
            this.bStart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bStart.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.bStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bStart.FlatAppearance.BorderColor = System.Drawing.Color.Salmon;
            this.bStart.FlatAppearance.BorderSize = 2;
            this.bStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bStart.ForeColor = System.Drawing.Color.Salmon;
            this.bStart.Location = new System.Drawing.Point(190, 172);
            this.bStart.MinimumSize = new System.Drawing.Size(220, 50);
            this.bStart.Name = "bStart";
            this.bStart.Padding = new System.Windows.Forms.Padding(3);
            this.bStart.Size = new System.Drawing.Size(220, 50);
            this.bStart.TabIndex = 1;
            this.bStart.Text = "START";
            this.bStart.UseVisualStyleBackColor = false;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // button1
            // 
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Salmon;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.Color.Salmon;
            this.button1.Location = new System.Drawing.Point(212, 341);
            this.button1.MinimumSize = new System.Drawing.Size(180, 50);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(3);
            this.button1.Size = new System.Drawing.Size(180, 50);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ustawienia";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.bUstawienia);
            // 
            // button2
            // 
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Salmon;
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.ForeColor = System.Drawing.Color.Salmon;
            this.button2.Location = new System.Drawing.Point(212, 483);
            this.button2.MinimumSize = new System.Drawing.Size(180, 50);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(3);
            this.button2.Size = new System.Drawing.Size(180, 50);
            this.button2.TabIndex = 3;
            this.button2.Text = "WYJŚCIE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.bWyjscie);
            // 
            // bZasady
            // 
            this.bZasady.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bZasady.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.bZasady.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bZasady.FlatAppearance.BorderColor = System.Drawing.Color.Salmon;
            this.bZasady.FlatAppearance.BorderSize = 2;
            this.bZasady.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bZasady.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bZasady.ForeColor = System.Drawing.Color.Salmon;
            this.bZasady.Location = new System.Drawing.Point(212, 257);
            this.bZasady.MinimumSize = new System.Drawing.Size(180, 50);
            this.bZasady.Name = "bZasady";
            this.bZasady.Padding = new System.Windows.Forms.Padding(3);
            this.bZasady.Size = new System.Drawing.Size(180, 50);
            this.bZasady.TabIndex = 4;
            this.bZasady.Text = "Zasady gry";
            this.bZasady.UseVisualStyleBackColor = false;
            this.bZasady.Click += new System.EventHandler(this.bZasady_Click);
            // 
            // Menu_Glowne
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(614, 631);
            this.Controls.Add(this.bZasady);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bStart);
            this.Controls.Add(this.Nazwa_Gry);
            this.MinimumSize = new System.Drawing.Size(630, 670);
            this.Name = "Menu_Glowne";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gra Kamień - Nozyce - Papier";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nazwa_Gry;
        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bZasady;
    }
}

