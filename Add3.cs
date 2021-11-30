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
    public partial class Add3 : Form
    {
        static string conStr = " Data Source = (localdb)\\MSSQLLocalDB;Initial Catalog = b1; Integrated Security = True";
        DataContext context = new DataContext(conStr);
        public mainform mainForm;
        public Add3()
        {
            InitializeComponent();
           
        }

        private void Add_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "b1DataSet1.Service". При необходимости она может быть перемещена или удалена.
            this.serviceTableAdapter1.Fill(this.b1DataSet1.Service);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "b1.Service". При необходимости она может быть перемещена или удалена.
            

        }

        private void Cancel2_Click(object sender, EventArgs e)
        {
            mainform form1 = new mainform();
            form1.Show();
            Close();
        }

        private void Add2_Click(object sender, EventArgs e)
        {

            Service add = new Service();
            add.Title = ServiceTitleTB.Text;
            add.Cost = Convert.ToInt32(ServiceCostTB.Text);
            add.DurationInSeconds = Convert.ToInt32(ServiceDurationTB.Text);
            add.Description = ServiceDescriptionTB.Text;
            add.Discount= Convert.ToInt32(ServiceDiscountTB.Text);
            add.MainImagePath = Convert.ToString(PathCB.SelectedValue);
            context.GetTable<Service>().InsertOnSubmit(add);
            context.SubmitChanges();

        }

        private void PathCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ServiceDiscountTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void ServiceDescriptionTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void ServiceDurationTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void ServiceCostTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void ServiceTitleTB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
