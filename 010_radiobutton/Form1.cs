using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _010_radiobutton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string result = "";
            if (rbKorea.Checked)
                result = "국적 : 대한민국\n";
            else if (rbChina.Checked)
                result = "국적 : 중국\n";
            else if (rbJapan.Checked)
                result = "국적 : 일본\n";
            else if (rbOthers.Checked)
                result = "국적 : 그 외\n";

            if (rbMale.Checked)
                result += "성별 : 남자";
            else if (rbFemale.Checked)
                result += "성별 : 여자";
            MessageBox.Show(result, "Result");
        }
    }
}
