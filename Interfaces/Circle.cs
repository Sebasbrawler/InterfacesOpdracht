using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Interfaces
{
    public class Circle : Shape
    {
        private Ellipse ellipse;
        private Brush clr1;
        public Circle(int initx, int inity, bool leftclck)
        {
            x = initx;
            y = inity;
            bool leftclick = leftclck;
            if (leftclick)
            {
                CreateEllipse();
            }
            else
            {
                RndColor();   
            }
        }

        private void RndColor()
        {
            Random rnd = new Random();
            Color clr = Color.FromArgb(255, Convert.ToByte(rnd.Next(256)), Convert.ToByte(rnd.Next(256)), Convert.ToByte(rnd.Next(256)));
            SolidColorBrush brsh = new SolidColorBrush(clr);
            this.ellipse = new Ellipse();
            ellipse.Fill = brsh;
            ellipse.Height = this.size;
            ellipse.Width = this.size;
            ellipse.Margin = new Thickness(x, y, 0, 0);
            ellipse.ToolTip = brsh.Color.ToString();

        }

        private void CreateEllipse()
        {
            this.ellipse = new Ellipse();
            ellipse.Stroke = this.brush;
            ellipse.Height = size;
            ellipse.Width = this.size;
            ellipse.Margin = new Thickness(x, y ,0,0);
        }

        public override void DisplayOn(Canvas drawArea)
        {
            drawArea.Children.Add(ellipse);
        }
    }
}