using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PCBaam.Data;

namespace PCBaam.CUI
{
    class Program
    {
        static void Main(string[] args)
        {
            int aaaaa;

            PC_Cafe_OrderEntities context = new PC_Cafe_OrderEntities();

            List<Customer> customers = context.Customers.ToList();

            foreach (var x in customers)
            {
                Console.WriteLine(x.회원id);
                Console.WriteLine(x.패스워드);
            }
        }
    }
}
