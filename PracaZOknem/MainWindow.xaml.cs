using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PracaZOknem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string happyschrader = "https://media.tenor.com/Tq1eQMvtYg0AAAAM/hank-from-breaking-bad-xd.gif";
        private string madschrader = "https://ih1.redbubble.net/image.2329060803.8718/mp,504x498,matte,f8f8f8,t-pad,600x600,f8f8f8.jpg";
        public MainWindow()
        {
            InitializeComponent();
            ZdjToggle.Source = new System.Windows.Media.Imaging.BitmapImage(new Uri(happyschrader));

        }
        private void ToggleButton_Checked(object sender, RoutedEventArgs e)
        {
            ZdjToggle.Source = new System.Windows.Media.Imaging.BitmapImage(new Uri(madschrader));
        }
        private void ToggleButton_Unchecked(object sender, RoutedEventArgs e)
        {
            ZdjToggle.Source = new System.Windows.Media.Imaging.BitmapImage(new Uri(happyschrader));
        }

        private void op12_Checked(object sender, RoutedEventArgs e)
        {
            fortnite.Text = "I love Fortnite";
            fortnite.Foreground = new SolidColorBrush(Colors.Navy);
        }

        private void op22_Checked(object sender, RoutedEventArgs e)
        {
            fortnite.Text = "I love Roblox";
            fortnite.Foreground = new SolidColorBrush(Colors.Green);
        }

        private void op32_Checked(object sender, RoutedEventArgs e)
        {
            fortnite.Text = "I love Minecraft";
            fortnite.Foreground = new SolidColorBrush(Colors.Red);
        }
    }
}