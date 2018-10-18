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

            foodBindingSource.DataSource = foodlist;

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FoodReportItem item = (FoodReportItem)dataGridView1.CurrentRow.DataBoundItem;

            bool isExist = false;
            int selectedIndex = 0;

            foreach (ListViewItem x in orderList.Items)
            {
                if (item.FoodName == x.Text)
                {
                    isExist = true;
                    break;
                }
                selectedIndex++;
            }

            if (isExist == true)
            {
                int count = int.Parse(orderList.Items[selectedIndex].SubItems[2].Text);
                count++;

                int price = int.Parse(orderList.Items[selectedIndex].SubItems[1].Text);

                orderList.Items[selectedIndex].SubItems[2].Text = count.ToString();
                orderList.Items[selectedIndex].SubItems[1].Text = (price + item.Price).ToString();
            }
            else
            {
                ListViewItem listitem = new ListViewItem(item.FoodName);
                listitem.SubItems.Add(item.Price.ToString());
                listitem.SubItems.Add("1");
                orderList.Items.Add(listitem);
            }

            int sum = 0;
            foreach (ListViewItem x in orderList.Items)
            {
                sum += int.Parse(x.SubItems[1].Text);
            }

            totalPrice.Text = sum.ToString();
        }

        private void orderListView_DoubleClickToRemove(object sender, EventArgs e)
        {
//            MessageBox.Show("더블클릭");
            foreach (ListViewItem x in orderList.Items)
            {
                if (orderList.SelectedItems.Count > 0)
                {
                    orderList.Items.RemoveAt(x.Index);
                }
            }
            
        }
    }
}
