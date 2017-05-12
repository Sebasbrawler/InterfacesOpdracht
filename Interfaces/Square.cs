using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Shapes;

namespace Interfaces
{
    public class Square : Shape
    {
        private Rectangle rect;

        public Square(int initX, int initY)
        {
            x = initX;
            y = initY;
            CreateRectangle();
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