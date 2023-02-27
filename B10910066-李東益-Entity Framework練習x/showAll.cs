using B10910066_李東益_Entity_Framework練習x.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B10910066_李東益_Entity_Framework練習x
{
    public partial class showAll : Form
    {
        public showAll()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var list1 = new List<ContactsTable>();
            foreach (var v in list1)
            {
                MessageBox.Show($"商品編號:{v.Id} 商品名稱:{v.Name} 商品數量:{v.quantity} 價格:{v.price} 商品類別:{v.category}");
            }
        }
        static List<ContactsTable> CreateList()
        {
            var reader = new StreamReader(File.OpenRead(@"C:\Users\zack\Downloads\product.csv"));
            List<string> list = new List<string>();
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine().Split(',');
                foreach (var v in line)
                {
                    list.Add(v);
                }
            }
            List<ContactsTable> list1 = new List<ContactsTable>();
            for (int i = 5; i < list.Count; i += 5)
            {
                list1.Add(new ContactsTable { Id = list[i], Name = list[i + 1], quantity = Convert.ToInt32(list[i + 2]), price = Convert.ToInt32(list[i + 3]), category = list[i + 4] });
            }
            return new List<ContactsTable>(list1);
        }
    }
}
