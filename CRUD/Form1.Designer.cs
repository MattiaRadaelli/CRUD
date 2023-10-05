namespace CRUD
{
    partial class CRUD
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
            this.OrdinamentoAlfa = new System.Windows.Forms.Label();
            this.Ordinamento = new System.Windows.Forms.Button();
            this.Totaleprez = new System.Windows.Forms.Label();
            this.SommaPrezzi = new System.Windows.Forms.Button();
            this.InserisciPerc = new System.Windows.Forms.Label();
            this.Percent = new System.Windows.Forms.TextBox();
            this.butsomm = new System.Windows.Forms.Button();
            this.butsott = new System.Windows.Forms.Button();
            this.File = new System.Windows.Forms.Label();
            this.salvafile = new System.Windows.Forms.Button();
            this.leggifile = new System.Windows.Forms.Button();
            this.butprezmin = new System.Windows.Forms.Button();
            this.prezminlab = new System.Windows.Forms.Label();
            this.butprezmax = new System.Windows.Forms.Button();
            this.prezmaxlab = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InserisciProd
            // 
            this.InserisciProd.AutoSize = true;
            this.InserisciProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InserisciProd.Location = new System.Drawing.Point(12, 7);
            this.InserisciProd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.InserisciProd.Name = "InserisciProd";
            this.InserisciProd.Size = new System.Drawing.Size(140, 17);
            this.InserisciProd.TabIndex = 0;
            this.InserisciProd.Text = "Inserisci Prodotto:";
            // 
            // ListaProd
            // 
            this.ListaProd.FormattingEnabled = true;
            this.ListaProd.ItemHeight = 16;
            this.ListaProd.Location = new System.Drawing.Point(484, 27);
            this.ListaProd.Margin = new System.Windows.Forms.Padding(4);
            this.ListaProd.Name = "ListaProd";
            this.ListaProd.Size = new System.Drawing.Size(564, 276);
            this.ListaProd.TabIndex = 2;
            // 
            // Aggiungi
            // 
            this.Aggiungi.Location = new System.Drawing.Point(16, 59);
            this.Aggiungi.Margin = new System.Windows.Forms.Padding(4);
            this.Aggiungi.Name = "Aggiungi";
            this.Aggiungi.Size = new System.Drawing.Size(453, 33);
            this.Aggiungi.TabIndex = 3;
            this.Aggiungi.Text = "Aggiungi alla Lista";
            this.Aggiungi.UseVisualStyleBackColor = true;
            this.Aggiungi.Click += new System.EventHandler(this.Aggiungi_Click);
            // 
            // ListaProdLabel
            // 
            this.ListaProdLabel.AutoSize = true;
            this.ListaProdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaProdLabel.Location = new System.Drawing.Point(481, 7);
            this.ListaProdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ListaProdLabel.Name = "ListaProdLabel";
            this.ListaProdLabel.Size = new System.Drawing.Size(110, 17);
            this.ListaProdLabel.TabIndex = 4;
            this.ListaProdLabel.Text = "Lista Prodotti:";
            // 
            // prezzo
            // 
            this.prezzo.Location = new System.Drawing.Point(247, 27);
            this.prezzo.Margin = new System.Windows.Forms.Padding(4);
            this.prezzo.Name = "prezzo";
            this.prezzo.Size = new System.Drawing.Size(221, 22);
            this.prezzo.TabIndex = 5;
            // 
            // InserisciPrez
            // 
            this.InserisciPrez.AutoSize = true;
            this.InserisciPrez.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InserisciPrez.Location = new System.Drawing.Point(243, 7);
            this.InserisciPrez.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.InserisciPrez.Name = "InserisciPrez";
            this.InserisciPrez.Size = new System.Drawing.Size(128, 17);
            this.InserisciPrez.TabIndex = 6;
            this.InserisciPrez.Text = "Inserisci Prezzo:";
            // 
            // prodotto
            // 
            this.prodotto.Location = new System.Drawing.Point(16, 27);
            this.prodotto.Margin = new System.Windows.Forms.Padding(4);
            this.prodotto.Name = "prodotto";
            this.prodotto.Size = new System.Drawing.Size(221, 22);
            this.prodotto.TabIndex = 7;
            // 
            // Ricerca
            // 
            this.Ricerca.AutoSize = true;
            this.Ricerca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ricerca.Location = new System.Drawing.Point(13, 155);
            this.Ricerca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Ricerca.Name = "Ricerca";
            this.Ricerca.Size = new System.Drawing.Size(178, 17);
            this.Ricerca.TabIndex = 9;
            this.Ricerca.Text = "Prodotto da Modificare:";
            // 
            // modifica
            // 
            this.modifica.Location = new System.Drawing.Point(18, 176);
            this.modifica.Margin = new System.Windows.Forms.Padding(4);
            this.modifica.Name = "modifica";
            this.modifica.Size = new System.Drawing.Size(221, 22);
            this.modifica.TabIndex = 10;
            // 
            // costomodific
            // 
            this.costomodific.Location = new System.Drawing.Point(416, 176);
            this.costomodific.Margin = new System.Windows.Forms.Padding(4);
            this.costomodific.Name = "costomodific";
            this.costomodific.Size = new System.Drawing.Size(52, 22);
            this.costomodific.TabIndex = 11;
            // 
            // prodmodificato
            // 
            this.prodmodificato.Location = new System.Drawing.Point(247, 176);
            this.prodmodificato.Margin = new System.Windows.Forms.Padding(4);
            this.prodmodificato.Name = "prodmodificato";
            this.prodmodificato.Size = new System.Drawing.Size(160, 22);
            this.prodmodificato.TabIndex = 12;
            // 
            // nomemodific
            // 
            this.nomemodific.AutoSize = true;
            this.nomemodific.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomemodific.Location = new System.Drawing.Point(244, 155);
            this.nomemodific.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nomemodific.Name = "nomemodific";
            this.nomemodific.Size = new System.Drawing.Size(75, 17);
            this.nomemodific.TabIndex = 13;
            this.nomemodific.Text = "Prodotto:";
            // 
            // prezzomodific
            // 
            this.prezzomodific.AutoSize = true;
            this.prezzomodific.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prezzomodific.Location = new System.Drawing.Point(413, 155);
            this.prezzomodific.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.prezzomodific.Name = "prezzomodific";
            this.prezzomodific.Size = new System.Drawing.Size(63, 17);
            this.prezzomodific.TabIndex = 14;
            this.prezzomodific.Text = "Prezzo:";
            // 
            // modificabut
            // 
            this.modificabut.Location = new System.Drawing.Point(246, 206);
            this.modificabut.Margin = new System.Windows.Forms.Padding(4);
            this.modificabut.Name = "modificabut";
            this.modificabut.Size = new System.Drawing.Size(223, 32);
            this.modificabut.TabIndex = 15;
            this.modificabut.Text = "Modifica il Prodotto";
            this.modificabut.UseVisualStyleBackColor = true;
            this.modificabut.Click += new System.EventHandler(this.modificabut_Click);
            // 
            // cercabut
            // 
            this.cercabut.Location = new System.Drawing.Point(16, 206);
            this.cercabut.Margin = new System.Windows.Forms.Padding(4);
            this.cercabut.Name = "cercabut";
            this.cercabut.Size = new System.Drawing.Size(223, 32);
            this.cercabut.TabIndex = 16;
            this.cercabut.Text = "Cerca il Prodotto";
            this.cercabut.UseVisualStyleBackColor = true;
            this.cercabut.Click += new System.EventHandler(this.cercabut_Click);
            // 
            // Cancella
            // 
            this.Cancella.Location = new System.Drawing.Point(484, 514);
            this.Cancella.Margin = new System.Windows.Forms.Padding(4);
            this.Cancella.Name = "Cancella";
            this.Cancella.Size = new System.Drawing.Size(223, 32);
            this.Cancella.TabIndex = 17;
            this.Cancella.Text = "Cancella il Prodotto";
            this.Cancella.UseVisualStyleBackColor = true;
            this.Cancella.Click += new System.EventHandler(this.Cancella_Click);
            // 
            // prodcanc
            // 
            this.prodcanc.AutoSize = true;
            this.prodcanc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodcanc.Location = new System.Drawing.Point(506, 461);
            this.prodcanc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.prodcanc.Name = "prodcanc";
            this.prodcanc.Size = new System.Drawing.Size(180, 17);
            this.prodcanc.TabIndex = 18;
            this.prodcanc.Text = "Prodotto da Cancellare:";
            // 
            // testocanc
            // 
            this.testocanc.Location = new System.Drawing.Point(484, 482);
            this.testocanc.Margin = new System.Windows.Forms.Padding(4);
            this.testocanc.Name = "testocanc";
            this.testocanc.Size = new System.Drawing.Size(221, 22);
            this.testocanc.TabIndex = 19;
            // 
            // OrdinamentoAlfa
            // 
            this.OrdinamentoAlfa.AutoSize = true;
            this.OrdinamentoAlfa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrdinamentoAlfa.Location = new System.Drawing.Point(846, 315);
            this.OrdinamentoAlfa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OrdinamentoAlfa.Name = "OrdinamentoAlfa";
            this.OrdinamentoAlfa.Size = new System.Drawing.Size(178, 17);
            this.OrdinamentoAlfa.TabIndex = 20;
            this.OrdinamentoAlfa.Text = "Ordinamento Alfabetico";
            // 
            // Ordinamento
            // 
            this.Ordinamento.Location = new System.Drawing.Point(825, 336);
            this.Ordinamento.Margin = new System.Windows.Forms.Padding(4);
            this.Ordinamento.Name = "Ordinamento";
            this.Ordinamento.Size = new System.Drawing.Size(223, 64);
            this.Ordinamento.TabIndex = 21;
            this.Ordinamento.Text = "Ordina";
            this.Ordinamento.UseVisualStyleBackColor = true;
            this.Ordinamento.Click += new System.EventHandler(this.Ordinamento_Click);
            // 
            // Totaleprez
            // 
            this.Totaleprez.AutoSize = true;
            this.Totaleprez.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Totaleprez.Location = new System.Drawing.Point(861, 6);
            this.Totaleprez.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Totaleprez.Name = "Totaleprez";
            this.Totaleprez.Size = new System.Drawing.Size(138, 17);
            this.Totaleprez.TabIndex = 22;
            this.Totaleprez.Text = "Totale Dei Prezzi:";
            // 
            // SommaPrezzi
            // 
            this.SommaPrezzi.Location = new System.Drawing.Point(493, 270);
            this.SommaPrezzi.Margin = new System.Windows.Forms.Padding(4);
            this.SommaPrezzi.Name = "SommaPrezzi";
            this.SommaPrezzi.Size = new System.Drawing.Size(129, 25);
            this.SommaPrezzi.TabIndex = 23;
            this.SommaPrezzi.Text = "Aggiorna Totale";
            this.SommaPrezzi.UseVisualStyleBackColor = true;
            this.SommaPrezzi.Click += new System.EventHandler(this.SommaPrezzi_Click);
            // 
            // InserisciPerc
            // 
            this.InserisciPerc.AutoSize = true;
            this.InserisciPerc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InserisciPerc.Location = new System.Drawing.Point(861, 461);
            this.InserisciPerc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.InserisciPerc.Name = "InserisciPerc";
            this.InserisciPerc.Size = new System.Drawing.Size(165, 17);
            this.InserisciPerc.TabIndex = 24;
            this.InserisciPerc.Text = "Inserisci Percentuale:";
            // 
            // Percent
            // 
            this.Percent.Location = new System.Drawing.Point(827, 482);
            this.Percent.Margin = new System.Windows.Forms.Padding(4);
            this.Percent.Name = "Percent";
            this.Percent.Size = new System.Drawing.Size(221, 22);
            this.Percent.TabIndex = 25;
            // 
            // butsomm
            // 
            this.butsomm.Location = new System.Drawing.Point(827, 514);
            this.butsomm.Margin = new System.Windows.Forms.Padding(4);
            this.butsomm.Name = "butsomm";
            this.butsomm.Size = new System.Drawing.Size(101, 32);
            this.butsomm.TabIndex = 26;
            this.butsomm.Text = "Sommala";
            this.butsomm.UseVisualStyleBackColor = true;
            this.butsomm.Click += new System.EventHandler(this.butsomm_Click);
            // 
            // butsott
            // 
            this.butsott.Location = new System.Drawing.Point(947, 512);
            this.butsott.Margin = new System.Windows.Forms.Padding(4);
            this.butsott.Name = "butsott";
            this.butsott.Size = new System.Drawing.Size(101, 32);
            this.butsott.TabIndex = 27;
            this.butsott.Text = "Sottraila";
            this.butsott.UseVisualStyleBackColor = true;
            this.butsott.Click += new System.EventHandler(this.butsott_Click);
            // 
            // File
            // 
            this.File.AutoSize = true;
            this.File.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.File.Location = new System.Drawing.Point(532, 315);
            this.File.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(134, 17);
            this.File.TabIndex = 28;
            this.File.Text = "Comandi Con File";
            // 
            // salvafile
            // 
            this.salvafile.Location = new System.Drawing.Point(484, 336);
            this.salvafile.Margin = new System.Windows.Forms.Padding(4);
            this.salvafile.Name = "salvafile";
            this.salvafile.Size = new System.Drawing.Size(103, 64);
            this.salvafile.TabIndex = 29;
            this.salvafile.Text = "Salva su File";
            this.salvafile.UseVisualStyleBackColor = true;
            this.salvafile.Click += new System.EventHandler(this.salvafile_Click);
            // 
            // leggifile
            // 
            this.leggifile.Location = new System.Drawing.Point(605, 336);
            this.leggifile.Margin = new System.Windows.Forms.Padding(4);
            this.leggifile.Name = "leggifile";
            this.leggifile.Size = new System.Drawing.Size(102, 64);
            this.leggifile.TabIndex = 30;
            this.leggifile.Text = "Leggi da File";
            this.leggifile.UseVisualStyleBackColor = true;
            this.leggifile.Click += new System.EventHandler(this.leggifile_Click);
            // 
            // butprezmin
            // 
            this.butprezmin.Location = new System.Drawing.Point(16, 482);
            this.butprezmin.Margin = new System.Windows.Forms.Padding(4);
            this.butprezmin.Name = "butprezmin";
            this.butprezmin.Size = new System.Drawing.Size(452, 64);
            this.butprezmin.TabIndex = 31;
            this.butprezmin.Text = "Aggiorna Prezzo Minimo";
            this.butprezmin.UseVisualStyleBackColor = true;
            this.butprezmin.Click += new System.EventHandler(this.butprezmin_Click);
            // 
            // prezminlab
            // 
            this.prezminlab.AutoSize = true;
            this.prezminlab.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prezminlab.Location = new System.Drawing.Point(185, 461);
            this.prezminlab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.prezminlab.Name = "prezminlab";
            this.prezminlab.Size = new System.Drawing.Size(118, 17);
            this.prezminlab.TabIndex = 32;
            this.prezminlab.Text = "Prezzo Minimo:";
            // 
            // butprezmax
            // 
            this.butprezmax.Location = new System.Drawing.Point(16, 336);
            this.butprezmax.Margin = new System.Windows.Forms.Padding(4);
            this.butprezmax.Name = "butprezmax";
            this.butprezmax.Size = new System.Drawing.Size(452, 64);
            this.butprezmax.TabIndex = 33;
            this.butprezmax.Text = "Aggiorna Prezzo Massimo";
            this.butprezmax.UseVisualStyleBackColor = true;
            this.butprezmax.Click += new System.EventHandler(this.butprezmax_Click);
            // 
            // prezmaxlab
            // 
            this.prezmaxlab.AutoSize = true;
            this.prezmaxlab.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prezmaxlab.Location = new System.Drawing.Point(173, 315);
            this.prezmaxlab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.prezmaxlab.Name = "prezmaxlab";
            this.prezmaxlab.Size = new System.Drawing.Size(130, 17);
            this.prezmaxlab.TabIndex = 34;
            this.prezmaxlab.Text = "Prezzo Massimo:";
            // 
            // CRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 559);
            this.Controls.Add(this.prezmaxlab);
            this.Controls.Add(this.butprezmax);
            this.Controls.Add(this.prezminlab);
            this.Controls.Add(this.butprezmin);
            this.Controls.Add(this.leggifile);
            this.Controls.Add(this.salvafile);
            this.Controls.Add(this.File);
            this.Controls.Add(this.butsott);
            this.Controls.Add(this.butsomm);
            this.Controls.Add(this.Percent);
            this.Controls.Add(this.InserisciPerc);
            this.Controls.Add(this.SommaPrezzi);
            this.Controls.Add(this.Totaleprez);
            this.Controls.Add(this.Ordinamento);
            this.Controls.Add(this.OrdinamentoAlfa);
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
            this.Controls.Add(this.prodotto);
            this.Controls.Add(this.InserisciPrez);
            this.Controls.Add(this.prezzo);
            this.Controls.Add(this.ListaProdLabel);
            this.Controls.Add(this.Aggiungi);
            this.Controls.Add(this.ListaProd);
            this.Controls.Add(this.InserisciProd);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CRUD";
            this.Text = "CRUD";
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
        private System.Windows.Forms.Label OrdinamentoAlfa;
        private System.Windows.Forms.Button Ordinamento;
        private System.Windows.Forms.Label Totaleprez;
        private System.Windows.Forms.Button SommaPrezzi;
        private System.Windows.Forms.Label InserisciPerc;
        private System.Windows.Forms.TextBox Percent;
        private System.Windows.Forms.Button butsomm;
        private System.Windows.Forms.Button butsott;
        private System.Windows.Forms.Label File;
        private System.Windows.Forms.Button salvafile;
        private System.Windows.Forms.Button leggifile;
        private System.Windows.Forms.Button butprezmin;
        private System.Windows.Forms.Label prezminlab;
        private System.Windows.Forms.Button butprezmax;
        private System.Windows.Forms.Label prezmaxlab;
    }
}

