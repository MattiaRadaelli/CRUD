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
            this.visualizza = new System.Windows.Forms.Button();
            this.Ricerca = new System.Windows.Forms.Label();
            this.modifica = new System.Windows.Forms.TextBox();
            this.costomodific = new System.Windows.Forms.TextBox();
            this.prodmodificato = new System.Windows.Forms.TextBox();
            this.nomemodific = new System.Windows.Forms.Label();
            this.prezzomodific = new System.Windows.Forms.Label();
            this.modificabut = new System.Windows.Forms.Button();
            this.cercabut = new System.Windows.Forms.Button();
            this.Cancella = new System.Windows.Forms.Button();
            this.prodcanc = new System.Windows.Forms.Label();
            this.testocanc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // InserisciProd
            // 
            this.InserisciProd.AutoSize = true;
            this.InserisciProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InserisciProd.Location = new System.Drawing.Point(9, 6);
            this.InserisciProd.Name = "InserisciProd";
            this.InserisciProd.Size = new System.Drawing.Size(110, 13);
            this.InserisciProd.TabIndex = 0;
            this.InserisciProd.Text = "Inserisci Prodotto:";
            // 
            // ListaProd
            // 
            this.ListaProd.FormattingEnabled = true;
            this.ListaProd.Location = new System.Drawing.Point(389, 22);
            this.ListaProd.Name = "ListaProd";
            this.ListaProd.Size = new System.Drawing.Size(399, 420);
            this.ListaProd.TabIndex = 2;
            // 
            // Aggiungi
            // 
            this.Aggiungi.Location = new System.Drawing.Point(203, 18);
            this.Aggiungi.Name = "Aggiungi";
            this.Aggiungi.Size = new System.Drawing.Size(180, 27);
            this.Aggiungi.TabIndex = 3;
            this.Aggiungi.Text = "Aggiungi alla Lista";
            this.Aggiungi.UseVisualStyleBackColor = true;
            this.Aggiungi.Click += new System.EventHandler(this.Aggiungi_Click);
            // 
            // ListaProdLabel
            // 
            this.ListaProdLabel.AutoSize = true;
            this.ListaProdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaProdLabel.Location = new System.Drawing.Point(386, 6);
            this.ListaProdLabel.Name = "ListaProdLabel";
            this.ListaProdLabel.Size = new System.Drawing.Size(86, 13);
            this.ListaProdLabel.TabIndex = 4;
            this.ListaProdLabel.Text = "Lista Prodotti:";
            // 
            // prezzo
            // 
            this.prezzo.Location = new System.Drawing.Point(12, 61);
            this.prezzo.Name = "prezzo";
            this.prezzo.Size = new System.Drawing.Size(185, 20);
            this.prezzo.TabIndex = 5;
            // 
            // InserisciPrez
            // 
            this.InserisciPrez.AutoSize = true;
            this.InserisciPrez.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InserisciPrez.Location = new System.Drawing.Point(9, 45);
            this.InserisciPrez.Name = "InserisciPrez";
            this.InserisciPrez.Size = new System.Drawing.Size(100, 13);
            this.InserisciPrez.TabIndex = 6;
            this.InserisciPrez.Text = "Inserisci Prezzo:";
            // 
            // prodotto
            // 
            this.prodotto.Location = new System.Drawing.Point(12, 22);
            this.prodotto.Name = "prodotto";
            this.prodotto.Size = new System.Drawing.Size(185, 20);
            this.prodotto.TabIndex = 7;
            // 
            // visualizza
            // 
            this.visualizza.Location = new System.Drawing.Point(203, 57);
            this.visualizza.Name = "visualizza";
            this.visualizza.Size = new System.Drawing.Size(180, 27);
            this.visualizza.TabIndex = 8;
            this.visualizza.Text = "Visualizza la Lista";
            this.visualizza.UseVisualStyleBackColor = true;
            this.visualizza.Click += new System.EventHandler(this.visualizza_Click);
            // 
            // Ricerca
            // 
            this.Ricerca.AutoSize = true;
            this.Ricerca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ricerca.Location = new System.Drawing.Point(9, 84);
            this.Ricerca.Name = "Ricerca";
            this.Ricerca.Size = new System.Drawing.Size(140, 13);
            this.Ricerca.TabIndex = 9;
            this.Ricerca.Text = "Prodotto da Modificare:";
            // 
            // modifica
            // 
            this.modifica.Location = new System.Drawing.Point(12, 100);
            this.modifica.Name = "modifica";
            this.modifica.Size = new System.Drawing.Size(185, 20);
            this.modifica.TabIndex = 10;
            // 
            // costomodific
            // 
            this.costomodific.Location = new System.Drawing.Point(153, 142);
            this.costomodific.Name = "costomodific";
            this.costomodific.Size = new System.Drawing.Size(44, 20);
            this.costomodific.TabIndex = 11;
            // 
            // prodmodificato
            // 
            this.prodmodificato.Location = new System.Drawing.Point(12, 142);
            this.prodmodificato.Name = "prodmodificato";
            this.prodmodificato.Size = new System.Drawing.Size(137, 20);
            this.prodmodificato.TabIndex = 12;
            // 
            // nomemodific
            // 
            this.nomemodific.AutoSize = true;
            this.nomemodific.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomemodific.Location = new System.Drawing.Point(9, 123);
            this.nomemodific.Name = "nomemodific";
            this.nomemodific.Size = new System.Drawing.Size(59, 13);
            this.nomemodific.TabIndex = 13;
            this.nomemodific.Text = "Prodotto:";
            // 
            // prezzomodific
            // 
            this.prezzomodific.AutoSize = true;
            this.prezzomodific.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prezzomodific.Location = new System.Drawing.Point(150, 123);
            this.prezzomodific.Name = "prezzomodific";
            this.prezzomodific.Size = new System.Drawing.Size(49, 13);
            this.prezzomodific.TabIndex = 14;
            this.prezzomodific.Text = "Prezzo:";
            // 
            // modificabut
            // 
            this.modificabut.Location = new System.Drawing.Point(203, 136);
            this.modificabut.Name = "modificabut";
            this.modificabut.Size = new System.Drawing.Size(180, 26);
            this.modificabut.TabIndex = 15;
            this.modificabut.Text = "Modifica il Prodotto";
            this.modificabut.UseVisualStyleBackColor = true;
            this.modificabut.Click += new System.EventHandler(this.modificabut_Click);
            // 
            // cercabut
            // 
            this.cercabut.Location = new System.Drawing.Point(203, 96);
            this.cercabut.Name = "cercabut";
            this.cercabut.Size = new System.Drawing.Size(180, 26);
            this.cercabut.TabIndex = 16;
            this.cercabut.Text = "Cerca il Prodotto";
            this.cercabut.UseVisualStyleBackColor = true;
            this.cercabut.Click += new System.EventHandler(this.cercabut_Click);
            // 
            // Cancella
            // 
            this.Cancella.Location = new System.Drawing.Point(203, 177);
            this.Cancella.Name = "Cancella";
            this.Cancella.Size = new System.Drawing.Size(180, 26);
            this.Cancella.TabIndex = 17;
            this.Cancella.Text = "Cancella il Prodotto";
            this.Cancella.UseVisualStyleBackColor = true;
            this.Cancella.Click += new System.EventHandler(this.Cancella_Click);
            // 
            // prodcanc
            // 
            this.prodcanc.AutoSize = true;
            this.prodcanc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodcanc.Location = new System.Drawing.Point(9, 165);
            this.prodcanc.Name = "prodcanc";
            this.prodcanc.Size = new System.Drawing.Size(141, 13);
            this.prodcanc.TabIndex = 18;
            this.prodcanc.Text = "Prodotto da Cancellare:";
            // 
            // testocanc
            // 
            this.testocanc.Location = new System.Drawing.Point(12, 181);
            this.testocanc.Name = "testocanc";
            this.testocanc.Size = new System.Drawing.Size(185, 20);
            this.testocanc.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.testocanc);
            this.Controls.Add(this.prodcanc);
            this.Controls.Add(this.Cancella);
            this.Controls.Add(this.cercabut);
            this.Controls.Add(this.modificabut);
            this.Controls.Add(this.prezzomodific);
            this.Controls.Add(this.nomemodific);
            this.Controls.Add(this.prodmodificato);
            this.Controls.Add(this.costomodific);
            this.Controls.Add(this.modifica);
            this.Controls.Add(this.Ricerca);
            this.Controls.Add(this.visualizza);
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
        private System.Windows.Forms.Button visualizza;
        private System.Windows.Forms.Label Ricerca;
        private System.Windows.Forms.TextBox modifica;
        private System.Windows.Forms.TextBox costomodific;
        private System.Windows.Forms.TextBox prodmodificato;
        private System.Windows.Forms.Label nomemodific;
        private System.Windows.Forms.Label prezzomodific;
        private System.Windows.Forms.Button modificabut;
        private System.Windows.Forms.Button cercabut;
        private System.Windows.Forms.Button Cancella;
        private System.Windows.Forms.Label prodcanc;
        private System.Windows.Forms.TextBox testocanc;
    }
}

