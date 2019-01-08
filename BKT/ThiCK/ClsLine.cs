using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace ThiCK
{
    class ClsLine : ClsHinh
    {
        public ClsDiem begin = new ClsDiem();
        public ClsDiem end = new ClsDiem();
        public ClsLine()
        {
            begin = new ClsDiem(0, 0);
            end = new ClsDiem(0, 0);
        }
        public ClsLine(ClsDiem A, ClsDiem B)
        {
            begin = A;
            end = B;
        }
        public void Draw(Graphics g, Pen pen)
        {
            foreach (var item in save)
            {
                for (int i = 0; i < save.Count - 1; i += 2)
                {
                    g.DrawLine(pen, save[i].x, save[i].y, save[i + 1].x, save[i + 1].y);
                }
            }
        }
        public void AddPoint()
        {
            try
            {
                save.Add(begin);
                save.Add(end);
            }
            catch (Exception)
            {
            }
        }
    }
}
