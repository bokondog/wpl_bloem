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
        string appLanguage = "NL";

        private void SetBackgroundColor(Color color)
        {
            SolidColorBrush brush = new SolidColorBrush(color);
            MainScreen.Background = brush;
        }

        private void ResetBackgroundColor()
        {
            SetBackgroundColor(defaultColor);
        }

        private void ShowStoreName()
        {
            if (appLanguage == "NL")
            {
                TxtStoreTitle.Text = "Bloemenwinkel";
            }
            else if (appLanguage == "EN")
            {
                TxtStoreTitle.Text = "Flower store";
            }
        }

        private void ResetFlowerInfo()
        {
            LblFlowerName.Content = "";
            LblFlowerPrice.Content = "";
        }

        private void ShowFlowerName(string dutchName, string englishName)
        {
            string labelText = "";
            if (appLanguage == "NL")
            {
                labelText = "Naam: ";
                LblFlowerName.Content = $"{labelText}{dutchName}";
            }
            else if (appLanguage == "EN")
            {
                labelText = "Name: ";
                LblFlowerName.Content = $"{labelText}{englishName}";
            }
        }

        private void ShowFlowerPrice(int price)
        {
            string labelText = appLanguage == "NL" ? "Prijs" : "Price";
            LblFlowerPrice.Content = $"{labelText}: {price.ToString("c")}";
        }

        private void SetAppLanguage(string languageCode)
        {
            appLanguage = languageCode;
            ResetFlowerInfo();
            ShowStoreName();
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

        private void ImgGold_MouseUp(object sender, MouseButtonEventArgs e)
        {
            ShowFlowerName("Goudsbloem", "Marigold");
            ShowFlowerPrice(3);
        }

        private void ImgLavender_MouseUp(object sender, MouseButtonEventArgs e)
        {
            ShowFlowerName("Lavendel", "Lavender");
            ShowFlowerPrice(10);
        }

        private void ImgRose_MouseUp(object sender, MouseButtonEventArgs e)
        {
            ShowFlowerName("Roos", "Rose");
            ShowFlowerPrice(30);
        }

        private void ImgWilkens_MouseUp(object sender, MouseButtonEventArgs e)
        {
            ShowFlowerName("Wilkens bitter", "Golden trumpet");
            ShowFlowerPrice(15);
        }

        private void BtnDutch_Click(object sender, RoutedEventArgs e)
        {
            SetAppLanguage("NL");
        }

        private void BtnEnglish_Click(object sender, RoutedEventArgs e)
        {
            SetAppLanguage("EN");
        }

    }
}
