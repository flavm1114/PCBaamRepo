using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCBaam.GUI
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }
        private void SignUpForm_Load(object sender, EventArgs e)

        {

            comboBoxJob.SelectedIndex = 0;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            IdCheck id = new IdCheck();

            id.Owner = this;

            id.ShowDialog();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

       

 
        }
    }
}
