using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCBaam.GUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FindIdPw_Click(object sender, EventArgs e)
        {
           Findidfw aa = new Findidfw();
            aa.Show();
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            SignUpForm siginUp = new SignUpForm();
            siginUp.Show();
        }
    }
}
