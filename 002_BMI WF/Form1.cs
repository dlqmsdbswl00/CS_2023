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
            lbl_bmi.Text = "BMI = " + BMI;
        }
    }
}
