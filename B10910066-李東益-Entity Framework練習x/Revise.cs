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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace B10910066_李東益_Entity_Framework練習x
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ContactsTable data = new ContactsTable();
            var list1 = new List<ContactsTable>();
            var buyName = textBox1.Text.Trim();
            if (null != list1.FirstOrDefault((x) => x.Name == buyName))
            {
                list1.FirstOrDefault((x) => x.Name == buyName).Id = textBox2.Text.Trim();
                MessageBox.Show("修改完成");
                ClearTextBoxes();
            }
            else
            {
                MessageBox.Show("輸入到了錯誤的商品名稱!");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            ContactsTable data = new ContactsTable();
            var list1 = new List<ContactsTable>();
            var buyName = textBox1.Text.Trim();
            if (null != list1.FirstOrDefault((x) => x.Name == buyName))
            {
                list1.FirstOrDefault((x) => x.Name == buyName).Name = textBox2.Text.Trim();
                MessageBox.Show("修改完成");
                ClearTextBoxes();
            }
            else
            {
                MessageBox.Show("輸入到了錯誤的商品名稱!");
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            ContactsTable data = new ContactsTable();
            var list1 = new List<ContactsTable>();
            var buyName = textBox1.Text.Trim();
            if (null != list1.FirstOrDefault((x) => x.Name == buyName))
            {
                list1.FirstOrDefault((x) => x.Name == buyName).quantity = Convert.ToInt32(textBox2.Text.Trim());
                MessageBox.Show("修改完成");
                ClearTextBoxes();
            }
            else
            {
                MessageBox.Show("輸入到了錯誤的商品名稱!");
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            ContactsTable data = new ContactsTable();
            var list1 = new List<ContactsTable>();
            var buyName = textBox1.Text.Trim();
            if (null != list1.FirstOrDefault((x) => x.Name == buyName))
            {
                list1.FirstOrDefault((x) => x.Name == buyName).price = Convert.ToInt32(textBox2.Text.Trim());
                MessageBox.Show("修改完成");
                ClearTextBoxes();
            }
            else
            {
                MessageBox.Show("輸入到了錯誤的商品名稱!");
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            ContactsTable data = new ContactsTable();
            var list1 = new List<ContactsTable>();
            var buyName = textBox1.Text.Trim();
            if (null != list1.FirstOrDefault((x) => x.Name == buyName))
            {
                list1.FirstOrDefault((x) => x.Name == buyName).category = textBox2.Text.Trim();
                MessageBox.Show("修改完成");
                ClearTextBoxes();
            }
            else
            {
                MessageBox.Show("輸入到了錯誤的商品名稱!");
            }
        }
        private void ClearTextBoxes()
        {
            textBox1.Clear();
            textBox2.Clear();
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
