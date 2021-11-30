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

namespace UP
{
    public partial class Zapis : Form
    {
        static string conStr = " Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=b1;Integrated Security=True";
        DataContext context = new DataContext(conStr);
        public Zapis()
        {
            InitializeComponent();
            Table<ClientServ> clientser = context.GetTable<ClientServ>();
            dataGridView1.DataSource = clientser.ToList();
        }

        
            
        

        private void Zapis_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "b1DataSet2.Service". При необходимости она может быть перемещена или удалена.
            this.serviceTableAdapter.Fill(this.b1DataSet2.Service);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "b1DataSet1.Client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.b1DataSet1.Client);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ClientServ NewUser = new ClientServ { ClientID = Convert.ToInt32(comboBox1.SelectedValue), ServiceID = Convert.ToInt32(comboBox2.SelectedValue), StartTime = Convert.ToDateTime(dateTimePicker1.Value) };
            context.GetTable<ClientServ>().InsertOnSubmit(NewUser);
            context.SubmitChanges();
        }
    }
}
