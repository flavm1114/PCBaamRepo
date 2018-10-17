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
            int a;
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
            
        }
        
        private void SignUpButton_Click_1(object sender, EventArgs e)
        {
            SignUpForm siginUp = new SignUpForm();
            siginUp.Show();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            //Select();
            //MessageBox.Show("로그인 클릭됐어용");
            Customer customer = new Customer();
            MessageBox.Show("데이터베이스" + customer.회원id);
            MessageBox.Show("로그인화면"+ idTextbox.Text);

//            if (customer.회원id == idTextbox.Text && customer.패스워드 == pwTextbox.Text)
//            {
//                MessageBox.Show("로그인 완료");
//            }
        }
    }
}
