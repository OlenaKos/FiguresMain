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
            foreach (var figure in figures)
            {
                myCanvas.Children.Add(figure.GetShape());
            }

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
            //MyRectangle MyRect = new MyRectangle(70, 80);
            //Rectangle rect = new Rectangle();
            //SolidColorBrush myBrush = new SolidColorBrush();
            //LinearGradientBrush linearGradientBrush = new LinearGradientBrush();
            //linearGradientBrush.StartPoint = new Point(0, 0);
            //linearGradientBrush.EndPoint = new Point(1, 1);
            //linearGradientBrush.GradientStops.Add (new GradientStop(Colors.Coral, 0.0));
            //linearGradientBrush.GradientStops.Add(new GradientStop(Colors.Yellow, 1.0));


            //myBrush.Color = Colors.Coral;
            //rect.Fill = linearGradientBrush;//new SolidColorBrush(Colors.Coral);
            //rect.Width = MyRect.GetSideA();
            //rect.Height = MyRect.GetSideB();

            //myStack.Children.Add(figure.GetShape());

            figures.Add(figure);

        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            myCanvas.Children.Clear();
            figures.Clear();
        }
    }
}
