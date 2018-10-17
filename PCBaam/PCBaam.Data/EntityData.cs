using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PCBaam.Data
{
    public class EntityData<T> where T: class
    {
        private static void PrintSQL(string sql)
        {
            Debug.WriteLine(sql);
        }

//        protected PC_Cafe_OrderEntities CreateContext()
//        {
//            var context = new PC_Cafe_OrderEntities();
//            context.Database.Log = PrintSQL;
//            context.Configuration.ProxyCreationEnabled = false;
//
//            return context;
//        }
//
//        // select
//        private static List<T> Select(PC_Cafe_OrderEntities context)
//        {
//            return new List<T>();
//        }
        
    }
}
