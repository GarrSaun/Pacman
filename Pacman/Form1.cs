using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Pacman
{
    public partial class pacForm : Form
    {
        public pacForm()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            //Graphic Setup
            startButton.Visible = false;
            Graphics fG = this.CreateGraphics();
            Pen drawPen = new Pen(Color.Blue, 5);
            SolidBrush drawBrush = new SolidBrush(Color.Black);

            //path
            fG.DrawRectangle(drawPen, 0, 30, 300, 100);
            fG.FillRectangle(drawBrush, 0, 30, 250, 100);

            fG.DrawRectangle(drawPen, 300, 30, 100, 300);
            fG.FillRectangle(drawBrush, 300, 30, 100, 300);

            drawPen.Color = Color.Black;
            fG.DrawRectangle(drawPen, 250, 32, 80, 95);
            fG.FillRectangle(drawBrush, 250, 32, 80, 95);

            fG.DrawRectangle(drawPen, 300, 302, 110, 95);
            fG.FillRectangle(drawBrush, 300, 302, 110, 95);

            //Pacman
            Pen pacPen = new Pen(Color.Black);
            SolidBrush pacBrush = new SolidBrush(Color.Yellow);
            SolidBrush eraseBrush = new SolidBrush(Color.Black);

            fG.DrawPie(pacPen, 35, 40, 75, 75, 30, 300);
            fG.FillPie(pacBrush, 35, 40, 75, 75, 30, 300);
            Thread.Sleep(500);

            fG.DrawEllipse(pacPen, 35, 40, 75, 75);
            fG.FillEllipse(eraseBrush, 35, 40, 75, 75);

            fG.DrawEllipse(pacPen, 135, 40, 75, 75);
            fG.FillEllipse(pacBrush, 135, 40, 75, 75);
            Thread.Sleep(500);

            fG.DrawEllipse(pacPen, 135, 40, 75, 75);
            fG.FillEllipse(eraseBrush, 135, 40, 75, 75);

            fG.DrawPie(pacPen, 235, 40, 75, 75, 30, 300);
            fG.FillPie(pacBrush, 235, 40, 75, 75, 30, 300);
            Thread.Sleep(500);

            fG.DrawEllipse(pacPen, 235, 40, 75, 75);
            fG.FillEllipse(eraseBrush, 235, 40, 75, 75);

            fG.DrawEllipse(pacPen, 310, 40, 75, 75);
            fG.FillEllipse(pacBrush, 310, 40, 75, 75);
            Thread.Sleep(500);

            fG.DrawEllipse(pacPen, 310, 40, 75, 75);
            fG.FillEllipse(eraseBrush, 310, 40, 75, 75);

            fG.DrawPie(pacPen, 310, 140, 75, 75, 120, 300);
            fG.FillPie(pacBrush, 310, 140, 75, 75, 120, 300);
            Thread.Sleep(500);

            fG.DrawEllipse(pacPen, 310, 140, 75, 75);
            fG.FillEllipse(eraseBrush, 310, 140, 75, 75);

            fG.DrawEllipse(pacPen, 310, 240, 75, 75);
            fG.FillEllipse(pacBrush, 310, 240, 75, 75);

            //Text
            Font conFont = new Font("Segoe UI", 24, FontStyle.Bold);
            SolidBrush conBrush = new SolidBrush(Color.Red);
            fG.DrawString("Congratulations!", conFont, conBrush, 50, 40);


        }
    }
}
