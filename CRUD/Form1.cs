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
        public struct Prodotto
        {
            public string nome;
            public float costo;
        }
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
        public void C()
        {
            p[dim].nome = prodotto.Text;
            p[dim].costo = float.Parse(prezzo.Text);
            dim++;
        }
        public void R()
        {
            ListaProd.Items.Clear();
            for (int i = 0; i < p.Length; i++)
            {
                ListaProd.Items.Add(p[i].nome + " " + p[i].costo + "€" );
            }
        }
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
                MessageBox.Show("Inserisci Un Prodotto Esisitente", "Prodotto Errato!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            valorenonvalido = false;
        }
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

        public void Percentuale()
        {
            for (int i = 0; i<p.Length; i++)
            {
                valorepercentuale = (p[i].costo / 100) * percentuale;
                p[i].costo += valorepercentuale * segno;
            }
        }
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
        private void salvafile_Click(object sender, EventArgs e)
        {
            StreamWriter lettore = new StreamWriter("Salvato.txt");
            for (int i = 0; i < p.Length; i++)
            {
                lettore.Write(p[i].nome + " " + p[i].costo + "€ ; ");
            }
            lettore.Close();
        }

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
