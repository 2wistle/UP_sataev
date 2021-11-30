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
    public partial class edit : Form
    {
        static string conStr = " Data Source = (localdb)\\MSSQLLocalDB;Initial Catalog = b1; Integrated Security = True";
        DataContext context = new DataContext(conStr);
        public mainform mainForm;
       
        public edit(mainform form)
        {
            InitializeComponent();
            mainForm = form;
        }

        public edit()
        {
        }

        private void edit_Load(object sender, EventArgs e)
        {

        }

        private void Add2_Click(object sender, EventArgs e)
        {
            //Service edit = new Service();
            Service edit = context.GetTable<Service>().FirstOrDefault(x => x.ID == Convert.ToInt32(mainForm.TableGV.CurrentRow.Cells[0].Value));
            edit.Title =ServiceTitleTB.Text;
            edit.Cost = Convert.ToInt32(ServiceCostTB.Text);
            edit.DurationInSeconds = Convert.ToInt32(ServiceDurationTB.Text);
            edit.Description = ServiceDescriptionTB.Text;
            edit.Discount = Convert.ToInt32(ServiceDiscountTB.Text);
            edit.MainImagePath = Convert.ToString(PathCB.SelectedValue);
            context.SubmitChanges();
            MessageBox.Show("Успешно!!");
           
        }

        private void Cancel2_Click(object sender, EventArgs e)
        {
            mainform form1 = new mainform();
            form1.Show();
            Close();
        }

        private void edit_Load_1(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "b1DataSet.Service". При необходимости она может быть перемещена или удалена.
            this.serviceTableAdapter.Fill(this.b1DataSet.Service);

        }
    }
}
