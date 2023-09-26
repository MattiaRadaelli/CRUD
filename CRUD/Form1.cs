using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD
{
    public partial class Form1 : Form
    {
        public struct Prodotto
        {
            public string nome;
            public float costo;
        }
        public Prodotto[] p = new Prodotto[0];
        int[] i = new int[];
        public int dim = 0;
        public int prodotti = 0;
        public float scambio = 0;
        public string scambios = "";
        public Form1()
        {
            InitializeComponent();
        }
        public void C()
        {
            p[dim].nome = prodotto.Text;
            p[dim].costo = float.Parse(prezzo.Text);
            dim++;
            prodotti++;
        }
        public void R()
        {
            ListaProd.Items.Clear();
            for (int i = 0; i < prodotti; i++)
            {
                ListaProd.Items.Add(p[i].nome + " " + p[i].costo + "€" );
            }
        }
        public void U()
        {
            ListaProd.Items.Clear();
            for (int i = 0; i < prodotti; i++)
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
            for (int i = 0; i < prodotti; i++)
            {
                if (testocanc.Text == p[i].nome)
                {
                    for (int z = i; z < p.Length-1 ; z++)
                    {                       
                        p[z].costo = p[z + 1].costo;
                        p[z].nome = p[z + 1].nome;
                    }
                }
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Aggiungi_Click(object sender, EventArgs e)
        {
            p = new Prodotto[p.Length+1];
            C();
            prodotto.Text = null;
            prezzo.Text = null;

        }

        private void visualizza_Click(object sender, EventArgs e)
        {
            R();
            testocanc.Text = null;
        }

        private void modificabut_Click(object sender, EventArgs e)
        {
            U();
        }
        private void Cancella_Click(object sender, EventArgs e)
        {           
            D();
            p = new Prodotto[p.Length - 1];
        }

        private void cercabut_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < prodotti; i++)
            {
                if (modifica.Text == p[i].nome)
                {
                    prodmodificato.Text = p[i].nome;
                    costomodific.Text = (p[i].costo).ToString(); 
                }
            }
        }

        
    }
}
