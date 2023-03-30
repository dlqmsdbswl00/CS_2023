using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _021_adClock
{
    public partial class Form1 : Form
    {
        // 필드를 만든다
        private Graphics g;
        private bool aClockFlag = true;
        private Point center;   // 중심점
        private int radius;     // 반지름
        private int hourHand;   // 시침의 길이
        private int minHand;    // 분침
        private int secHand;    // 초침

        private const int clientSize = 450; // 클라이언트 사이즈
        private const int clockSize = 350; // 시계 사이즈

        public Form1()
        {
            InitializeComponent();
        }
    }
}
