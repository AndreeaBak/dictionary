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
    public partial class DragAndDrop : Form
    {
        public DragAndDrop()
        {
            InitializeComponent();
            Cuvant.AllowDrop = true;
            Traducere.AllowDrop = true;
        }

        private void btnAdaugaForm3_Click(object sender, EventArgs e)
        {
            Cuvant.Items.Add(tbCuvForm3.Text);

        }

        private void Cuvant_MouseDown(object sender, MouseEventArgs e)
        {
            Traducere.DoDragDrop(Cuvant.SelectedItem.ToString(), DragDropEffects.Copy);
        }

        private void Traducere_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void Traducere_DragDrop(object sender, DragEventArgs e)
        {
            Traducere.Items.Add(e.Data.GetData(DataFormats.Text));
            Cuvant.Items.Remove(e.Data.GetData(DataFormats.Text));
        }
    }
}
