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

        List<int> foodIdList = new List<int>();

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


            var query1 = from x in context.Orders
                select new ChartItem
                {
                    FoodName = x.Food.음식이름,
                    Count = x.수량
                };

            List<ChartItem> list = query1.ToList();

            List<ChartItem> sumChartItems = list.GroupBy(x => x.FoodName).Select(
                x => new ChartItem
                {
                    FoodName = x.Key,
                    Count = x.Sum(y => y.Count)
                }).ToList();

            chartBindingSource.DataSource = sumChartItems;
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

                PC_Cafe_OrderEntities1 context = new PC_Cafe_OrderEntities1();

                var query = from x in context.Foods
                            where x.음식이름 == item.FoodName
                            select x.음식id;
                foodIdList.Add(query.ToList()[0]);
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

        private void OrderOkButton_Click(object sender, EventArgs e)
        {
            PC_Cafe_OrderEntities1 context = new PC_Cafe_OrderEntities1();

            int a = 0;
            foreach (ListViewItem x in orderList.Items)
            {
                Order order = new Order();

                order.수량 = int.Parse(x.SubItems[2].Text);
                order.음식id = foodIdList[a];
                a++;
                order.회원번호 = LoginInfo.customerNumber;
                order.주문날짜시간 = DateTime.Now;

                context.Orders.Add(order);
            }
            context.SaveChanges();
            foodIdList.Clear();
            orderList.Items.Clear();
            MessageBox.Show("주문이 완료되었습니다!!");
        }

        private void chartButton_Click(object sender, EventArgs e)
        {
            PC_Cafe_OrderEntities1 context = new PC_Cafe_OrderEntities1();


        }
    }
}
