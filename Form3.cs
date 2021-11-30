using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.IO;
using System.Data.SqlClient;

namespace UP
{
    public partial class Form3 : Form
    {
        static string conStr = " Data Source = (localdb)\\MSSQLLocalDB;Initial Catalog = b1; Integrated Security = True";
        DataContext context = new DataContext(conStr);
        public Form3()
        {
            InitializeComponent();
            Table<ClientServ> clientser = context.GetTable<ClientServ>();
            dataGridView1.DataSource = clientser.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainform mainform = new mainform();
            mainform.Show();
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }
    }
}
