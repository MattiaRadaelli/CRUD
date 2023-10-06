using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD
{
    public partial class CRUD : Form
    {
        
       //   dichiarazione della struct per i prodotti e il loro ripsettivo prezzo
        public struct Prodotto
        {
            public string nome;
            public float costo;
        }

       //   dichiarazione di tutte le variabili utilizzate         
        public Prodotto[] p = new Prodotto[0];
        public int dim = 0;
        public float percentuale = 0;
        public float valorepercentuale = 0;
        public int segno = 1;
        public bool valorenonvalido = false;
        public CRUD()
        {
            InitializeComponent();
        }

        //   Funzione C = Create, aggiunge un nuovo prodotto con il prezzo alla lista
        public void C()
        {
            p[dim].nome = prodotto.Text;
            p[dim].costo = float.Parse(prezzo.Text);
            dim++;
        }

        //   Funzione R = Read, permette di visualizzare i prodotti e i loro prezzi nella lista 
        //   Con le modifiche della seconda parte la funzione R viene eseguita per ogni bottone senza dover cliccare "visualizza lista"
        public void R()
        {
            ListaProd.Items.Clear();
            for (int i = 0; i < p.Length; i++)
            {
                ListaProd.Items.Add(p[i].nome + " " + p[i].costo + "€" );
            }
        }

        //   Funzione U = Uptade, permette di modificare i prodotti e i loro prezzi nella lista 
        public void U()
        {
            ListaProd.Items.Clear();
            for (int i = 0; i < p.Length; i++)
            {
                if (modifica.Text == p[i].nome)
                {
                    p[i].nome = prodmodificato.Text;
                    p[i].costo = float.Parse(costomodific.Text);
                }
                ListaProd.Items.Add(p[i].nome + " " + p[i].costo + "€");
            }
        }

        //   Funzione D = Delete, permette di cancellare i prodotti e i loro prezzi dalla lista e dalla struct
        public void D()
        {
            bool verifica = false;
            for (int i = 0; i < p.Length; i++)
            {
                if (testocanc.Text == p[i].nome)
                {
                    verifica = true;
                    for (int z = i; z < p.Length-1 ; z++)
                    {                       
                        p[z].costo = p[z + 1].costo;
                        p[z].nome = p[z + 1].nome;
                    }
                }
            }
            if (verifica == true)
            {
                Array.Resize(ref p, p.Length - 1);
                dim--;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //   Bottone che viene cliccato per aggiungere un nuovo prodotto con il prezzo
        //   Ha un controllo che permette di verificare che siano inseriti dei valori in entrambe le caselle di testo e che in quella del prezzo non ci siano parole
        private void Aggiungi_Click(object sender, EventArgs e)
        {

            if (float.TryParse(prezzo.Text,out _) == false || prezzo.Text == string.Empty || prodotto.Text == string.Empty)
            { 
                MessageBox.Show("Inserisci Un Valore Accettabile", "Valore Errato!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valorenonvalido = true;
            }
            
            if (valorenonvalido == false)
            {
                Array.Resize(ref p, p.Length + 1);
                C();
                prodotto.Text = null;
                prezzo.Text = null;
                R();
            }
            valorenonvalido = false;
        }

        //   Bottone che viene cliccato per modificare un prodotto con il prezzo
        //   Ha un controllo che permette di verificare che siano inseriti dei valori in entrambe le caselle di testo e che in quella del prezzo non ci siano parole
        private void modificabut_Click(object sender, EventArgs e)
        {
            if (float.TryParse(costomodific.Text, out _) == false || prodmodificato.Text == string.Empty || costomodific.Text == string.Empty)
            {
                MessageBox.Show("Inserisci Dei Valori Accettabili", "Valori Errati!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valorenonvalido = true;
            }

            if (valorenonvalido == false)
            {
                U();
                prodmodificato.Text = null;
                costomodific.Text = null;
                modifica.Text = null;
            }
            valorenonvalido = false;
        }

        //   Bottone che viene cliccato per cancellare un prodotto con il prezzo
        //   Ha un controllo che permette di verificare che sia inserito un prodotto esistente nella lista
        private void Cancella_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < p.Length; i++)
            {
                if (testocanc.Text == p[i].nome)
                {
                    valorenonvalido = false;
                    break;
                }
                if (testocanc.Text != p[i].nome)
                {
                    valorenonvalido = true;
                }
            }
            if (testocanc.Text == string.Empty || valorenonvalido == true)
            {
                MessageBox.Show("Inserisci Un Valore Accettabile", "Valori Errati!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valorenonvalido = true;
            }
            if (valorenonvalido == false)
            {
                D();
                R();
                testocanc.Text = null;
            }
            valorenonvalido = false;
        }

        //   Bottone che viene cliccato per cercare un prodotto con il prezzo per poterlo modificare poi
        //   Ha un controllo che permette di verificare che sia inserito un prodotto esistente nella lista
        private void cercabut_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < p.Length; i++)
            {
                if (modifica.Text == p[i].nome)
                {
                    prodmodificato.Text = p[i].nome;
                    costomodific.Text = (p[i].costo).ToString();
                    valorenonvalido = true;
                }
            }
            if (valorenonvalido == false)
            {
                MessageBox.Show("Nessun Prodotto Esistente", "Prodotto Errato!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            valorenonvalido = false;
        }

        //   Funzione che viene usata per ordinare i prodotti con i prezzi in modo alfabetico
        public void OrdinamentoFunz()
        {
            for (int i = 0;i < p.Length - 1;i++) 
            {
                for (int j = i + 1; j < p.Length; j++)
                {
                    if (p[i].nome.CompareTo(p[j].nome) > 0)
                    { 
                        string scambiostring = p[i].nome;
                        p[i].nome = p[j].nome;
                        p[j].nome = scambiostring;
                        float scambionum = p[i].costo;
                        p[i].costo = p[j].costo;
                        p[j].costo = scambionum;
                    }
                }
            }
        }

        //   Bottone che viene cliccato per ordinare i prodotti con i prezzi in ordine alfabetico
        //   Ha un controllo che permette di verificare che siano presenti dei prodotti in lista
        private void Ordinamento_Click(object sender, EventArgs e)
        {

            if (p.Length == 0)
            {
                MessageBox.Show("Inserisci Prima Dei Prodotti", "Prodotti Inesistenti!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valorenonvalido = true;
            }

            if (valorenonvalido == false)
            {
                OrdinamentoFunz();
                R();
            }
            valorenonvalido = false;
        }

        //   Bottone che viene cliccato per sommare i prezzi di tutti i prodotti
        //   Ha un controllo che permette di verificare che siano presenti dei prodotti in lista
        private void SommaPrezzi_Click(object sender, EventArgs e)
        {
            if (p.Length == 0)
            {
                MessageBox.Show("Inserisci Prima Dei Prodotti", "Prodotti Inesistenti!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valorenonvalido = true;
            }

            if (valorenonvalido == false)
            {
                float totalesomma = 0;
                for (int i = 0; i < p.Length; i++)
                {
                    totalesomma += p[i].costo;
                }
                Totaleprez.Text = "Totale Dei Prezzi: " + totalesomma + "€";
            }
            valorenonvalido = false;
        }

        //   Funzione che viene usata per sommare o sottrarre una percentuale a tutti i prezzi
        public void Percentuale()
        {
            for (int i = 0; i<p.Length; i++)
            {
                valorepercentuale = (p[i].costo / 100) * percentuale;
                p[i].costo += valorepercentuale * segno;
            }
        }

        //   Bottone che viene cliccato per sommare una percentuale a tutti i prezzi di tutti i prodotti
        //   Ha un controllo che permette di verificare che siano presenti dei valori corretti nella textbox
        private void butsomm_Click(object sender, EventArgs e)
        {
            if (float.TryParse(Percent.Text, out _) == false || Percent.Text == string.Empty)
            {
                MessageBox.Show("Inserisci Un Valore Accettabile", "Valore Errato!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valorenonvalido = true;
            }

            if (valorenonvalido == false)
            {
                percentuale = float.Parse(Percent.Text);
                Percent.Text = null;
                segno = 1;
                Percentuale();
                R();
            }
            valorenonvalido = false;
        }

        //   Bottone che viene cliccato per sottrarre una percentuale a tutti i prezzi di tutti i prodotti
        //   Ha un controllo che permette di verificare che siano presenti dei valori corretti nella textbox
        private void butsott_Click(object sender, EventArgs e)
        {
            if (float.TryParse(Percent.Text, out _) == false || Percent.Text == string.Empty)
            {
                MessageBox.Show("Inserisci Un Valore Accettabile", "Valore Errato!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valorenonvalido = true;
            }

            if (valorenonvalido == false)
            {
                percentuale = float.Parse(Percent.Text);
                Percent.Text = null;
                segno = -1;
                Percentuale();
                R();
            }
            valorenonvalido = false;
        }

        //   Bottone che viene cliccato per salvare tutti i prodotti e i prezzi nel file "Salvato.txt"
        private void salvafile_Click(object sender, EventArgs e)
        {
            StreamWriter lettore = new StreamWriter("Salvato.txt");
            for (int i = 0; i < p.Length; i++)
            {
                lettore.Write(p[i].nome + " " + p[i].costo + "€ ; ");
            }
            lettore.Close();
        }

        //   Bottone che viene cliccato per mostrare tutto ciò che è presente in "Salvato.txt" sulla listbox
        private void leggifile_Click(object sender, EventArgs e)
        {
            StreamReader lettore = new StreamReader("Salvato.txt");
            ListaProd.Items.Clear();
            string riga = lettore.ReadLine();
            while (riga != null)
            {              
                ListaProd.Items.Add(riga);
                riga = lettore.ReadLine();
            }
            lettore.Close();
        }

        //   Bottone che viene cliccato per trovare il prodotto col prezzo minore
        //   Ha un controllo che permette di verificare che siano presenti dei prodotti 
        private void butprezmin_Click(object sender, EventArgs e)
        {
            if (p.Length == 0)
            {
                MessageBox.Show("Inserisci Prima Un Prodotto", "Prodotti Inesistenti!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valorenonvalido = true;
            }

            if (valorenonvalido == false)
            {
                int prezmin = 0;
                for (int i = 0; i < p.Length - 1; i++)
                {
                    if (p[i].costo > p[i + 1].costo)
                    {
                        prezmin = i + 1;
                    }
                }
                prezminlab.Text = "Prezzo Minimo: " + p[prezmin].costo + "€ di " + p[prezmin].nome;
            }
            valorenonvalido = false;
            
        }

        //   Bottone che viene cliccato per trovare il prodotto col prezzo maggiore
        //   Ha un controllo che permette di verificare che siano presenti dei prodotti 
        private void butprezmax_Click(object sender, EventArgs e)
        {
            if (p.Length == 0)
            {
                MessageBox.Show("Inserisci Prima Un Prodotto", "Prodotti Inesistenti!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                valorenonvalido = true;
            }

            if (valorenonvalido == false)
            {
                int prezmax = 0;
                for (int i = 0; i < p.Length - 1; i++)
                {
                    if (p[i].costo < p[i + 1].costo)
                    {
                        prezmax = i + 1;
                    }
                }
                prezmaxlab.Text = "Prezzo Massimo: " + p[prezmax].costo + "€ di " + p[prezmax].nome;
            }
            valorenonvalido = false;
        }
    }
}
