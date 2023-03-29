using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace _016_chart2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Chart Control";        //Form1의 제목 변경
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chart1.Titles.Add("성적");          //chart1의 제목 변경

            //시리즈1은 디폴트로 존재하므로 시리즈2 하나만 추가하면 됨
            chart1.Series.Add("Series2");

            chart1.Series[0].LegendText = "수학"; //시리즈[0]의 범주 변경
            chart1.Series[1].LegendText = "영어"; //시리즈[1]의 범주 변경

            Random r = new Random();              //랜덤생성
            for(int i=1; i<=10; i++)              //시리즈1, 2에 100까지의 수 10개 생성  
            {
                chart1.Series[0].Points.AddXY(i, r.Next(101));      //AddXY = x축 y축
                chart1.Series[1].Points.AddXY(i, r.Next(101));

            }
        }

        private void btn2chart_Click(object sender, EventArgs e)    //나누어 표시 버튼이 클릭되면
        {
            if (chart1.ChartAreas.Count == 1)                       //만약 ChartArea가 1개라면
                chart1.ChartAreas.Add("ChartArea2");                //ChartArea에 ChartArea2 추가
            chart1.Series[1].ChartArea = "ChartArea2";              //Series[1]의 ChartArea를 ChartArea2로 변경

        }

        private void btn1chart_Click(object sender, EventArgs e)    //합쳐서 표시 버튼이 클릭되면
        {
            if (chart1.ChartAreas.Count == 2)                       //만약 ChartArea가 2개라면
                chart1.ChartAreas.RemoveAt(1);                      //ChartArea2를 삭제한
            chart1.Series[1].ChartArea = "ChartArea1";              //Series[1]의 ChartArea를 ChartArea1로 변경
        }
    }
}
