using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{

    public partial class Form1 : Form
    {
         double rezultat = 0;
         double nr = 0;
         double nrAnt = 0;
        public Form1()
        {
            InitializeComponent();
            
            btnImpartire.Enabled = false;
            btnMinus.Enabled = false;
            btnPlus.Enabled = false;
            btnInmultire.Enabled = false;
            btnRadical.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nr = int.Parse(txtValori.Text);
            rezultat = nrAnt + nr;
            nrAnt = rezultat;
            txtValori.Text = "";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(btnAdd.Enabled==false&&txtValori.Text!="")
            {
            btnInmultire.Enabled = true;
            btnImpartire.Enabled = true;
            btnMinus.Enabled = true;
            btnPlus.Enabled = true;
            
            }
            if(txtValori.Text!="")
            {
                btnRadical.Enabled = true;
            }
            if(txtValori.Text=="")
            {
                btnImpartire.Enabled = false;
                btnMinus.Enabled = false;
                btnPlus.Enabled = false;
                btnInmultire.Enabled = false;
                btnRadical.Enabled = false;

            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           nrAnt = int.Parse(txtValori.Text);
            btnAdd.Enabled = false;
                 
            txtValori.Text = "";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            nr = int.Parse(txtValori.Text);
            rezultat = nrAnt - nr;
            nrAnt = rezultat;
            txtValori.Text = "";
        }

        private void btnInmultire_Click(object sender, EventArgs e)
        {
            nr = int.Parse(txtValori.Text);
            rezultat = nrAnt * nr;
            nrAnt = rezultat;
            txtValori.Text = "";
        }

        private void btnImpartire_Click(object sender, EventArgs e)
        {
            nr = int.Parse(txtValori.Text);
            rezultat = nrAnt / nr;
            nrAnt = rezultat;
            txtValori.Text = "";
        }

        private void btnEgal_Click(object sender, EventArgs e)
        {
            lblRez.Text = rezultat.ToString();
            txtValori.Text = "";
        }

        private void btnRadical_Click(object sender, EventArgs e)
        {
            if(nrAnt==0)
            {
                nrAnt = int.Parse(txtValori.Text);
            }
            rezultat =Math.Sqrt((double) nrAnt);
            nrAnt = rezultat;
            txtValori.Text = "";
            lblRez.Text = rezultat.ToString();
            btnAdd.Enabled = false;
            btnInmultire.Enabled = true;
            btnImpartire.Enabled = true;
            btnMinus.Enabled = true;
            btnPlus.Enabled = true;

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtValori.Text = "";
            btnAdd.Enabled = true;
            nr = 0;
            nrAnt = 0;
            rezultat = 0;
            lblRez.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void timer_Tick(object sender, EventArgs e)
        {
           
        }
    }
}
