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
    public partial class Form2 : Form
    {
        public mainform mainForm;
        public Form2(mainform form)
        {
            InitializeComponent();
            mainForm = form;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainform mainform = new mainform();
            mainform.Show();
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string s = "1234";
            if (textBox1.Text == s)
            {
                edit f3 = new edit(mainForm);
                f3.ShowDialog();

            }
        }
    }


}