using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionar2
{
    public partial class Store : Form
    {
        public Store()
        {
            InitializeComponent();
        }

        private void btnSalveazaDB2_Click(object sender, EventArgs e)
        {
            string constring = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=TraducereDB;Integrated Security=True;Pooling=False";
            string Query = "insert into TabelTraducere (CuvantNec, CuvTrad, Definitie) values ('" + this.tbCuvantDB2.Text + "','" + this.tbTradDB2.Text + "','" + this.tbDefinitieDB2.Text + "');";
            SqlConnection con2 = new SqlConnection(constring);
            SqlCommand cmd2 = new SqlCommand(Query, con2);
            SqlDataReader reader2;
            try
            {
                con2.Open();
                reader2 = cmd2.ExecuteReader();
                MessageBox.Show("Saved");
                while (reader2.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
