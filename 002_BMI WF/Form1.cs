using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _002_BMI_WF
{
    public partial class BMI_form : Form
    {
        public BMI_form()
        {
            InitializeComponent();
        }

        private void btn_BMI_Click(object sender, EventArgs e)
        {
            double weight = double.Parse(txt_kg.Text);
            double height = double.Parse(txt_cm.Text);
            double BMI = weight / (height / 100 * height / 100);

            lbl_bmi.Text = String.Format("BMI = {0:F2} ", BMI);

            if (BMI < 20)
            {
                lbl_result.Text = "저체중";
                pictureBox1.BackColor = Color.Blue;
            }
            else if (20 <= BMI && BMI < 25)
            {
                lbl_result.Text = "정상체중";
                pictureBox1.BackColor = Color.Green;
            }
            else if (25 <= BMI && BMI < 30)
            {
                lbl_result.Text = "경도비만";
                pictureBox1.BackColor = Color.Orange;
            }
            else if (30 <= BMI && BMI < 40)
            {
                lbl_result.Text = "비만";
                pictureBox1.BackColor = Color.OrangeRed;
            }
            else
            {
                lbl_result.Text = "고도비만";
                pictureBox1.BackColor = Color.Red;
            }
                
        }
    }
}
