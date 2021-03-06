﻿using System;
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
using System.Windows.Markup;
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
        
        private void drawCanvas_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

            Point p = Mouse.GetPosition(drawCanvas);
            if (comboBox.SelectedValue == "Circle")
            {
                Circle circle1 = new Circle(Convert.ToInt32(p.X), Convert.ToInt32(p.Y), true);
                circle1.DisplayOn(drawCanvas);
            }
            else if (comboBox.SelectedValue == "Square")
            {
                Square square1 = new Square(Convert.ToInt32(p.X), Convert.ToInt32(p.Y), true);
                square1.DisplayOn(drawCanvas);
            }
            else if (comboBox.SelectedValue == "Line")
            {
                Line line1 = new Line(Convert.ToInt32(p.X), Convert.ToInt32(p.Y), true);
                line1.DisplayOn(drawCanvas);
            }

        }

        private void drawCanvas_PreviewMouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            Point p = Mouse.GetPosition(drawCanvas);
            if (comboBox.SelectedValue == "Circle")
            {
                Circle circle1 = new Circle(Convert.ToInt32(p.X), Convert.ToInt32(p.Y), false);
                circle1.DisplayOn(drawCanvas);
            }
            else if (comboBox.SelectedValue == "Square")
            {
                Square square1 = new Square(Convert.ToInt32(p.X), Convert.ToInt32(p.Y), false);
                square1.DisplayOn(drawCanvas);
            }
            else if (comboBox.SelectedValue == "Line")
            {
                Line line1 = new Line(Convert.ToInt32(p.X), Convert.ToInt32(p.Y), false);
                line1.DisplayOn(drawCanvas);
            }
            }
        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            string savedButton = XamlWriter.Save(drawCanvas.Children);
            System.IO.StreamWriter file = new System.IO.StreamWriter("saved.txt");
            file.WriteLine(savedButton);
            file.Close();
        }
       
    }
}
