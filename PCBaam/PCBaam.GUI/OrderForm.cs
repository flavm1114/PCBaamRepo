using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PCBaam.GUI.Models;

namespace PCBaam.GUI
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void OrderForm_Load(object sender, EventArgs s)
        {
            //MessageBox.Show("Test");
            PC_Cafe_OrderEntities1 context = new PC_Cafe_OrderEntities1();

            var query = from x in context.Foods
                select new FoodReportItem
                {
                    FoodName = x.음식이름,
                    Price = x.가격
                };

            List<FoodReportItem> foodlist = query.ToList();
            //MessageBox.Show(foodlist[0].FoodName);

            foodBindingSource.DataSource = foodlist;            
        }

//        private void foodBindingSource_CurrentChanged(object sender, EventArgs e)
//        {
//
//        }
    }
}
