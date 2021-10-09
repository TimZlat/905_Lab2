using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistationForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                //создали новый control типа Label
                Label lbl = new Label();
                lbl.Location = new Point(16, 96);
                lbl.Size = new Size(40, 30);
                lbl.Name = "label99";
                lbl.TabIndex = 2;
                lbl.Text = "PIN2";
                //добавили его к контролам внутри groupBox
                groupBox1.Controls.Add(lbl);
                //создаем новый контрол типа textBox
                TextBox txt = new TextBox();
                txt.Location = new Point(96, 96);
                txt.Size = new Size(184, 20);
                txt.Name = "txtBoxx";
                txt.TabIndex = 1;
                txt.Text = "";
                groupBox1.Controls.Add(txt);
                txt.KeyPress += new KeyPressEventHandler(this.textBox2_KeyPress);
            }

            else
            {
                int lcv;
                lcv = groupBox1.Controls.Count;
                while (lcv>0)
                {
                    groupBox1.Controls.RemoveAt(lcv - 1);
                    lcv -= 1;
                }
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //упр.9
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Поле Name не долдно содержать цифры");
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Поле PIN должно содержать только цифры");
            }
        }
    }
}
