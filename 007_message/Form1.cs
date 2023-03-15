using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _007_message
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("간단한 메시지 박스 입니다");
            MessageBox.Show("제목 표시 메시지 박스입니다", "제목");
            DialogResult result1 = MessageBox.Show("배경색을 변경할까요", 
                "Question", MessageBoxButtons.YesNo);   //메시지박스 결과를 result1에 저장
            if (result1 == DialogResult.Yes)
                this.BackColor = Color.Yellow;
        }
    }
}
