using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawRectangle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            Graphics gs = this.CreateGraphics();

            Graph ract = new Graph();
            ract.LengthOfRect = int.Parse(lenText.Text);
            ract.WidthOfRect = int.Parse(widthText.Text);
            gs.Clear(this.BackColor);
            ract.DrawRect(gs);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Graphics gs = this.CreateGraphics();

            Graph ract = new Graph();
            ract.LengthOfRect = int.Parse(lenText.Text);
            ract.WidthOfRect = int.Parse(widthText.Text);
            ract.MouseX = e.X;
            ract.MouseY = e.Y;
            gs.Clear(this.BackColor);
            ract.DrawRectWithMouse(gs);
        }
    }
}