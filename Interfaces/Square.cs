using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Interfaces
{
    public class Square : Shape
    {
        private Rectangle rect;

        public Square(int initX, int initY, bool leftclck)
        {
            x = initX;
            y = initY;
            bool leftclick = leftclck;
            if (leftclick)
            {
                CreateRectangle();
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
            this.rect = new Rectangle();
            rect.Fill = brsh;
            rect.Height = this.size;
            rect.Width = this.size;
            rect.Margin = new Thickness(x, y, 0, 0);
            rect.ToolTip = brsh.Color.ToString();
        }

        private void CreateRectangle()
        {
            rect = new Rectangle();
            rect.Stroke = brush;
            rect.Width = size;
            rect.Height = size;
            rect.Margin = new Thickness(this.x,this.y,0,0);

        }

        public override void DisplayOn(Canvas drawArea)
        {
            drawArea.Children.Add(this.rect);
        }
    }
}