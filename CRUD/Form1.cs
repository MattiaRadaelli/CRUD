﻿using System;
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
        public Prodotto[] p = new Prodotto[99];
        public int dim = 0;
        public int prodotti = 0;
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
            for (int i = 0; i < prodotti; i++)
            {
                ListaProd.Items.Add(p[i].nome + " " + p[i].costo + "€" );
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Aggiungi_Click(object sender, EventArgs e)
        {
            C();
            prodotto.Text = null;
            prezzo.Text = null;

        }

        private void visualizza_Click(object sender, EventArgs e)
        {
            R();
        }
    }
}
