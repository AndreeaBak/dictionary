using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionar2
{
    public partial class AdaugaCuvant : Form
    {
        public string tmp_traducere;
        public string tmp_definitie;
        public AdaugaCuvant(string traducere, string definitie) : this()
        {
            tmp_traducere = traducere;
            tmp_definitie = definitie;
        }
        public AdaugaCuvant()
        {
            InitializeComponent();
        }

        private void btnAdaugaCuvant_Click(object sender, EventArgs e)
        {
           
            Form1.myDictionar2.Add(tmp_traducere, tbAdaugaCuvant.Text);
            Form1.myDictionar2.Add(tbAdaugaCuvant.Text, tmp_traducere);
            Form1.myDictionar.Add(tmp_definitie, tbAdaugaDefinitie.Text);
            Form1.myDictionar.Add(tbAdaugaDefinitie.Text, tmp_definitie);
            MessageBox.Show("Adaugarea a avut loc cu succes!");
            this.Close();
        }
    }
}
