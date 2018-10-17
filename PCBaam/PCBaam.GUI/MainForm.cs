using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            int c;
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
//            SqlConnection connection = CreateAndOpenConnection();
//            connection.Open();
//
//            SqlCommand command = new SqlCommand();
//
//            command.CommandText = "select 회원id from Customer";
//            command.CommandType = CommandType.Text;
//            command.Connection = connection;
            PC_Cafe_OrderEntities1 context = new PC_Cafe_OrderEntities1();

            List<Customer> customers = context.Customers.ToList();

            foreach (var x in customers)
            {
                if (x.회원id == idTextbox.Text && x.패스워드 == pwTextbox.Text)
                {
                    OrderForm orderForm = new OrderForm();
                    
                    orderForm.Show();
                }
                else if(x.회원id != idTextbox.Text && x.패스워드 != pwTextbox.Text)
                {
                    MessageBox.Show("아이디와 패스워드를 확인하세요");
                    break;
                }
            }
        }

//        private static SqlConnection CreateAndOpenConnection()
//        {
//            SqlConnection connection = new SqlConnection();
//            connection.ConnectionString = @"server=10.10.14.55\MSSQLSERVER,1433; database=PC_Cafe Order;uid=sa;pwd=1234";
//            connection.Open();
//
//            return connection;
//        }

    }
}
