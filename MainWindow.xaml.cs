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

namespace Wpf_Lesson1
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

        private void StackPanel_MouseMove(object sender, MouseEventArgs e)
        {
            btn.Content = Mouse.GetPosition(Application.Current.MainWindow).X;
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("WPF", "Clicked To Inner Button", MessageBoxButton.OKCancel, MessageBoxImage.Warning);
            if (result == MessageBoxResult.OK)
            {
                btn.Background = Brushes.Orange;
            }
        }

        private void btn1_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
