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

namespace WPL_Bloem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        Color defaultColor = Colors.LightGray;

        private void SetBackgroundColor(Color color)
        {
            SolidColorBrush brush = new SolidColorBrush(color);
            MainScreen.Background = brush;
        }

        private void ResetBackgroundColor()
        {
            SetBackgroundColor(defaultColor);
        }

        private void Window_MouseEnter(object sender, MouseEventArgs e)
        {
            ResetBackgroundColor();
        }

        private void ImgGold_MouseEnter(object sender, MouseEventArgs e)
        {
            SetBackgroundColor(Colors.Orange);
        }

        private void ImgLavender_MouseEnter(object sender, MouseEventArgs e)
        {
            SetBackgroundColor(Colors.Purple);
        }

        private void ImgRose_MouseEnter(object sender, MouseEventArgs e)
        {
            SetBackgroundColor(Colors.Red);
        }

        private void ImgWilkens_MouseEnter(object sender, MouseEventArgs e)
        {
            SetBackgroundColor(Colors.Yellow);
        }

        private void ShowFlowerName(string name)
        {
            LblFlowerName.Content = name;
        }

        private void ImgGold_MouseUp(object sender, MouseButtonEventArgs e)
        {
            ShowFlowerName("Goudsbloem");
        }

        private void ImgLavender_MouseUp(object sender, MouseButtonEventArgs e)
        {
            ShowFlowerName("Lavendel");
        }

        private void ImgRose_MouseUp(object sender, MouseButtonEventArgs e)
        {
            ShowFlowerName("Roos");
        }

        private void ImgWilkens_MouseUp(object sender, MouseButtonEventArgs e)
        {
            ShowFlowerName("Wilkens bitter");
        }
    }
}
