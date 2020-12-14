using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task4
{
    public partial class Form1 : Form
    {
        List<string> arr = new List<string>(){ "Один", "Два", "Три", "Четыре", "Пять", "Шесть", "Семь", "Восемь", "Девять" };
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.BeginUpdate();
            listBox1.Items.Clear();
            for(int i = 0; i < arr.Count; i++)
            {
                listBox1.Items.Add(arr[i]);
            }
            listBox1.EndUpdate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex != -1)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }
    }
}
