using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace ThiCK
{
    public partial class Form1 : Form
    {
        Dictionary<string, List<ClsDiem>> data = new Dictionary<string, List<ClsDiem>>();
        Graphics g;
        Pen pen = new Pen(Color.Red, 1);
        bool canDraw = false;
        ClsDiem begin = new ClsDiem();
        ClsDiem end = new ClsDiem();
        ClsLine Line = new ClsLine();
        ClsRhombus Rhombus = new ClsRhombus();
        ClsTriangle Triangle = new ClsTriangle();
        Rectangle rect = new Rectangle();
        bool pointer, isLine, isTriangle;
        public Form1()
        {
            InitializeComponent();
            g = pictureBox1.CreateGraphics();
            pointer = true;
            isLine = false;
        }

        new void Update()
        {
            for (int i = 0; i < Line.save.Count - 1; i += 2)
            {
                Line.Draw(g, pen);
            }
           
        }

        private void toolStrip1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void toolStrip1_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void toolStrip1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (pointer == false)
            {
                canDraw = true;
                begin = new ClsDiem(e.X, e.Y);
                rect.X = e.X;
                rect.Y = e.Y;
            }

        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (pointer == false)
            {
                end.x = e.X;
                end.y = e.Y;
                canDraw = false;
                if (isLine)
                {
                    Line.begin = begin;
                    Line.end = end;
                    Line.AddPoint();
                }
               

            }
        }

        private void tbtLine_Click(object sender, EventArgs e)
        {
            pointer = false;
            isLine = true;
            isTriangle = false;

        }

        private void tbtContro_Click(object sender, EventArgs e)
        {
            pointer = true;
            isLine = false;
            isTriangle = false;

        }

        private void tbtOpen_Click(object sender, EventArgs e)
        {

            pointer = true;
            
            isLine = false;
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "json| *.json";
            open.ShowDialog();
            StreamReader reader = new StreamReader(open.FileName);
            var json = reader.ReadToEnd();
            data = JsonConvert.DeserializeObject<Dictionary<string, List<ClsDiem>>>(json);
            Line.LoadData(data, "line");
            Triangle.LoadData(data, "tam giac");
            reader.Close();
            Update();
        }

        private void tbtTriangle_Click(object sender, EventArgs e)
        {
           
        }

        private void tbtSave_Click(object sender, EventArgs e)
        {
            pointer = true;
            isLine = false;
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "json| *.json";
            save.ShowDialog();
            data.Add("line", Line.SaveData());
            StreamWriter writer = new StreamWriter(save.FileName);
            var json = JsonConvert.SerializeObject(data);
            writer.Write(json);
            writer.Close();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (canDraw == true)
            {
                end = new ClsDiem(e.X, e.Y);
                g.Clear(pictureBox1.BackColor);
                if (pointer)
                {
                    return;
                }
                else if (isLine == true)
                {
                    g.DrawLine(pen, begin.x, begin.y, e.X, e.Y);
                }
                else if (isTriangle == true)
                {
                    rect.Size = new Size(end.x - begin.x, end.y - begin.y);
                    g.DrawEllipse(pen, rect);
                }

                Update();
            }
        }
        
    }
}
