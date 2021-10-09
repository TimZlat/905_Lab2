using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (peopleList.Text.Length != 0)
            {
                memberList.Items.Add(peopleList.Text);
            }
            else
                MessageBox.Show("Выберите элемент из списка или введите новый");
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            while (memberList.Text.Length > 0)
                memberList.Items.RemoveAt(memberList.CheckedIndices[0]);
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            memberList.Sorted = true;
        }
    }
}
