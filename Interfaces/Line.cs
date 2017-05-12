using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Interfaces
{
    public class Line:Shape
    {
        private System.Windows.Shapes.Line line;

        public Line(int initx1, int inity1)
        {
            x = initx1;
            y = inity1;
            CreateLine();
        }

        private void CreateLine()
        {
            line = new System.Windows.Shapes.Line();
            line.Stroke = brush;
        
            line.X1 = x;
            line.X2 = x + 50;
            line.Y1 = y;
            line.Y2 = y + 50;
        }

        public override void DisplayOn(Canvas drawArea)
        {
            drawArea.Children.Add(this.line);
        }
    }
}