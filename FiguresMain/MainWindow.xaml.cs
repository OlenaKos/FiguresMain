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
        }

        private void btnDrawFigures_Click(object sender, RoutedEventArgs e)
        {
            MyRectangle MyRect = new MyRectangle();
            Rectangle rect = new Rectangle();
            SolidColorBrush myBrush = new SolidColorBrush();
            myBrush.Color = Colors.Coral;
            rect.Fill = new SolidColorBrush(Colors.Coral);
            rect.Width = MyRect.GetSideA();
            rect.Height = MyRect.GetSideB();

            myStack.Children.Add(rect);


        }
    }
}
