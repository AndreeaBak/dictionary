using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Dictionar2
{
    public partial class Retrieve : Form
    {
        public Retrieve()
        {
            InitializeComponent();
        }

        private void btnCautaDB_Click(object sender, EventArgs e)
        {
            SqlConnection con1 = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=TraducereDB;Integrated Security=True;Pooling=False");
            con1.Open();
            SqlCommand cmd1 = new SqlCommand("Select CuvantNec, CuvTrad, Definitie from TabelTraducere where CuvantNec = @CuvantNec", con1);
            cmd1.Parameters.AddWithValue("CuvantNec", tbCuvantDB.Text);
            SqlDataReader reader1;
            reader1 = cmd1.ExecuteReader();
            if (reader1.Read())
            {
                tbTradDB.Text = reader1["CuvTrad"].ToString();
                tbDefinitieDB.Text = reader1["Definitie"].ToString();
            }
            else
            {
                MessageBox.Show("No Data Found");
            }
            con1.Close();
        }

      
    }
}
