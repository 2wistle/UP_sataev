using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UP
{
    public partial class godmode : Form
    {
        public mainform mainForm;
        public godmode(mainform form)
        {
            InitializeComponent();
            mainForm = form;
        }
        private void Cancel_Click(object sender, EventArgs e)
        {
           mainform mainform = new mainform();
            mainform.Show();
            Close();
        }

        private void Pass_TextChanged_1(object sender, EventArgs e)
        {
            string s = "1234";
            if (Pass.Text == s)
            {
                Add3 add3 = new Add3();
                add3.Show();
                Hide();
                Close();
            }
            
        }
    }
}
