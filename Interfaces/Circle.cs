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
        public Circle(int initx, int inity)
        {
            
            x = initx;
            y = inity;
           
            CreateEllipse();
        }

        private Brush PickRandomBrush(Random rnd)
        {
            Brush result = Brushes.Transparent;
            Type brushesType = typeof(Brushes);
            PropertyInfo[] properties = brushesType.GetProperties();
            int random = rnd.Next(properties.Length);
            result = (Brush)properties[random].GetValue(null, null);
            return result;
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