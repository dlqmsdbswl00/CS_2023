using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _006_basiccontrols
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = string.Format(txt_name.Text);

            if (name == "")
                MessageBox.Show("이름을 입력하세요", "경고");
            else
                lbl_out.Text = name + "님! 반갑습니다!";
        }
    }
}