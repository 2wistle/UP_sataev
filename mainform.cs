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
    public partial class mainform : Form
    {
        static string conStr = " Data Source = (localdb)\\MSSQLLocalDB;Initial Catalog = b1; Integrated Security = True";
        DataContext context = new DataContext(conStr);
        public mainform()
        {
            InitializeComponent();
           
            this.BackColor = Color.FromArgb(255, 255, 225);
            Table<Service> Service = context.GetTable<Service>();
            var services = Service.Select(s => s.MainImagePath);
            Dictionary<string, Image> images = new Dictionary<string, Image>();
            
            TableGV.DataSource = Service.ToList();
        }

        
        private void Exit_Click(object sender, EventArgs e)
        {
            Close();        
        }

        private void Add_Click(object sender, EventArgs e)
        {
            godmode mode = new godmode(this);
            mode.Show();
            Hide();
            //Add add = new Add(this);
            //add.Show();
            //Hide();
        }

        private void Del_Click(object sender, EventArgs e)
        {
            Service serv= context.GetTable<Service>().OrderByDescending(x => x.ID).FirstOrDefault();
            context.GetTable<Service>().DeleteOnSubmit(serv);
            context.SubmitChanges();
            Table<Service> Service = context.GetTable<Service>();
            TableGV.DataSource = Service.ToList();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            Form2 mode = new Form2(this);
            mode.Show();
            Hide();
            Table<Service> Service = context.GetTable<Service>();
            TableGV.DataSource = Service.ToList();
        }

        private void сервисToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Zapis Zapis = new Zapis();
            Zapis.Show();
            Table<Service> Service = context.GetTable<Service>();
            TableGV.DataSource = Service.ToList();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Service> services = null;
            switch (comboBox1.SelectedIndex)
            {
                case 0: services = context.GetTable<Service>().Where(x => x.Discount <= 0.05 && x.Discount > 0).ToList(); break;
                case 1: services = context.GetTable<Service>().Where(x => x.Discount <= 0.15 && x.Discount > 0.05).ToList(); break;
                case 2: services = context.GetTable<Service>().Where(x => x.Discount <= 0.3 && x.Discount > 0.15).ToList(); break;
                case 3: services = context.GetTable<Service>().Where(x => x.Discount <= 0.7 && x.Discount > 0.3).ToList(); break;
                case 4: services = context.GetTable<Service>().Where(x => x.Discount <= 0.9 && x.Discount > 0.7).ToList(); break;
                case 5: services = context.GetTable<Service>().Where(x => x.Discount <= 1 && x.Discount > 0).ToList(); break;

            }

            TableGV.DataSource = services;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string sql = "Select *From [Service] Where [Title] Like N'%" + textBox1.Text + "%' ";
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(conStr);
            SqlDataAdapter ad = new SqlDataAdapter(sql, con);
            ad.Fill(ds);
            TableGV.DataSource = ds.Tables[0];

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string sql = "Select *From [Service] Where [Description] Like N'%" + textBox2.Text + "%' ";
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(conStr);
            SqlDataAdapter ad = new SqlDataAdapter(sql, con);
            ad.Fill(ds);
            TableGV.DataSource = ds.Tables[0];

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 lol = new Form3();
            lol.Show();
            Hide();
            Table<Service> Service = context.GetTable<Service>();
            TableGV.DataSource = Service.ToList();
        }
    }
}
