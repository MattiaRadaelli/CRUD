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
    public partial class CRUD : Form
    {
        public struct Prodotto
        {
            public string nome;
            public float costo;
        }
        public Prodotto[] p = new Prodotto[0];
        public int dim = 0;
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
            Array.Resize(ref p, p.Length + 1);
            C();
            prodotto.Text = null;
            prezzo.Text = null;
            R();

        }
        private void modificabut_Click(object sender, EventArgs e)
        {
            U();
            prodmodificato.Text = null; 
            costomodific.Text = null;
            modifica.Text = null;
        }
        private void Cancella_Click(object sender, EventArgs e)
        {           
            D();
            R();
            testocanc.Text = null;
        }
        private void cercabut_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < p.Length; i++)
            {
                if (modifica.Text == p[i].nome)
                {
                    prodmodificato.Text = p[i].nome;
                    costomodific.Text = (p[i].costo).ToString(); 
                }
            }
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
            OrdinamentoFunz();
            R();
        }

        private void SommaPrezzi_Click(object sender, EventArgs e)
        {
            
            Totaleprez.Text = ;
        }
    }
}
