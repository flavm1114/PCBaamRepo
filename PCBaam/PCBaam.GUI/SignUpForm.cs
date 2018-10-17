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
        private PC_Cafe_OrderEntities1 db;
        

        public SignUpForm()
        {
            InitializeComponent();
        }
        private void SignUpForm_Load(object sender, EventArgs e)

        {
            //db = new PC_Cafe_OrderEntities1();
            
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Insert();
            
            if (idTextbox.Text == null)
                MessageBox.Show("아이디를 입력하세요");
            else if (pwTextbox.Text == null)
                MessageBox.Show("패스워드를 입력하세요");
            else if (nameTextbox.Text == null)
                MessageBox.Show("이름을 입력하세요");
            else if (cellphoneTextbox.Text == null)
                MessageBox.Show("전화번호를 입력하세요");
            else if (mailTextbox.Text == null)
                MessageBox.Show("이메일을 입력하세요");
            else
            {
                MessageBox.Show("가입이 완료 되었습니다");
                this.Close();
            }
            
        }

        private void Insert()
        {
            db = new PC_Cafe_OrderEntities1();
            Customer newCustomer = new Customer();
            newCustomer.회원id = idTextbox.Text;
            newCustomer.패스워드 = pwTextbox.Text;
            newCustomer.성명 = nameTextbox.Text;
            newCustomer.전화번호 = cellphoneTextbox.Text;
            newCustomer.이메일 = mailTextbox.Text;
            newCustomer.잔여시간 = 0;
            //newCustomer.회원번호 = 100;


            db.Customers.Add(newCustomer);
            db.SaveChanges();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
