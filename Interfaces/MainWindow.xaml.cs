using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Interfaces
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {

            InitializeComponent();
            comboBox.Items.Add("Circle");
            comboBox.Items.Add("Square");
            comboBox.Items.Add("Line");
            comboBox.SelectedValue = "Circle";
        }

        private void drawCanvas_MouseUp(object sender, MouseButtonEventArgs e)
        {
            //Point p = Mouse.GetPosition(drawCanvas);
            //Circle circle1 = new Circle(Convert.ToInt32(p.X), Convert.ToInt32(p.Y));
            // Square square1 = new Square(180,180);
            // Line  line1 = new Line(200,200);
            //  List<Shape> group = new List<Shape>();

            //   group.Add(circle1);
            //  group.Add(square1);
            //  group.Add(line1);
            //   foreach (Shape shape in group)
            //   {
            //   circle1.DisplayOn(drawCanvas);
            // }
        }

        private void drawCanvas_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

            Point p = Mouse.GetPosition(drawCanvas);
            Square square1 = new Square(Convert.ToInt32(p.X), Convert.ToInt32(p.Y));
            Circle circle1 = new Circle(Convert.ToInt32(p.X), Convert.ToInt32(p.Y));
            Line line1 = new Line(Convert.ToInt32(p.X), Convert.ToInt32(p.Y));
            if (comboBox.SelectedValue == "Circle")
            {
                circle1.DisplayOn(drawCanvas);
            }
            else if (comboBox.SelectedValue == "Square")
            {
                square1.DisplayOn(drawCanvas);
            }
            else if (comboBox.SelectedValue == "Line")
            {
                line1.DisplayOn(drawCanvas);
            }

        }

        private void drawCanvas_PreviewMouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            Random rnd = new Random();
           



            Point p = Mouse.GetPosition(drawCanvas);
            Square square1 = new Square(Convert.ToInt32(p.X), Convert.ToInt32(p.Y));
            Circle circle1 = new Circle(Convert.ToInt32(p.X), Convert.ToInt32(p.Y));
            Line line1 = new Line(Convert.ToInt32(p.X), Convert.ToInt32(p.Y));
            circle1.DisplayOn(drawCanvas);
            

            

        }
       
    }
}
