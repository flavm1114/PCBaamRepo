using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PCBaam.Data;

namespace PCBaam.GUI
{
    public partial class SignUpForm : Form
    {
        private PC_Cafe_OrderEntities db;
        

        public SignUpForm()
        {
            InitializeComponent();
        }
        private void SignUpForm_Load(object sender, EventArgs e)

        {
            db = new PC_Cafe_OrderEntities();
            
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            db = new PC_Cafe_OrderEntities();
            Customer newCustomer = new Customer();
            newCustomer.회원id = idTextbox.Text;
            newCustomer.패스워드 = pwTextbox.Text;
            newCustomer.성명 = nameTextbox.Text;
            newCustomer.전화번호 = cellnumTextbox.Text;
            newCustomer.이메일 = mailTextbox.Text;

            db.Customers.Add(newCustomer);
            db.SaveChanges();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
