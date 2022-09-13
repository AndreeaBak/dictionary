using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System.IO;

namespace Dictionar2
{
    public partial class Form1 : Form
    {
       public List<Traducere> lstTraducere;

        public static Dictionary<string, string> myDictionar = new Dictionary<string, string>();
        public static Dictionary<string, string> myDictionar2 = new Dictionary<string, string>();
        public Form1()
        {
            InitializeComponent();
            lstTraducere = new List<Traducere>()
            {
                new Traducere("tastatura", "keyboard", "Dispozitiv periferic de intrare"),
                new Traducere("printer", "imprimanta", "Dispozitiv periferic de iesire"),
                new Traducere("mar", "apple", "Fruct al mărului, de formă rotundă-turtită"),
                new Traducere("motivation", "motivatie", "Motive care determina pe cineva sa faca ceva"),
                new Traducere("ac", "needle", "Mică ustensilă de oțel, care serveste la cusut"),
                new Traducere("achieved", "realizat", "Făcut, împlinit, înfăptuit"),
                new Traducere("adauga", "add", "A mai pune peste"),
                new Traducere("chain", "lant", "Șir de verigi"),
                new Traducere("orez", "rice","Plantă alimentară din familia gramineelor")

            };
        }
        private void ClickMyRadioButton()
        {
            if (radioBtnRomEng.Checked)
            {
                radioBtnRomEng.PerformClick();
            }
        }
        private void btnCauta_Click(object sender, EventArgs e)
        {
            if (tbCuvant.Text == "")
                MessageBox.Show("Introduceti un cuvant!");
            else if (myDictionar.ContainsKey(tbCuvant.Text))
            {
                string rezultat1;
                string rezultat2;
                myDictionar2.TryGetValue(tbTrad.Text, out rezultat1);
                tbTrad.Text = rezultat1;
                myDictionar.TryGetValue(tbCuvant.Text, out rezultat2);
                tbDefinitie.Text = rezultat2;
                
            }

            else if (tbCuvant.Text.Equals(lstTraducere[0].CuvNecunoscut))
            {
                tbTrad.Text = lstTraducere[0].CuvTradus;
                tbDefinitie.Text = lstTraducere[0].Definitie;
            }
            else if (tbCuvant.Text.Equals(lstTraducere[1].CuvNecunoscut))
            {
                tbTrad.Text = lstTraducere[1].CuvTradus;
                tbDefinitie.Text = lstTraducere[1].Definitie;
            }
            else if (tbCuvant.Text.Equals(lstTraducere[2].CuvNecunoscut))
            {
                tbTrad.Text = lstTraducere[2].CuvTradus;
                tbDefinitie.Text = lstTraducere[2].Definitie;
            }
            else if (tbCuvant.Text.Equals(lstTraducere[3].CuvNecunoscut))
            {
                tbTrad.Text = lstTraducere[3].CuvTradus;
                tbDefinitie.Text = lstTraducere[3].Definitie;
            }
            else if (tbCuvant.Text.Equals(lstTraducere[4].CuvNecunoscut))
            {
                tbTrad.Text = lstTraducere[4].CuvTradus;
                tbDefinitie.Text = lstTraducere[4].Definitie;
            }
            else if (tbCuvant.Text.Equals(lstTraducere[5].CuvNecunoscut))
            {
                tbTrad.Text = lstTraducere[5].CuvTradus;
                tbDefinitie.Text = lstTraducere[5].Definitie;
            }
            else if (tbCuvant.Text.Equals(lstTraducere[6].CuvNecunoscut))
            {
                tbTrad.Text = lstTraducere[6].CuvTradus;
                tbDefinitie.Text = lstTraducere[6].Definitie;
            }
            else if (tbCuvant.Text.Equals(lstTraducere[7].CuvNecunoscut))
            {
                tbTrad.Text = lstTraducere[7].CuvTradus;
                tbDefinitie.Text = lstTraducere[7].Definitie;
            }
            else if (tbCuvant.Text.Equals(lstTraducere[8].CuvNecunoscut))
            {
                tbTrad.Text = lstTraducere[8].CuvTradus;
                tbDefinitie.Text = lstTraducere[8].Definitie;
            }
            else
                tbDefinitie.Text = "Necunoscut\r\nApasa 'Adauga Cuvant' pentru a adauga cuvantul in dictionar.";

        }

        private void btnAdaugaCuvant_Click(object sender, EventArgs e)
        {
            if (tbCuvant.Text == "")
                MessageBox.Show("Introduceti un cuvant!");
            else
            {
                AdaugaCuvant frm = new AdaugaCuvant(tbTrad.Text, tbCuvant.Text);
                frm.Show();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream fisOut = new FileStream("Traducere.txt", FileMode.Create);
            BinaryFormatter bin = new BinaryFormatter();
            bin.Serialize(fisOut, lstTraducere);
            fisOut.Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream fisIn = new FileStream("Traducere.txt", FileMode.Open);
            BinaryFormatter bin = new BinaryFormatter();
            if (fisIn.CanRead)
            {
                lstTraducere = (List<Traducere>)bin.Deserialize(fisIn);
                lvTrad.Items.Clear();
                ListViewItem itm;
                foreach (Traducere t in lstTraducere)
                {
                    itm = new ListViewItem(t.CuvNecunoscut);
                }
            }
        }
        

        private void graficCuvinteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Grafic desen = new Grafic();
            int[] vectContor = new int[10];
            foreach (Traducere s in lstTraducere)
            {
                int poz = s.CuvNecunoscut.Length;
                if (s.CuvNecunoscut.Length == 10)
                {
                    poz = 9;
                }
                vectContor[poz]++;
            }
            for (int i = 0; i < 10; i++)
            {
                tbmess.Text += $"\r\n{vectContor[i]} cuvinte cu lungimea: {i + 1}";
            }
            desen.vectNrCuv = vectContor;
            desen.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Lista cuvintelor din dictionar: \n", new Font("Arial", 15), Brushes.Black, 10, 10);
            int linia = 1;
            foreach(Traducere t in lstTraducere)
            {

                e.Graphics.DrawString($"\r\n{t}", new Font("Arial", 15), Brushes.Black, 10, 10 + linia * 20);
                linia++;
            }
        }

        private void cuvinteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            tbmess.Text = "Lista cuvintelor: \n";
            foreach (Traducere s in lstTraducere)
            {
                tbmess.Text += $"\r\n{s}";
            }
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void lvTrad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void afisareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListViewItem itm;
            lvTrad.Items.Clear();
            foreach (Traducere t in lstTraducere)
            {
                itm = new ListViewItem(t.CuvNecunoscut);
                itm.SubItems.Add(t.CuvTradus);
                itm.SubItems.Add(t.Definitie);
                lvTrad.Items.Add(itm);
            }
        }

        private void btnDragDrop_Click(object sender, EventArgs e)
        {
            DragAndDrop forms = new DragAndDrop();
            forms.Show();
        }

        private void retrieveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Retrieve forms = new Retrieve();
            forms.Show();
        }

        private void dragAndDropToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DragAndDrop forms = new DragAndDrop();
            forms.Show();
        }

        private void storeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Store forms = new Store();
            forms.Show();
        }
    }
}

