using System;
using System.Collections.Generic;
using System.Linq;
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

namespace FiguresMain
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static List<Figure> figures = new List<Figure>();
        public MainWindow()
        {
            InitializeComponent();
            List<string> styles = new List<string> { "Light", "Dark" };
            styleBox.SelectionChanged += ThemeChanged;
            styleBox.ItemsSource = styles;
            styleBox.SelectedItem = "Light";
        }

        private void ThemeChanged(object sender, SelectionChangedEventArgs e)
        {
            string style = styleBox.SelectedItem as string;
            var uri = new Uri(style + ".xaml", UriKind.Relative);
            ResourceDictionary resDict = Application.LoadComponent(uri) as ResourceDictionary;
            Application.Current.Resources.Clear();
            Application.Current.Resources.MergedDictionaries.Add(resDict);
        }

        private void btnDrawFigures_Click(object sender, RoutedEventArgs e)
        {
            myCanvas.Children.Clear();

            int left = 0;
            for (int i = 0; i < figures.Count; i++)
            {

                left += 60;

                Shape shape = figures[i].MyShape;
                shape.MouseLeftButtonDown += MyShape_MouseLeftButtonDown;
                shape.MouseLeftButtonUp += MyShape_MouseLeftButtonUp;
                shape.MouseMove += MyShape_MouseMove;

                Canvas.SetLeft(shape, left);
                Canvas.SetTop(shape, 30);
                myCanvas.Children.Add(shape);
            }
            //foreach (var figure in figures)
            //{
            //    Shape shape = figure.MyShape;
            //    shape.MouseLeftButtonDown += MyShape_MouseLeftButtonDown;
            //    shape.MouseLeftButtonUp += MyShape_MouseLeftButtonUp;
            //    shape.MouseMove += MyShape_MouseMove;

            //    Canvas.SetLeft(shape, 30);
            //    Canvas.SetTop(shape, 30);
            //    myCanvas.Children.Add(shape);
            //}

        }
        private void btnAddFigure_Click(object sender, RoutedEventArgs e)
        {
            Figure figure = new MyRectangle(70, 80);

            if (rbRectangle.IsChecked == true)
            {
                figure = new MyRectangle(70, 80);
            }
            if (rbTriangle.IsChecked == true)
            {
                figure = new MyTriangle(70, 80);
            }
            if (rbSquare.IsChecked == true)
            {
                figure = new MySquare();
            }
            if (rbRhombus.IsChecked == true)
            {
                figure = new MyRhombus();
            }
            if (rbParallelogram.IsChecked == true)
            {
                figure = new MyParallelogram();
            }
            if (rbTrapeze.IsChecked == true)
            {
                figure = new MyTrapeze();
            }
            if (rbCircle.IsChecked == true)
            {
                figure = new MyCircle();
            }
            if (rbEllipse.IsChecked == true)
            {
                figure = new MyEllipse();
            }

            figures.Add(figure);

        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            myCanvas.Children.Clear();
            figures.Clear();
        }

        private void MyShape_MouseMove(object sender, MouseEventArgs e)
        {
            Shape shape = (Shape)sender;

            if (!shape.IsMouseCaptured)
            {
                return;
            }

            var mousePos = e.GetPosition(myCanvas);


            double left = mousePos.X - (shape.ActualWidth / 2);
            double top = mousePos.Y - (shape.ActualHeight / 2);

            Canvas.SetLeft(shape, left);
            Canvas.SetTop(shape, top);
        }

        private void MyShape_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Shape shape = (Shape)sender;
            shape.CaptureMouse();
        }

        private void MyShape_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Shape shape = (Shape)sender;
            shape.ReleaseMouseCapture();
        }
    }
}
