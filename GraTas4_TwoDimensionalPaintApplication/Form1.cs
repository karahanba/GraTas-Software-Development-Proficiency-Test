//4) Design a 2D Paint application (including GUI) with coordinates and simple shapes: point, line, circle, square, and rectangle.
//a.User should enter only the minimum number of requirements to define the shape.
//b. 1D shapes must have a method to calculate length.
//c. 2D shapes must have methods to calculate circumference and area.
//d. (Bonus: Apply those processes for parallel edge.)

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GraTas4_TwoDimensionalPaintApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            bitmap = new Bitmap(pic.Width, pic.Height);
            graphics = Graphics.FromImage(bitmap);
            graphics.Clear(Color.White);
            pic.Image = bitmap;
        }

        Bitmap bitmap;
        Graphics graphics;
        bool paint = false;
        
        Pen p = new Pen(Color.Black, 1);
        Pen erase = new Pen(Color.White,10);
        int index;
        int x, y, sX, sY, cX, cY;

        private double findLength(int x1, int y1, int x2, int y2)
        {
            double length=0;
            length = Math.Sqrt((Math.Abs(x2 - x1) ^ 2) + (Math.Abs(y2 - y1) ^ 2));
            return length;
        }

        private double findCircumference(int width, int height)
        {
            double circumference = 0;
            if (index == 4 || index == 5)//circle or ellipse
            {
                circumference = 2*Math.PI* Math.Sqrt(0.5 * ((Math.Pow(width / 2, 2)) + (Math.Pow(height / 2, 2))));
            }
            else if (index == 6 || index == 7)//square or rectangle
            {
                circumference = 2 * (Math.Abs(width) + Math.Abs(height));
            }
            
            return circumference;
        }

        private double findArea(int width, int height) /**/
        {
            double area = 0;
            if (index == 4 || index == 5)//circle or ellipse
            {
                area = Math.PI * ((width / 2)) * ((height / 2));
            }
            else if (index == 6 || index == 7)//square or rectangle
            {
                area =width * height;
            }

            return area;
        }



        private void btnPencil_Click(object sender, EventArgs e)
        {
            index = 1;
        }
        private void btnEraser_Click(object sender, EventArgs e)
        {
            index = 2;
        }
        private void btnLine_Click(object sender, EventArgs e)
        {
            index = 3;
        }
        private void btnCircle_Click(object sender, EventArgs e)
        {
            //for ellipse
            index = 4;
        }
        private void btnEllipse_Click(object sender, EventArgs e)
        {
            index = 5;
        }
        private void btnSquare_Click(object sender, EventArgs e)
        {
            index = 6;
        }
        private void btnRectangle_Click(object sender, EventArgs e)
        {
            index = 7;
        }
        private void btnParallelEdge_Click(object sender, EventArgs e)
        {
            index = 8;
            MessageBox.Show("Not finished");
        }

        private void pic_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            if (paint)
            {
                if (index == 3)
                {
                    g.DrawLine(p, cX, cY, x, y);
                }

                if (index == 4) //circle
                {
                    if (sX>sY)
                    {
                        g.DrawEllipse(p, cX, cY, sX, sX);
                    }
                    else
                    {
                        g.DrawEllipse(p, cX, cY, sY, sY);
                    }
                    
                }

                if (index == 5)
                {
                    g.DrawEllipse(p, cX, cY, sX, sY);
                }

                if (index == 6)//square
                {
                    if (sX>sY)
                    {
                        sY = sX;
                        g.DrawRectangle(p, cX, cY, sX, sX);
                    }
                    else if (sY>=sX)
                    {
                        sX = sY;
                        g.DrawRectangle(p, cX, cY, sY, sY);
                    }
                    
                }

                if (index == 7)
                {
                    g.DrawRectangle(p, cX, cY, sX, sY);
                }

                if (index == 8)//parallel edge???
                {

                }

                
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This button is not functional yet.\nWork in progress...");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            graphics.Clear(Color.White);
            pic.Image = bitmap;
            index = 0;

            if (lblLength.Text != "-" || lblCircumference.Text != "-" || lblArea.Text != "-")
            {
                lblLength.Text = "-";
                lblCircumference.Text = "-";
                lblArea.Text = "-";
            }
        }

        Point start;
        Point end;

        private void pic_MouseDown(object sender, MouseEventArgs e)
        {
            // where mouse is 1st clicked
            paint = true;
            end = e.Location;

            cX = e.X;
            cY = e.Y;
        }

        private void pic_MouseMove(object sender, MouseEventArgs e)
        {
            if (paint)
            {
                if (index==1)
                {
                    start = e.Location;
                    graphics.DrawLine(p,start,end);
                    end = start;
                }

                if (index == 2)
                {
                    start = e.Location;
                    graphics.DrawLine(erase, start, end);
                    end = start;
                }
            }
            pic.Refresh();

            x = e.X;
            y = e.Y;
            sX = e.X - cX;
            sY = e.Y - cY;
        }


        private void pic_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;

            sX = x - cX;
            sY = y - cY;

            if (index == 3)
            {
                graphics.DrawLine(p, cX, cY, x, y);
                
                lblLength.Text=findLength(cX, cY, x, y).ToString();
            }

            if (index==4) // circle
            {
                if (sX>sY)
                {
                    graphics.DrawEllipse(p, cX, cY, sX, sX);
                }
                else
                {
                    graphics.DrawEllipse(p, cX, cY, sY, sY);
                }
                
                lblCircumference.Text = findCircumference(sX, sY).ToString();
                lblArea.Text = findArea(sX, sY).ToString();
            }

            if (index == 5)
            {
                graphics.DrawEllipse(p, cX, cY, sX, sY);

                lblCircumference.Text = findCircumference(sX, sY).ToString();
                lblArea.Text = findArea(sX, sY).ToString();
            }

            if (index == 6)
            {
                if (sX > sY)
                {
                    sY = sX; 
                    graphics.DrawRectangle(p, cX, cY, sX, sX);
                }
                else if (sY >= sX)
                {
                    sX = sY;
                    graphics.DrawRectangle(p, cX, cY, sY, sY);
                }

                lblCircumference.Text = findCircumference(sX, sY).ToString();
                lblArea.Text = findArea(sX, sY).ToString();

            }

            if (index == 7)
            {
                graphics.DrawRectangle(p, cX, cY, sX, sY);

                lblCircumference.Text = findCircumference(sX, sY).ToString();
                lblArea.Text = findArea(sX, sY).ToString();
            }

            
        }

        
    }
}
