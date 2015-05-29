using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawRectangle
{
    public class Graph
    {
        public int LengthOfRect { get; set; }

        public int WidthOfRect { get; set; }

        public int MouseX { get; set; }

        public int MouseY { get; set; }

        public void DrawRect(Graphics graphis)
        {
            Pen pen = new Pen(Color.DeepSkyBlue, 2);

            graphis.DrawLine(pen, 0, 0, LengthOfRect, 0);
            graphis.DrawLine(pen, 0, 0, 0, WidthOfRect);
            graphis.DrawLine(pen, 0, WidthOfRect, LengthOfRect, WidthOfRect);
            graphis.DrawLine(pen, LengthOfRect, WidthOfRect, LengthOfRect, 0);
        }

        public void DrawRectWithMouse(Graphics graphis)
        {
            Pen pen = new Pen(Color.DeepSkyBlue, 2);

            graphis.DrawLine(pen, MouseX, MouseY, MouseX + LengthOfRect, MouseY);
            graphis.DrawLine(pen, MouseX, MouseY, MouseX, WidthOfRect + MouseY);
            graphis.DrawLine(pen, MouseX, MouseY + WidthOfRect, MouseX + LengthOfRect, MouseY + WidthOfRect);
            graphis.DrawLine(pen, LengthOfRect + MouseX, MouseY + WidthOfRect, LengthOfRect + MouseX, MouseY);
        }
    }
}