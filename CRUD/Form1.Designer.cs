namespace CRUD
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.InserisciProd = new System.Windows.Forms.Label();
            this.ListaProd = new System.Windows.Forms.ListBox();
            this.Aggiungi = new System.Windows.Forms.Button();
            this.ListaProdLabel = new System.Windows.Forms.Label();
            this.prezzo = new System.Windows.Forms.TextBox();
            this.InserisciPrez = new System.Windows.Forms.Label();
            this.prodotto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // InserisciProd
            // 
            this.InserisciProd.AutoSize = true;
            this.InserisciProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InserisciProd.Location = new System.Drawing.Point(12, 6);
            this.InserisciProd.Name = "InserisciProd";
            this.InserisciProd.Size = new System.Drawing.Size(110, 13);
            this.InserisciProd.TabIndex = 0;
            this.InserisciProd.Text = "Inserisci Prodotto:";
            // 
            // ListaProd
            // 
            this.ListaProd.FormattingEnabled = true;
            this.ListaProd.Location = new System.Drawing.Point(641, 22);
            this.ListaProd.Name = "ListaProd";
            this.ListaProd.Size = new System.Drawing.Size(147, 420);
            this.ListaProd.TabIndex = 2;
            // 
            // Aggiungi
            // 
            this.Aggiungi.Location = new System.Drawing.Point(188, 22);
            this.Aggiungi.Name = "Aggiungi";
            this.Aggiungi.Size = new System.Drawing.Size(95, 59);
            this.Aggiungi.TabIndex = 3;
            this.Aggiungi.Text = "Aggiungi alla Lista";
            this.Aggiungi.UseVisualStyleBackColor = true;
            this.Aggiungi.Click += new System.EventHandler(this.Aggiungi_Click);
            // 
            // ListaProdLabel
            // 
            this.ListaProdLabel.AutoSize = true;
            this.ListaProdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaProdLabel.Location = new System.Drawing.Point(638, 6);
            this.ListaProdLabel.Name = "ListaProdLabel";
            this.ListaProdLabel.Size = new System.Drawing.Size(86, 13);
            this.ListaProdLabel.TabIndex = 4;
            this.ListaProdLabel.Text = "Lista Prodotti:";
            // 
            // prezzo
            // 
            this.prezzo.Location = new System.Drawing.Point(12, 61);
            this.prezzo.Name = "prezzo";
            this.prezzo.Size = new System.Drawing.Size(170, 20);
            this.prezzo.TabIndex = 5;
            // 
            // InserisciPrez
            // 
            this.InserisciPrez.AutoSize = true;
            this.InserisciPrez.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InserisciPrez.Location = new System.Drawing.Point(12, 45);
            this.InserisciPrez.Name = "InserisciPrez";
            this.InserisciPrez.Size = new System.Drawing.Size(100, 13);
            this.InserisciPrez.TabIndex = 6;
            this.InserisciPrez.Text = "Inserisci Prezzo:";
            // 
            // prodotto
            // 
            this.prodotto.Location = new System.Drawing.Point(12, 22);
            this.prodotto.Name = "prodotto";
            this.prodotto.Size = new System.Drawing.Size(170, 20);
            this.prodotto.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.prodotto);
            this.Controls.Add(this.InserisciPrez);
            this.Controls.Add(this.prezzo);
            this.Controls.Add(this.ListaProdLabel);
            this.Controls.Add(this.Aggiungi);
            this.Controls.Add(this.ListaProd);
            this.Controls.Add(this.InserisciProd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InserisciProd;
        private System.Windows.Forms.ListBox ListaProd;
        private System.Windows.Forms.Button Aggiungi;
        private System.Windows.Forms.Label ListaProdLabel;
        private System.Windows.Forms.TextBox prezzo;
        private System.Windows.Forms.Label InserisciPrez;
        private System.Windows.Forms.TextBox prodotto;
    }
}

